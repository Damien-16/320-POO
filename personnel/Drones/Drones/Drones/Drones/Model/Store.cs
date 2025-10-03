using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    public class Store : Building
    {
        private double _consomation;
        protected int x;
        protected int y;
        string name;
        public Store(double cum, string name, int _x, int _y) : base(_x, _y)
        {
            this._consomation = cum;
            this.name = name;
            this.x = _x;
            this.y = _y;
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
