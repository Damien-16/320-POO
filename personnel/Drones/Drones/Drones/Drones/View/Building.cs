using Drones.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Drones
{
    public partial class Building
    {
        protected Pen BuildingBrush = new Pen(new SolidBrush(Color.Red), 3);

        public virtual void Render(BufferedGraphics drawingSpace)
        {
            using (Font font = new Font("Arial", 10))
            using (Brush brush = new SolidBrush(Color.Black))
            {
                if (!string.IsNullOrEmpty(Name))
                {
                    drawingSpace.Graphics.DrawString(Name, font, brush, X - 4, Y - 20);
                }
            }

            drawingSpace.Graphics.DrawRectangle(BuildingBrush, new Rectangle(X - 4, Y - 2, 70, 70));
        }
    }



}

