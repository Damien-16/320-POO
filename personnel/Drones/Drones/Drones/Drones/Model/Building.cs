using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Building
    {
        Random r = new Random();

        protected int _x;
        protected int _y;
        protected const int height = 100;
        protected const int deep = 100;
        protected string _color;
        protected string _name ;

        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }

        }
        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }

        }

      
    }
}
