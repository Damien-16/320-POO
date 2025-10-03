using Drones;
using Drones.Model;
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
            Drone drone = new Drone(100,100);
            drone.Name = "Joe";
            fleet.Add(drone);


            if (fleet.Count > 10)
            {
                    throw new Exception("trop de drone");

            }

            // Création des building
            List<Building> city = new List<Building>();

            // Usines
            city.Add(new Factory(1200.5, "Factory ", 100, 100));
            city.Add(new Factory(800.3, "Factory ", 300, 150));

            // Magasins
            city.Add(new Store("Store ",200,250,new List<string> { "Lundi: 8h-18h", "Mardi: 8h-18h", "Mercredi: 8h-18h" }
            ));

            city.Add(new Store("Store ",350,300,new List<string> { "Lundi: 9h-17h", "Mardi: 9h-17h", "Mercredi: 9h-17h" }
            ));


            // Démarrage
            Application.Run(new AirSpace(fleet, city));
        }
    }
}