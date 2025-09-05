using System.Data;
using System.Numerics;

namespace Parachutiste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane();
            while (true)
            {
                // Modifier le modèle (ce qui *est*)
                plane.update();
                

     // Modifier ce que l'on *voit*
     Console.Clear();
                plane.draw();

                // Temporiser
                Thread.Sleep(100);
            }

        }
        static class Config
        {
            public const int SCREEN_HEIGHT = 40;
            public const int SCREEN_WIDTH = 150;
        }
        class Plane
        {

            private string[] view =
      {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };
            private int x = 0;
            private int y = 5;
            public void draw()
            {
                for (int i = 0; i < view.Length; i++)
                {
                    Console.SetCursorPosition( x , y +i);
                    Console.WriteLine(view[i]);
                }

            }
            public void update() 
            {
                x++;
            }
        }
        

        class Para
        {
            private string[] withoutParachute =
        {
         @"     ",
         @"     ",
         @"     ",
         @"  o  ",
         @" /░\ ",
         @" / \ ",
        };
            private string[] withParachute =
            {
         @" ___ ",
         @"/|||\",
         @"\   /",
         @" \o/ ",
         @"  ░  ",
         @" / \ ",
        };

        }


    }
}

    

