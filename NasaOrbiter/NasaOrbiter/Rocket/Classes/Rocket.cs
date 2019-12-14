using System;
using System.Collections.Generic;

namespace NasaOrbiter
{
    public class Rocket
    {
        public string RocketName { get; set; }
        public int Range { get; set; }
        public string Path { get; set; }
        public List<Satellite> IntegratedSatellite { get; set; }
    }
}
