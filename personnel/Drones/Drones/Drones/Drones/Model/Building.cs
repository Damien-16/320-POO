using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        public Building(int x, int y)
        {
            this._x = x;
            this._y = y;
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }

        }
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
