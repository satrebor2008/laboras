using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboras
{
    class Program
    {
        public static float GetMedian(int[] mas)
        {
            Array.Sort(mas);
            int count = mas.Length;
            if (count == 0)
            {
                throw new InvalidOperationException("Empty collection");
            }
            else if (count % 2 == 0)
            {
                float a = mas[count / 2 - 1];
                float b = mas[count / 2];
                return (a + b) / 2;
            }
            else
            {
                return mas[count / 2];
            }
        }

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
            Console.WriteLine("1. = Galutinis (vid.) \n2. = Galutinis (med.)");
            int nse = int.Parse(System.Console.ReadLine());

            switch (nse)
            {
                case 1:
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
                    break;
                case 2:
                    Console.WriteLine("Iveskite namu darbu pazymius ");
                    int[] mas = new int[n];
                    for (int i = 0; i < mas.Length; i++)
                    {
                        mas[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("{0}{1,10}{2,18}", "Vardas", "Pavarde", "Galutinis (med.)");
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine("{0}{1,10}{2,15}", vardas, pavarde, 0.3 * GetMedian(mas) + 0.7 * egz);
                    break;
            }
        }
    }
}
