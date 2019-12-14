using System;
namespace NasaOrbiter
{
    public interface ISatellite
    {
        string SatelliteName { get; set; }
        string SatelliteType { get; set; }
    }
}
