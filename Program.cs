using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_do_beecrowd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s;
            double imp = 0;
            s = double.Parse(Console.ReadLine());
            if (s >= 0 && s <= 2000)
            {
                Console.WriteLine("Isento");
            }
            else if (s > 2000 && s <= 3000)
            {
                imp = (s - 2000) * 8 / 100;
                Console.WriteLine("R$ " + string.Format("{0:F2}", imp));
            }
            else if (s > 3000 && s <= 4500)
            {
                imp = (1000 * 8 / 100) + ((s - 3000) * 18/100);
                Console.WriteLine("R$ " + string.Format("{0:F2}", imp));
            }
            else
            {
                imp = (1000 * 8 / 100) + (1500 * 18 / 100) + ((s - 4500) * 28 / 100);
                Console.WriteLine("R$ " + string.Format("{0:F2}", imp));
            }
        }
    }
}