using System;
using System.Collections.Generic;

namespace NasaOrbiter
{
    public interface IRocketForge
    {
        Rocket BuildRocket(string RocketName, int Range, string path,List<Satellite> satellites);       
        void Changepath();
    }
}
