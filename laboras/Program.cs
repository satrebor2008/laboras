using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboras
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("1. = Su ivedimu per konsole \n2. = Su nuskaitymu is failo");
            int n = int.Parse(System.Console.ReadLine());
            switch (n)
            {
                case 1:
                    listas.Start();
                    break;
                case 2:
                    skaitymas.Start3();
                    break;
            }
            
        }
    }
}
