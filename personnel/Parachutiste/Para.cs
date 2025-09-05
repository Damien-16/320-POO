using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachutiste
{
    class Para
    {
        private const int PARA_HEIGHT = 6;

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

        public int x;
        public int y;
        public bool parachuteIsOpen;

        internal void update()
        {
            if (y > PARA_HEIGHT)
            {
                if (parachuteIsOpen)
                {
                    y -= 1;
                }
                else
                {
                    y -= 3;
                }

                if (y < Config.SCREEN_HEIGHT / 2)
                {
                    parachuteIsOpen = true;
                }
            }
            else
            {
                parachuteIsOpen = false;
            }

        }
        public void draw()
        {
            string[] view = parachuteIsOpen ? withParachute : withoutParachute;
            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(x, Config.SCREEN_HEIGHT - this.y + i);
                Console.Write(view[i]);
            }
            
        }

    }
}


