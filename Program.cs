using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chechk_the_numbre_even_or_not_even
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the numbre");
            byte x = Convert.ToByte(Console.ReadLine());
            byte n = (byte)(x << 7);
            if (n == 0)
            {
                Console.WriteLine("The numbre is even");
            }
            else
            {
                Console.WriteLine("The numbre is not even");
            }


            Console.ReadKey();
        }
    }
}
