using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboras
{
    class masyvas
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

        public static void Start2()
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

                    int[] mas = new int[1];
                    //Array.Resize(ref mas, mas.Length + 1);
                    switch (nse)
                    {
                        case 1:
                            Console.WriteLine("Iveskite namu darbu pazymius (iveskite -1 noredami baigti)");
                            while (true)
                            {
                                int sk = int.Parse(Console.ReadLine());
                                if (sk == -1) break;
                                if (mas.Length != 1)
                                {   
                                    Array.Resize(ref mas, mas.Length + 1);
                                }
                                
                                mas[mas.Length-1] = int.Parse(Console.ReadLine());

                                
                            }
                            int suma = 0;
                            for (int i = 0; i < mas.Length; i++)
                            {
                                suma += mas[i];
                            }

                            final = 0.3 * ((suma) / (mas.Length)) + 0.7 * egz;
                            Console.WriteLine("{0}{1,10}{2,18}", "Vardas", "Pavarde", "Galutinis (vid.)");
                            Console.WriteLine("----------------------------------");
                            Console.WriteLine("{0}{1,10}{2,20}", vardas, pavarde, final);
                            break;
                        case 2:
                            Console.WriteLine("Iveskite namu darbu pazymius (iveskite -1 noredami baigti)");
                            while (true)
                            {
                                int sk = int.Parse(Console.ReadLine());
                                if (sk == -1) break;
                                if (mas.Length != 1)
                                {
                                    Array.Resize(ref mas, mas.Length + 1);
                                }

                                mas[mas.Length - 1] = int.Parse(Console.ReadLine());
                            }
                            
                            Console.WriteLine("{0}{1,10}{2,18}", "Vardas", "Pavarde", "Galutinis (med.)");
                            Console.WriteLine("----------------------------------");
                            Console.WriteLine("{0}{1,10}{2,20}", vardas, pavarde, 0.3 * GetMedian(mas) + 0.7 * egz);
                            break;
                    }
                    break;
                case 2:
                    egz = new Random().Next(1, 11);
                    Console.WriteLine("Egzamino rezultatas = " + egz); 
                    Console.WriteLine("1. = Galutinis (vid.) \n2. = Galutinis (med.)");
                    int b = int.Parse(System.Console.ReadLine());

                    int[] mas1 = new int[1];
                    switch (b)
                    {
                        case 1:
                            Console.WriteLine("Iveskite namu darbu skaiciu");
                            n = int.Parse(System.Console.ReadLine());
                            
                                for (int i = 0; i < n; i++)
                                {
                                    mas1[i] = new Random().Next(1, 11);
                                    Array.Resize(ref mas1, mas1.Length + 1);
                                }
                             
                            int suma = 0;
                            for (int i = 0; i < mas1.Length; i++)
                            {
                                suma += mas1[i];
                            }

                            final = 0.3 * ((suma + 1) / (mas1.Length - 2)) + 0.7 * egz;
                            Console.WriteLine("{0}{1,10}{2,18}", "Vardas", "Pavarde", "Galutinis (vid.)");
                            Console.WriteLine("----------------------------------");
                            Console.WriteLine("{0}{1,10}{2,20}", vardas, pavarde, final);
                            break;
                        case 2:
                            Console.WriteLine("Iveskite namu darbu skaiciu");
                            n = int.Parse(System.Console.ReadLine());
                            
                                for (int i = 0; i < n; i++)
                                {
                                    mas1[i] = new Random().Next(1, 11);
                                    Array.Resize(ref mas1, mas1.Length + 1);
                                }
                             
                            mas1 = mas1.Where(val => val != -1 && val != 0).ToArray();
                            Console.WriteLine("{0}{1,10}{2,18}", "Vardas", "Pavarde", "Galutinis (med.)");
                            Console.WriteLine("----------------------------------");
                            Console.WriteLine("{0}{1,10}{2,20}", vardas, pavarde, 0.3 * GetMedian(mas1) + 0.7 * egz);
                            break;
                    }
                    break;
            }

           
        }
    }
}
