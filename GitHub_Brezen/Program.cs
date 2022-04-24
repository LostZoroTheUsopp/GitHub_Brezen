using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_Brezen
{
    class Program
    {
        static void Main(string[] args)
        {
            float cislo1 = float.Parse(Console.ReadLine());
            float cislo2 = float.Parse(Console.ReadLine());
            Console.Clear();
            if(cislo1 > cislo2)
            {
                Console.WriteLine(cislo1);
                Console.WriteLine(cislo2);
            }
            else
            {
                Console.WriteLine(cislo2);
                Console.WriteLine(cislo1);
            }
            Console.ReadLine();
        }
    }
}
