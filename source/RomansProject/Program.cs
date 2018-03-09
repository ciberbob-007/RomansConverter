using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomansProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Romans romans = new Romans();

            /*while (true) {
                int input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(input + " = " + romans.Convert(input));
            }*/

            

            while (true) {
                string input = Console.ReadLine();
                Console.WriteLine(Romans.Convert(input));
            }
            
        }
    }
}
