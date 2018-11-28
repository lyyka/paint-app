﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicObjects
{
    public class Ellipse : GObject
    {
        public int xPos { get; set; }
        public int yPos { get; set; }
        public int xSize { get; set; }
        public int ySize { get; set; }

        public Ellipse(int x_pos, int y_pos, int x_size, int y_size, Color pen_color, float pen_width)
            :base(pen_color, pen_width)
        {
            this.xPos = x_pos;
            this.yPos = y_pos;
            this.xSize = x_size;
            this.ySize = y_size;
        }

        public override void Draw(Graphics g)
        {
            Pen temp_pen = new Pen(penColor, penWidth);
            g.DrawEllipse(temp_pen, xPos, yPos, xSize, ySize);
        }
    }
}
