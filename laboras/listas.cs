﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboras
{
    class listas
    {
        private static float GetMedian(int[] mas)
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

        public static void Start()
        {
            string vardas, pavarde;
            int n, egz;
            double final;
            Console.WriteLine("Iveskite studento varda ");
            vardas = Console.ReadLine();
            Console.WriteLine("Iveskite studento pavarde ");
            pavarde = Console.ReadLine();

            Console.WriteLine("Ar zinote savo pazymius? 1=Taip, 2=Ne");
            int a = int.Parse(System.Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("Iveskite egzamino rezultata ");
                    egz = int.Parse(System.Console.ReadLine());
                    Console.WriteLine("1. = Galutinis (vid.) \n2. = Galutinis (med.)");
                    int nse = int.Parse(System.Console.ReadLine());

                    List<int> nd = new List<int>();
                    switch (nse)
                    {
                        case 1:
                            Console.WriteLine("Iveskite namu darbu pazymius (iveskite -1 noredami baigti)");

                            while (true)
                            {
                                int sk = int.Parse(System.Console.ReadLine());
                                if (sk == -1) break;
                                nd.Add(sk);
                            }

                            final = 0.3 * (nd.Sum() / nd.Count) + 0.7 * egz;
                            Console.WriteLine("{0}{1,10}{2,18}", "Vardas", "Pavarde", "Galutinis (vid.)");
                            Console.WriteLine("----------------------------------");
                            Console.WriteLine("{0}{1,10}{2,15}", vardas, pavarde, final);
                            break;
                        case 2:
                            Console.WriteLine("Iveskite namu darbu pazymius (iveskite -1 noredami baigti)");
                            while (true)
                            {
                                int sk = int.Parse(System.Console.ReadLine());
                                if (sk == -1) break;
                                nd.Add(sk);
                            }
                            Console.WriteLine("{0}{1,10}{2,18}", "Vardas", "Pavarde", "Galutinis (med.)");
                            Console.WriteLine("----------------------------------");
                            Console.WriteLine("{0}{1,10}{2,15}", vardas, pavarde, 0.3 * GetMedian(nd.ToArray()) + 0.7 * egz);
                            break;
                    }
                    break;
                case 2:
                    egz = new Random().Next(1, 11);
                    Console.WriteLine("Egzamino rezultatas = " + egz);
                    Console.WriteLine("1. = Galutinis (vid.) \n2. = Galutinis (med.)");
                    int b = int.Parse(System.Console.ReadLine());

                    List<int> ndd = new List<int>();
                    switch (b)
                    {
                        case 1:
                            Console.WriteLine("Iveskite namu darbu skaiciu");
                            n = int.Parse(System.Console.ReadLine());

                            for (int i = 0; i < n; i++)
                            {
                                i = new Random().Next(1, 11);
                                //if (sk == -1) break;
                                ndd.Add(i);
                            }

                            final = 0.3 * (ndd.Sum() / ndd.Count) + 0.7 * egz;
                            Console.WriteLine("{0}{1,10}{2,18}", "Vardas", "Pavarde", "Galutinis (vid.)");
                            Console.WriteLine("----------------------------------");
                            Console.WriteLine("{0}{1,10}{2,15}", vardas, pavarde, final);
                            break;
                        case 2:
                            Console.WriteLine("Iveskite namu darbu skaiciu");
                            n = int.Parse(System.Console.ReadLine());

                            for (int i = 0; i < n; i++)
                            {
                                i = new Random().Next(1, 11);
                                //if (sk == -1) break;
                                ndd.Add(i);
                            }
                            Console.WriteLine("{0}{1,10}{2,18}", "Vardas", "Pavarde", "Galutinis (med.)");
                            Console.WriteLine("----------------------------------");
                            Console.WriteLine("{0}{1,10}{2,15}", vardas, pavarde, 0.3 * GetMedian(ndd.ToArray()) + 0.7 * egz);
                            break;
                    }
                    break;
            }
            
        }
    }
}
