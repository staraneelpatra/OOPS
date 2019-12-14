using System;
using System.Collections.Generic;

namespace NasaOrbiter
{
    public class RocketForge : IRocketForge
    {
        Rocket _rocket;
        public Rocket BuildRocket(string RocketName, int Range, string path, List<Satellite> integratedSatellite)
        {
            _rocket = new Rocket() { RocketName = RocketName, Range = Range, Path = path, IntegratedSatellite = integratedSatellite };
            return _rocket;
        }

        public void Changepath()
        {
            throw new NotImplementedException();
        }
    }
}
