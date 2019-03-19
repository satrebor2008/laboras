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
            string vardas, pavarde;
            int n, nd, egz;
            double final;
            Console.WriteLine("Iveskite studento varda ");
            vardas = Console.ReadLine();
            Console.WriteLine("Iveskite studento pavarde ");
            pavarde = Console.ReadLine();
            Console.WriteLine("Iveskite egzamino rezultata ");
            egz = int.Parse(System.Console.ReadLine());
            Console.WriteLine("Iveskite namu darbu skaiciu ");
            n = int.Parse(System.Console.ReadLine());
            Console.WriteLine("Iveskite namu darbu pazymius ");
            float suma = 0;
            for (int i = 0; i < n; i++)
            {
                suma += float.Parse(System.Console.ReadLine());
            }
            final = 0.3 * (suma / n) + 0.7 * egz;
            Console.WriteLine("{0}{1,10}{2,18}", "Vardas", "Pavarde", "Galutinis (vid.)");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("{0}{1,10}{2,15}", vardas, pavarde, final);
        }
    }
}
