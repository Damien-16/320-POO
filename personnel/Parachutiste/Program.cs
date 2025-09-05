using System.Data;
using System.Numerics;

namespace Parachutiste
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> dropParachutist = new List<int>();

            Plane plane = new Plane();
            while (true)
            {
                plane.update();


                Console.Clear();
                plane.draw();


                Thread.Sleep(50);
            }
        }       
    }
}


