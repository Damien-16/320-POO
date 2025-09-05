using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachutiste
{
    class Plane
    {
        public List<Para> parachutists;
        private string[] view =
  {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };
        private int _x = 0;
        private int _y = 1;
        public void draw()
        {
            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(_x,i);
                Console.WriteLine(view[i]);
            }

        }
        public void update()
        {
            _x++;
        }
        public Plane()
        {
            _x = 0;
            _y = Config.SCREEN_HEIGHT;
            parachutists = new List<Para>();
        }
        public void board(Para para)
        {
            this.parachutists.Add(para);
        }
        internal Para dropParachutist()
        {
            Para parachutist = parachutists.First();
            parachutists.Remove(parachutist);
            parachutist.x = _x;
            parachutist.y = this._y;
            return parachutist;
        }
    }

}
