using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w3VezbaFor02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());

            int rez = 0;

            for (int i = 1; i <= input; i++)
            {
                rez += i;

                Console.WriteLine(rez);
            }

            Console.WriteLine(rez);

        }
    }
}
