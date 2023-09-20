using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rectangle : IDrawable
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }
        public void Draw()
        {
            Console.WriteLine(new string('*', Width));
            for (int row = 0; row < Height - 2; row++)
            {
                Console.WriteLine("*" + new string(' ', this.Width - 2) + "*");

            }
            Console.WriteLine(new string('*', Width));
        }


    }
}
