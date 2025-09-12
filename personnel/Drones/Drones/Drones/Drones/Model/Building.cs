using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    public partial class Building
    {
        Random r = new Random();

        private int _x;
        private int _y;
        private int height = 30;
        private int deep = 40;
        private string color;

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
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }




    }
}
