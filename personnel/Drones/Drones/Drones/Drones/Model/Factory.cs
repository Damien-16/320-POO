using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public class Factory : Building
    {
        public double PowerConsumption { get; set; } // kWh/jour

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
                // Nom au-dessus
                if (!string.IsNullOrEmpty(Name))
                {
                    drawingSpace.Graphics.DrawString(Name, font, brush, X , Y - 30);
                }

                // PowerConsumption juste en dessous du nom
                drawingSpace.Graphics.DrawString($"{PowerConsumption} kWh/jour", font, brush, X , Y - 15);

                // Rectangle représentant l'usine
                drawingSpace.Graphics.DrawRectangle(BuildingBrush, new Rectangle(X , Y, 70, 70));
            }
        }

    }


}

