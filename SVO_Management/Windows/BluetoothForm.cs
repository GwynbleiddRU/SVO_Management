using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Devices.Bluetooth.Advertisement;
using Bunifu.Framework.UI;
using BunifuAnimatorNS;
using System.Threading;
using Windows.Devices.Bluetooth;
using System.Diagnostics;
using Windows.Devices.Enumeration;
using Windows.UI.Core;
using Windows.Devices.Bluetooth.GenericAttributeProfile;

namespace SVO_Management
{
    public partial class BluetoothForm : Form
    {
        int count = 1;
        List<string> _devices = new List<string>();
        List<string> ConnectedDevices = new List<string>();
        BluetoothLEAdvertisementWatcher Watcher = new BluetoothLEAdvertisementWatcher();
        DeviceWatcher DeviceWatcher = DeviceInformation.CreateWatcher();
        CoreDispatcher Dispatcher;

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer { Interval = 10 };


        public BluetoothForm()
        {
            InitializeComponent();
            Watcher.Received += BeaconData.Watcher_Received;
        }

        #region PanelHeader
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion PanelHeader

        private void startButton_Click(object sender, EventArgs e)
        {
            //Watcher.Start();
            SetupBluetooth();

            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            StopScanning();
            timer.Stop();
            //Watcher.Stop();

            searchCircleProgressbar.Value = 0;
            count = 1;
        }

        private void WatcherOnReceived(BluetoothLEAdvertisementWatcher sender, BluetoothLEAdvertisementReceivedEventArgs btAdv)
        {
            string name = btAdv.Advertisement.LocalName.ToString();
            string address = btAdv.BluetoothAddress.ToString();

            deviceList.Items.Add(address, name);
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            if (searchCircleProgressbar.Value == 90)
            {
                count = -1;
                searchCircleProgressbar.animationIterval = 4;
            }
            else if (searchCircleProgressbar.Value == 10)
            {
                count = +1;
                searchCircleProgressbar.animationIterval = 2;
            }
            searchCircleProgressbar.Value += count;

            //Watcher.Received += WatcherOnReceived;
            Watcher.Received += DeviceFound;
        }

        private void BluetoothForm_Load(object sender, EventArgs e)
        {
            //searchProgressBar.Animation = 4;
            //searchProgressBar.AnimationStep = 1;
        }

        #region Bluetooth

        private void SetupBluetooth()
        {
            ConnectedDevices = new List<string>();

            Watcher = new BluetoothLEAdvertisementWatcher { ScanningMode = BluetoothLEScanningMode.Active };
            Watcher.Received += DeviceFound;

            DeviceWatcher = DeviceInformation.CreateWatcher();
            DeviceWatcher.Added += DeviceAdded;
            DeviceWatcher.Updated += DeviceUpdated;

            StartScanning();
        }

        private void StartScanning()
        {
            Watcher.Start();
            DeviceWatcher.Start();
        }

        private void StopScanning()
        {
            Watcher.Stop();
            DeviceWatcher.Stop();
        }

        //private async void DeviceFound(BluetoothLEAdvertisementWatcher watcher, BluetoothLEAdvertisementReceivedEventArgs btAdv)
        //{
        //    MessageBox.Show(btAdv.Advertisement.Flags + " FOUND!");

        //    if (_devices.Contains(btAdv.Advertisement.LocalName))
        //    {
        //        await Dispatcher.RunAsync(CoreDispatcherPriority.Low, async () =>
        //        {
        //            Debug.WriteLine($"---------------------- {btAdv.Advertisement.LocalName} ----------------------");
        //            Debug.WriteLine($"Advertisement Data: {btAdv.Advertisement.ServiceUuids.Count}");
        //            var device = await BluetoothLEDevice.FromBluetoothAddressAsync(btAdv.BluetoothAddress);
        //            var result = await device.DeviceInformation.Pairing.PairAsync(DevicePairingProtectionLevel.None);
        //            Debug.WriteLine($"Pairing Result: {result.Status}");
        //            Debug.WriteLine($"Connected Data: {device.GattServices.Count}");

        //            deviceList.Items.Add(btAdv.Advertisement.LocalName);
        //            MessageBox.Show("YEAH!");
        //        });
        //    }
        //}

        private async void DeviceFound(BluetoothLEAdvertisementWatcher watcher, BluetoothLEAdvertisementReceivedEventArgs btAdv)
        {
            //получаем силу сигнала эппл устройств по блютус (конкретизировать до ibeacon)
            const ushort AppleCompanyId = 0x004C;
            foreach (var adv in btAdv.Advertisement.ManufacturerData.Where(x => x.CompanyId == AppleCompanyId))
            {
                MessageBox.Show(String.Format(
                    "Сила сигнала: {0}",
                    btAdv.RawSignalStrengthInDBm
                    ));
            }

            //if (!ConnectedDevices.Contains(btAdv.Advertisement.LocalName) && _devices.Contains(btAdv.Advertisement.LocalName))
            //{
            //    await Dispatcher.RunAsync(CoreDispatcherPriority.Low, async () =>
            //    {
            //        var device = await BluetoothLEDevice.FromBluetoothAddressAsync(btAdv.BluetoothAddress);
            //        if (device.GattServices.Any())
            //        {
            //            ConnectedDevices.Add(device.Name);
            //            device.ConnectionStatusChanged += (sender, args) =>
            //            {
            //                ConnectedDevices.Remove(sender.Name);
            //            };
            //            //SetupWaxStream(device);

            //            //deviceList.Items.Add(device.Name + " obj.");
            //        }
            //        else if (device.DeviceInformation.Pairing.CanPair && !device.DeviceInformation.Pairing.IsPaired)
            //        {
            //            await device.DeviceInformation.Pairing.PairAsync(DevicePairingProtectionLevel.None);
            //        }
            //    });
            //}
        }

        private async void DeviceAdded(DeviceWatcher watcher, DeviceInformation device)
        {
            if (_devices.Contains(device.Name))
            {
                try
                {
                    var service = await GattDeviceService.FromIdAsync(device.Id);
                    Debug.WriteLine("Opened Service!!");
                }
                catch
                {
                    Debug.WriteLine("Failed to open service.");
                }
            }
        }

        private void DeviceUpdated(DeviceWatcher watcher, DeviceInformationUpdate update)
        {
            Debug.WriteLine($"Device updated: {update.Id}");
        }

        #endregion Bluetooth

    }
}
