using System;
using System.Collections.Generic;

namespace NasaOrbiter
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            List<Satellite> _satelliteList= new SatelliteForge().BuildSatellite();

           

            RocketForge rf = new RocketForge();
            Rocket Rockeluanch= rf.BuildRocket("PSLV", 7465, "Eleptical", _satelliteList);
            Console.WriteLine(Rockeluanch.RocketName);
            Console.WriteLine(Rockeluanch.Range);
            Console.WriteLine(Rockeluanch.Path);
            foreach (Satellite item in Rockeluanch.IntegratedSatellite)
            {
                Console.WriteLine(item.SatelliteName+" "+item.SatelliteType);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
