using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboras
{
    class Konteineriai
    {
        public static void Failai()
        {
            {
                Stopwatch watch = new Stopwatch();
                watch.Start();
                List<Studentas> studentai = new List<Studentas>();
                string line;

                try
                {
                    StreamReader file = new StreamReader("100000.txt");
                    while ((line = file.ReadLine()) != null)
                    {
                        string[] args = line.Split(' ');

                        if (args.Length != 8) continue;
                        Studentas stud = new Studentas();
                        stud.vardas = args[0];
                        stud.pavarde = args[1];
                        for (int i = 0; i < 5; i++)
                        {
                            try
                            {
                                stud.NamuDarbai.Add(int.Parse(args[2 + i]));
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Neisejo nuskaityti namu darbo pazymio [" + args[2 + i] + "]");
                            }
                        };
                        try
                        {
                            stud.Egzaminas = (int.Parse(args[7]));
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Neisejo nuskaityti egzamino pazymio [" + args[7] + "]");
                        }
                        studentai.Add(stud);
                    }

                    file.Close();

                }
                catch (Exception e)
                {
                    Console.WriteLine("Ivyko klaida skaitant faila:");
                    Console.WriteLine(e.Message);
                }

                List<Studentas> vargsiukai = new List<Studentas>();
                List<Studentas> galvociai = new List<Studentas>();
                foreach (Studentas s in studentai)
                {
                    if (s.BendrasVid() < 5)
                    {
                        vargsiukai.Add(s);
                    }
                    else
                    {
                        galvociai.Add(s);
                    }
                }
                watch.Stop();
                Console.WriteLine("Programa uztruko: " + watch.ElapsedMilliseconds + "ms su listu ");
            }

            {
                Stopwatch watch = new Stopwatch();
                watch.Start();
                Queue<Studentas> studentai = new Queue<Studentas>();
                string line;

                try
                {
                    StreamReader file = new StreamReader("100000.txt");
                    while ((line = file.ReadLine()) != null)
                    {
                        string[] args = line.Split(' ');

                        if (args.Length != 8) continue;
                        Studentas stud = new Studentas();
                        stud.vardas = args[0];
                        stud.pavarde = args[1];
                        for (int i = 0; i < 5; i++)
                        {
                            try
                            {
                                stud.NamuDarbai.Add(int.Parse(args[2 + i]));
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Neisejo nuskaityti namu darbo pazymio [" + args[2 + i] + "]");
                            }
                        };
                        try
                        {
                            stud.Egzaminas = (int.Parse(args[7]));
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Neisejo nuskaityti egzamino pazymio [" + args[7] + "]");
                        }
                        studentai.Enqueue(stud);
                    }

                    file.Close();

                }
                catch (Exception e)
                {
                    Console.WriteLine("Ivyko klaida skaitant faila:");
                    Console.WriteLine(e.Message);
                }

                Queue<Studentas> vargsiukai = new Queue<Studentas>();
                Queue<Studentas> galvociai = new Queue<Studentas>();
                foreach (Studentas s in studentai)
                {
                    if (s.BendrasVid() < 5)
                    {
                        vargsiukai.Enqueue(s);
                    }
                    else
                    {
                        galvociai.Enqueue(s);
                    }
                }
                watch.Stop();
                Console.WriteLine("Programa uztruko: " + watch.ElapsedMilliseconds + "ms su queue ");
            }
            {
                Stopwatch watch = new Stopwatch();
                watch.Start();
                LinkedList<Studentas> studentai = new LinkedList<Studentas>();
                string line;

                try
                {
                    StreamReader file = new StreamReader("100000.txt");
                    while ((line = file.ReadLine()) != null)
                    {
                        string[] args = line.Split(' ');

                        if (args.Length != 8) continue;
                        Studentas stud = new Studentas();
                        stud.vardas = args[0];
                        stud.pavarde = args[1];
                        for (int i = 0; i < 5; i++)
                        {
                            try
                            {
                                stud.NamuDarbai.Add(int.Parse(args[2 + i]));
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Neisejo nuskaityti namu darbo pazymio [" + args[2 + i] + "]");
                            }
                        };
                        try
                        {
                            stud.Egzaminas = (int.Parse(args[7]));
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Neisejo nuskaityti egzamino pazymio [" + args[7] + "]");
                        }
                        studentai.AddLast(stud);
                    }

                    file.Close();

                }
                catch (Exception e)
                {
                    Console.WriteLine("Ivyko klaida skaitant faila:");
                    Console.WriteLine(e.Message);
                }

                LinkedList<Studentas> vargsiukai = new LinkedList<Studentas>();
                LinkedList<Studentas> galvociai = new LinkedList<Studentas>();
                foreach (Studentas s in studentai)
                {
                    if (s.BendrasVid() < 5)
                    {
                        vargsiukai.AddLast(s);
                    }
                    else
                    {
                        galvociai.AddLast(s);
                    }
                }
                watch.Stop();
                Console.WriteLine("Programa uztruko: " + watch.ElapsedMilliseconds + "ms su linkedlistu");
            }
        }
    }
}
