using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public class Factory : Building
    {
        public double PowerConsumption { get; set; } // kWh par jour

        public Factory(double powerConsumption, string name, int x, int y) : base(x, y)
        {
            this.PowerConsumption = powerConsumption;
            this.Name = name;
        }

        public override void Render(BufferedGraphics drawingSpace)
        {
            using (Font font = new Font("Arial", 10))
            using (Brush brush = new SolidBrush(Color.Black))
            {
                if (!string.IsNullOrEmpty(Name))
                {
                    drawingSpace.Graphics.DrawString(Name, font, brush, X - 4, Y - 20);
                }

                drawingSpace.Graphics.DrawRectangle(BuildingBrush, new Rectangle(X - 4, Y - 2, 70, 70));
            }
        }
    }


}

