using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Box_Data
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Heigth = height;

        }

        private double Length
        {
            get
            {
                return length;
            }

            set
            {
                if (value < 0)
                {
                    throw new Exception("Length cannot be zero or negative.");
                }

                this.length = value;
            }
        }

        private double Width
        {
            get
            {
                return width;
            }

            set
            {
                if (value < 0)
                {
                    throw new Exception("Width cannot be zero or negative.");
                }

                width = value;
            }
        }
        private double Heigth
        {
            get
            {
                return height;
            }

            set
            {
                if (value < 0)
                {
                    throw new Exception("Heigth cannot be zero or negative.");

                }

                height = value;
            }
        }

        public void CalculateSurfaceArea()
        {
            //Surface Area = 2(LW + LH + WH)

            //Here's how to plug in your values:

            //L = 2
            //W = 3
            //H = 4

            //Surface Area = 2(23 + 24 + 3 * 4)
            //Surface Area = 2(6 + 8 + 12)
            //Surface Area = 2(26)
            //Surface Area = 52 square units
            double surfaceArea = 2 * ((this.Length * this.Width) + (this.Length * this.Heigth) + (this.Width * this.Heigth));
            Console.WriteLine($"Surface Area - {surfaceArea:F2}");

        }
        public void CalculateLateralSurfaceArea()
        {
            //Lateral Surface Area(LSA):
            //L = 2
            //W = 3
            //H = 4

            //LSA = 2 * (length * height + width * height)
            //LSA = 2 * (2 * 4 + 3 * 4)
            //LSA = 2 * (8 + 12)
            //LSA = 2 * 20
            //LSA = 40 square units
            double lateralSurfaceArea = 2 * ((this.Length * this.Heigth) + (this.Width * this.Heigth));
            Console.WriteLine($"Surface Area - {lateralSurfaceArea:F2}");

        }

        public void CalculateVolume()
        {
            //L = 2
            //W = 3
            //H = 4

            //Volume:
            //Volume = length * width * height
            //Volume = 6 * 4 * 3
            //Volume = 72 cubic units

            double volume = this.Length * this.Heigth * this.Width;
            Console.WriteLine($"Surface Area - {volume:F2}");
        }

    }
}
