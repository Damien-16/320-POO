using Drones.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public partial class Building
    {
        public Building(int _x, int _y) {
            this._y = _y;
            this._x = _x;
        }
        private Pen BuildingBrush = new Pen(new SolidBrush(Color.Red), 3);

        public void Render(BufferedGraphics drawingSpace)
        {

            drawingSpace.Graphics.DrawRectangle(BuildingBrush, new Rectangle(X - 4, Y - 2, 70, 70));
        }



    }

    public class Factory : Building
    {
        private double _consomation;
        public Factory(double cum, string name, int _x, int _y) : base(_x, _y)
        {
            this._consomation = cum;


        }
    }
        public class Store : Building
        {
            private double _consomation;
            public Store(double cum, string name, int _x, int _y) : base(_x, _y)
            {
                this._consomation = cum;


            }

        }
}

