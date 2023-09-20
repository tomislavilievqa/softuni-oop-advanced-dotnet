using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class StartUp
    {
        public static void Main(string[] args)
        {

            var radius = int.Parse(Console.ReadLine());
            IDrawable circle = new Circle(radius);


            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            IDrawable rectangle = new Rectangle(width, height);

            circle.Draw();
            rectangle.Draw();


        }
    }
}
