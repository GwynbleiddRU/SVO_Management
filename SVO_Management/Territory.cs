using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVO_Management
{
    class Territory
    {
        static string terminalD = @"55,9621735746372 37,3990058898926
                            55,9597953790663 37,4004650115967
                            55,9580897144821 37,4127817153931
                            55,9641432825455 37,4133396148682";
        static string terminalA = @"55,9834747267539 37,441577911377
                                    55,9827064561945 37,4413633346558
                                    55,9825744081549 37,442672252655
                                    55,9833306771866 37,4431228637695";
        static string terminalB = @"55,9820342069344 37,4113011360168
                                    55,9806776683817 37,4120092391968
                                    55,9814339745059 37,4161291122437
                                    55,9827064561945 37,4154210090637";
        static string terminalC = @"55,982202270345 37,4082541465759
                                    55,9800293942177 37,4090909957886
                                    55,9806416534355 37,4117946624756
                                    55,981914161194 37,4110651016235";
        static string terminalE = @"55,9652722162708 37,4129319190979
                                    55,9638190082593 37,4136185646057
                                    55,9645516240778 37,4189615249634
                                    55,9658606899415 37,4178457260132";
        static string terminalF = @"55,9670256012235 37,4132108688354
                                    55,9659927950457 37,4135541915894
                                    55,966449154663 37,4163436889648
                                    55,9674098941597 37,4157428741455";
        static string terminalFlight = @"55,976535729715 37,3817539215088
                                        55,9645276041069 37,3873329162598
                                        55,973173830221 37,448787689209
                                        55,9837388162336 37,4425220489502";
        static string terminalPort = @"55,9745666526033 37,380895614624
                                        55,9578014257185 37,3914527893066
                                        55,9709163908956 37,4588298797607
                                        55,9891642554679 37,4468994140625";




        public static Boolean WithinRectangle(Double latitudeNorth,
                                      Double longitudeWest,
                                      Double latitudeSouth,
                                      Double longitudeEast,
                                      Double latitude,
                                      Double longitude)
        {
            if (latitude > latitudeNorth)
                return false;
            else if (latitude < latitudeSouth)
                return false;

            if (longitudeEast >= longitudeWest)
                return ((longitude >= longitudeWest) && (longitude <= longitudeEast));
            else
                return (longitude >= longitudeWest) || (longitude <= longitudeEast);

        }
        public static string Check(double lat, double lng)
        {
            GeoCoordinate coordD1 = new GeoCoordinate(double.Parse(terminalD.Split('\n')[0].Trim().Split(' ')[0]),
                    double.Parse(terminalD.Split('\n')[0].Trim().Split(' ')[1]));

            GeoCoordinate coordD2 = new GeoCoordinate(double.Parse(terminalD.Split('\n')[2].Trim().Split(' ')[0]),
                double.Parse(terminalD.Split('\n')[2].Trim().Split(' ')[1]));

            GeoCoordinate coordF1 = new GeoCoordinate(double.Parse(terminalF.Split('\n')[0].Trim().Split(' ')[0]),
                    double.Parse(terminalF.Split('\n')[0].Trim().Split(' ')[1]));

            GeoCoordinate coordF2 = new GeoCoordinate(double.Parse(terminalF.Split('\n')[2].Trim().Split(' ')[0]),
                double.Parse(terminalF.Split('\n')[2].Trim().Split(' ')[1]));

            GeoCoordinate coordE1 = new GeoCoordinate(double.Parse(terminalE.Split('\n')[0].Trim().Split(' ')[0]),
                    double.Parse(terminalE.Split('\n')[0].Trim().Split(' ')[1]));

            GeoCoordinate coordE2 = new GeoCoordinate(double.Parse(terminalE.Split('\n')[2].Trim().Split(' ')[0]),
                double.Parse(terminalE.Split('\n')[2].Trim().Split(' ')[1]));

            GeoCoordinate coordFlight1 = new GeoCoordinate(double.Parse(terminalFlight.Split('\n')[0].Trim().Split(' ')[0]),
                    double.Parse(terminalFlight.Split('\n')[0].Trim().Split(' ')[1]));

            GeoCoordinate coordFlight2 = new GeoCoordinate(double.Parse(terminalFlight.Split('\n')[2].Trim().Split(' ')[0]),
                double.Parse(terminalFlight.Split('\n')[2].Trim().Split(' ')[1]));

            GeoCoordinate coordA1 = new GeoCoordinate(double.Parse(terminalA.Split('\n')[0].Trim().Split(' ')[0]),
                    double.Parse(terminalA.Split('\n')[0].Trim().Split(' ')[1]));

            GeoCoordinate coordA2 = new GeoCoordinate(double.Parse(terminalA.Split('\n')[2].Trim().Split(' ')[0]),
                double.Parse(terminalA.Split('\n')[2].Trim().Split(' ')[1]));

            GeoCoordinate coordB1 = new GeoCoordinate(double.Parse(terminalB.Split('\n')[0].Trim().Split(' ')[0]),
                    double.Parse(terminalB.Split('\n')[0].Trim().Split(' ')[1]));

            GeoCoordinate coordB2 = new GeoCoordinate(double.Parse(terminalB.Split('\n')[2].Trim().Split(' ')[0]),
                double.Parse(terminalB.Split('\n')[2].Trim().Split(' ')[1]));

            GeoCoordinate coordC1 = new GeoCoordinate(double.Parse(terminalC.Split('\n')[0].Trim().Split(' ')[0]),
                    double.Parse(terminalC.Split('\n')[0].Trim().Split(' ')[1]));

            GeoCoordinate coordC2 = new GeoCoordinate(double.Parse(terminalC.Split('\n')[2].Trim().Split(' ')[0]),
                double.Parse(terminalC.Split('\n')[2].Trim().Split(' ')[1]));


            GeoCoordinate coordPort1 = new GeoCoordinate(double.Parse(terminalPort.Split('\n')[0].Trim().Split(' ')[0]),
                   double.Parse(terminalPort.Split('\n')[0].Trim().Split(' ')[1]));

            GeoCoordinate coordPort2 = new GeoCoordinate(double.Parse(terminalPort.Split('\n')[2].Trim().Split(' ')[0]),
                double.Parse(terminalPort.Split('\n')[2].Trim().Split(' ')[1]));

            if (Territory.WithinRectangle(coordD1.Latitude, coordD1.Longitude, coordD2.Latitude, coordD2.Longitude, lat, lng))
            {
                return "Терминал D";
            }
            else if (Territory.WithinRectangle(coordE1.Latitude, coordE1.Longitude, coordE2.Latitude, coordE2.Longitude, lat, lng))
            {
                return "Терминал E";
            }
            else if (Territory.WithinRectangle(coordF1.Latitude, coordF1.Longitude, coordF2.Latitude, coordF2.Longitude, lat, lng))
            {
                return "Терминал F";
            }

            else if (Territory.WithinRectangle(coordC1.Latitude, coordC1.Longitude, coordC2.Latitude, coordC2.Longitude, lat, lng))
            {
                return "Терминал C";
            }
            else if (Territory.WithinRectangle(coordB1.Latitude, coordB1.Longitude, coordB2.Latitude, coordB2.Longitude, lat, lng))
            {
                return "Терминал B";
            }
            else if (Territory.WithinRectangle(coordFlight1.Latitude, coordFlight1.Longitude, coordFlight2.Latitude, coordFlight2.Longitude, lat, lng))
            {
                return "Взлетная полоса";
            }
            else if (Territory.WithinRectangle(coordA1.Latitude, coordA1.Longitude, coordA2.Latitude, coordA2.Longitude, lat, lng))
            {
                return "Терминал A";
            }
            else if (Territory.WithinRectangle(coordPort1.Latitude, coordPort1.Longitude, coordPort2.Latitude, coordPort2.Longitude, lat, lng))
            {
                return "Аэропорт Шерементьево";
            }
            return "Аэропорт Шерементьево";
        }
    }
}
