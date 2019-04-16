using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboras
{
    class optimizavimas
    {
        public static void Failai()
        {
            
                List<Studentas> failas = new List<Studentas>();
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
                        failas.Add(stud);
                    }

                    file.Close();

                }
                catch (Exception e)
                {
                    Console.WriteLine("Ivyko klaida skaitant faila:");
                    Console.WriteLine(e.Message);
                }
            {
                Stopwatch watch = new Stopwatch();
                watch.Start();
                List<Studentas> vargsiukai = new List<Studentas>();
                List<Studentas> galvociai = new List<Studentas>();
                foreach (Studentas s in failas)
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
                Console.WriteLine("Programa uztruko: " + watch.ElapsedMilliseconds + "ms su list (Strategija 1)");
            }

            {
                List<Studentas> galvociai = new List<Studentas>(failas);
                Stopwatch watch = new Stopwatch();
                watch.Start();
                List<Studentas> vargsiukai = new List<Studentas>();
                for (int i = galvociai.Count-1; i>=0; i--)
                {
                    if (galvociai[i].BendrasVid() < 5)
                    {
                        vargsiukai.Add(galvociai[i]);
                        galvociai.RemoveAt(i);
                    } 
                }
                watch.Stop();
                Console.WriteLine("Programa uztruko: " + watch.ElapsedMilliseconds + "ms su list (Strategija 2)");
            }

            {
                List<Studentas> galvociai = new List<Studentas>(failas);
                Stopwatch watch = new Stopwatch();
                watch.Start();
                galvociai.Sort((Studentas o, Studentas t)=> o.BendrasVid().CompareTo(t.BendrasVid()));
                List<Studentas> vargsiukai = new List<Studentas>();
                int riba = 0;
                foreach (Studentas s in galvociai)
                {
                    if (s.BendrasVid() >= 5)
                        break;
                    else
                    {
                        vargsiukai.Add(s);
                    }
                    riba++;
                }
                galvociai.RemoveRange(0, riba);
                watch.Stop();
                Console.WriteLine("Programa uztruko: " + watch.ElapsedMilliseconds + "ms su list (Strategija 2) optimizuota");
            }

            {
                Stopwatch watch = new Stopwatch();
                watch.Start();
                Queue<Studentas> vargsiukai = new Queue<Studentas>();
                Queue<Studentas> galvociai = new Queue<Studentas>();
                foreach (Studentas s in failas)
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
                Console.WriteLine("Programa uztruko: " + watch.ElapsedMilliseconds + "ms su queue (Strategija 1)");
            }

            {
                Queue<Studentas> studentai = new Queue<Studentas>(failas);
                Stopwatch watch = new Stopwatch();
                watch.Start();
                Queue<Studentas> galvociai = new Queue<Studentas>(failas);
                Queue<Studentas> vargsiukai = new Queue<Studentas>();
                while (studentai.Count!=0)
                {
                    Studentas s = studentai.Dequeue();
                    if (s.BendrasVid() < 5)
                    {
                        vargsiukai.Enqueue(s);
                    }else
                    {
                        galvociai.Enqueue(s);
                    }
                }
                watch.Stop();
                Console.WriteLine("Programa uztruko: " + watch.ElapsedMilliseconds + "ms su queuqe (Strategija 2)");
            }

            {
                Stopwatch watch = new Stopwatch();
                watch.Start();
                LinkedList<Studentas> vargsiukai = new LinkedList<Studentas>();
                LinkedList<Studentas> galvociai = new LinkedList<Studentas>();
                foreach (Studentas s in failas)
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
                Console.WriteLine("Programa uztruko: " + watch.ElapsedMilliseconds + "ms su linkedlist (Strategija 1)");
            }

            {
                LinkedList<Studentas> galvociai = new LinkedList<Studentas>(failas);
                Stopwatch watch = new Stopwatch();
                watch.Start();
                LinkedList<Studentas> vargsiukai = new LinkedList<Studentas>();
                for (int i = galvociai.Count - 1; i >= 0; i--)
                {
                    if (galvociai.ElementAt(i).BendrasVid() < 5)
                    {
                        vargsiukai.AddLast(galvociai.ElementAt(i));
                        galvociai.Remove(galvociai.ElementAt(i));
                    }
                }
                watch.Stop();
                Console.WriteLine("Programa uztruko: " + watch.ElapsedMilliseconds + "ms su linkedlist (Strategija 2)");
            }

        }
    }
}
