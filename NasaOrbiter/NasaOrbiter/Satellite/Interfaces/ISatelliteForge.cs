using System;
using System.Collections.Generic;

namespace NasaOrbiter
{
    public interface ISatelliteForge
    {
        List<Satellite> BuildSatellite();//string satelliteName, string satelliteType);
    }
}
