using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Exercise1
    {

        public static double[] calculateQuadraticEq(double a, double b, double c)
        {
            double delta, x0, x1, x2;
            double[] results;

            delta = b * b - (4 * a * c);
            if (delta < 0)
            {
                results = null;

                Console.WriteLine("Rownanie nie ma rozwiazania");

                return results;
            }
            if (delta == 0)
            {
                x0 = -b / (2 * a);
                results = new double[1];
                results[0] = x0;

                Console.WriteLine("Rownanie ma jendo rozwiazanie ");
                Console.WriteLine("X0 = " + x0);

                return results;
            }
            delta = Math.Sqrt(delta);
            if (b > 0)
            {
                x1 = (-b - delta) / (2 * a);
                x2 = c / (a * x1);
            }
            else
            {
                x2 = (-b + delta) / (2 * a);
                x1 = c / (a * x2);
            }
            results = new double[2];
            results[0] = Math.Truncate(x1 * 100) / 100;
            results[1] = Math.Truncate(x2 * 100) / 100;

            Console.WriteLine("Rowanie ma dwa rozwiazania: ");
            Console.WriteLine("X1 = " + x1 + "\nX2 = " + x2);           

            return results;
        }
    }


    public class Exercise2
    {
        public static void randomNumber()
        {
            Random rand = new Random();
            List<int> randomList = new List<int>();

            for(int i=0; i<10000000; i++)
            {
                randomList.Add(rand.Next());
            }

            randomList.Sort();
        }
    }
    
}
