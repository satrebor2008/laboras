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
            Console.WriteLine("1. = Su listu \n2. = Su masyvu");
            int n = int.Parse(System.Console.ReadLine());
            switch (n)
            {
                case 1:
                    listas.Start();
                    break;
                case 2:
                    masyvas.Start2();
                    break;
            }
            
        }
    }
}
