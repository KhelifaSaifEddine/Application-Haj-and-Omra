using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDetailPageNavigation
{
    public class Location
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
    }

    public class SnappedPoint
    {
        public Location location { get; set; }
        public int originalIndex { get; set; }
        public string placeId { get; set; }
    }

    public class RootObject
    {
        public List<SnappedPoint> snappedPoints { get; set; }
    }
}
