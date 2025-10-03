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
            using (Pen pen = new Pen(Color.Blue, 3))
            using (Font font = new Font("Arial", 10))
            using (Brush brush = new SolidBrush(Color.Black))
            {
                if (!string.IsNullOrEmpty(Name))
                {
                    drawingSpace.Graphics.DrawString(Name, font, brush, X - 4, Y - 20);
                }

                drawingSpace.Graphics.DrawEllipse(pen, new Rectangle(X - 35, Y - 35, 70, 70));
            }
        }
    }


}
