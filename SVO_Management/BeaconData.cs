using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Windows.Devices.Bluetooth.Advertisement;
using Windows.Storage.Streams;

namespace SVO_Management
{
    class BeaconData
    {
        public Guid Uuid { get; set; }
        public ushort Major { get; set; }
        public ushort Minor { get; set; }
        public sbyte TxPower { get; set; }
        public static BeaconData FromBytes(byte[] bytes)
        {
            if (bytes[0] != 0x02) { throw new ArgumentException("First byte in array was exptected to be 0x02", "bytes"); }
            if (bytes[1] != 0x15) { throw new ArgumentException("Second byte in array was expected to be 0x15", "bytes"); }
            if (bytes.Length != 23) { throw new ArgumentException("Byte array length was expected to be 23", "bytes"); }
            return new BeaconData
            {
                Uuid = new Guid(
                        BitConverter.ToInt32(bytes.Skip(2).Take(4).Reverse().ToArray(), 0),
                        BitConverter.ToInt16(bytes.Skip(6).Take(2).Reverse().ToArray(), 0),
                        BitConverter.ToInt16(bytes.Skip(8).Take(2).Reverse().ToArray(), 0),
                        bytes.Skip(10).Take(8).ToArray()),
                Major = BitConverter.ToUInt16(bytes.Skip(18).Take(2).Reverse().ToArray(), 0),
                Minor = BitConverter.ToUInt16(bytes.Skip(20).Take(2).Reverse().ToArray(), 0),
                TxPower = (sbyte)bytes[22]
            };
        }
        public static BeaconData FromBuffer(IBuffer buffer)
        {
            var bytes = new byte[buffer.Length];
            using (var reader = DataReader.FromBuffer(buffer))
            {
                reader.ReadBytes(bytes);
            }
            return BeaconData.FromBytes(bytes);
        }

        public static void Watcher_Received(BluetoothLEAdvertisementWatcher sender, BluetoothLEAdvertisementReceivedEventArgs args)
        {
            const ushort AppleCompanyId = 0x004C;
            foreach (var adv in args.Advertisement.ManufacturerData.Where(x => x.CompanyId == AppleCompanyId))
            {
                var beaconData = BeaconData.FromBuffer(adv.Data);
                MessageBox.Show(String.Format(
                    "[{0}] {1}:{2}:{3} TxPower={4}, Rssi={5}",
                    args.Timestamp,
                    beaconData.Uuid,
                    beaconData.Major,
                    beaconData.Minor,
                    beaconData.TxPower,
                    args.RawSignalStrengthInDBm));
            }
        }
    }
}
