using Drones;
using System.Xml.Schema;

namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Création de la flotte de drones
            List<Drone> fleet= new List<Drone>();
            Drone drone = new Drone();
            drone.X = 100;
            drone.Y = 100;
            drone.Name = "Joe";
            fleet.Add(drone);


            if (fleet.Count > 10)
            {
                    throw new Exception("trop de drone");

            }

            // Création des building
            List<Building> city = new List<Building>();
            Building factory1 = new Factory(5.55, "toto", 1, 1);
            city.Add(factory1);

            Building factory2 = new Factory(5.55, "factory", 100, 100);
            city.Add(factory1);


            // Démarrage
            Application.Run(new AirSpace(fleet, city));
        }
    }
}