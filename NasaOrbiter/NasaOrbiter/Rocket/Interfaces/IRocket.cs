using System;
using System.Collections.Generic;

namespace NasaOrbiter
{
    public interface IRocket
    {
         string RocketName { get; set; }
         int Range { get; set; }
         string Path { get; set; }
         List<Satellite> IntegratedSatellite { get; set; }
    }
}
