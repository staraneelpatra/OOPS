using System;
using System.Collections.Generic;

namespace NasaOrbiter
{
    public class SatelliteForge : ISatelliteForge
    {
        List<Satellite> _satellitlist = new List<Satellite>();

        public List<Satellite> BuildSatellite()//string satelliteName, string satelliteType)
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Enter Satellite Name and Type for Sattelite #{i}");
                Satellite _sat = new Satellite() { SatelliteName = Console.ReadLine(), SatelliteType = Console.ReadLine() };
                _satellitlist.Add(_sat);
            }
            
            return _satellitlist;
        }

        public static implicit operator List<object>(SatelliteForge v)
        { {
                throw new NotImplementedException();
            }
        }
    }
}