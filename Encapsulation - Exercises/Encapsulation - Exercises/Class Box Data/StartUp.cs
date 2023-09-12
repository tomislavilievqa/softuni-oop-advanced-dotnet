using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Box_Data
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            double[] input = new double[3];
                      
            for (int i = 0; i < input.Length; i++)
            {
                double currNum = double.Parse(Console.ReadLine());
                input[i] = currNum;
                
            }

            Box box = new Box(input[0], input[1], input[2]);

            box.CalculateSurfaceArea();
            box.CalculateLateralSurfaceArea();
            box.CalculateVolume();
        }
    }
}
