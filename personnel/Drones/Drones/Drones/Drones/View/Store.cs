using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public class Store : Building
    {
        public List<string> OpeningHours { get; set; }

        public Store(string name, int x, int y, List<string> openingHours) : base(x, y)
        {
            this.Name = name;
            this.OpeningHours = openingHours;
        }

        public override void Render(BufferedGraphics drawingSpace)
        {
            using (Pen pen = new Pen(Color.Blue, 10))
            using (Font font = new Font("Arial", 10))
            using (Brush brush = new SolidBrush(Color.Black))
            {
                int yOffset = -20; // position initiale au-dessus du cercle

               
                    drawingSpace.Graphics.DrawString(Name, font, brush, X - 4, Y + yOffset);
                    yOffset -= 15;
                

               
                    foreach (string day in OpeningHours)
                    {
                        drawingSpace.Graphics.DrawString(day, font, brush, X - 4, Y + yOffset);
                        yOffset -= 15;
                    }
                

                // Cercle représentant le magasin
                drawingSpace.Graphics.DrawEllipse(pen, new Rectangle(X , Y , 70, 70));
            }
        }

    }


}
