﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    class Boss
    {
        private int x;
        private int y;
        private int width;
        private int height;
        private Rectangle rectangle;

        public Boss(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.width = 40;
            this.height = 35;
            Rectangle rec = new Rectangle(x, y, 40, 35);
            this.rectangle = rec;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
        public Rectangle Rectangle { get => rectangle; set => rectangle = value; }
    }
}
