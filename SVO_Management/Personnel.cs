using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVO_Management
{
    public class Personnel
    {
        public enum Type
        {
            Assistant,
            Carrier,
            Engineer,
            Police,
        }
        public int ID;
        public string Name;
        public Type Class;
        public GeoCoordinate Coord;

        public Personnel(string name, Type class_w, GeoCoordinate coord)
        {
            Name = name;
            Class = class_w;
            Coord = coord;
        }
        public void UpdateCoord(GeoCoordinate coord)
        {
            Coord = coord;
        }

    }
}