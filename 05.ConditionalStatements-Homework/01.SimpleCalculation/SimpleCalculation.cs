using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class SimpleCalculation
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("1");
            }

            if (x > 0 && y < 0)
            {
                Console.WriteLine("4");
            }

            if (x < 0 && y < 0)
            {
                Console.WriteLine("3");
            }

            if (x < 0 && y > 0)
            {
                Console.WriteLine("2");
            }

            if (x == 0 && y == 0)
            {
                Console.WriteLine("0");
            } 
            else if (x == 0 || y == 0)
            {
                Console.WriteLine("6");
            }

            

        }
    }
