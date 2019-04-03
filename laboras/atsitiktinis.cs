using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace laboras
{
    class atsitiktinis
    {
        public static void Failai()
        {
            for(int i=0; i < 5; i++)
            {
                Stopwatch watch = new Stopwatch();
                watch.Start();
                List<Studentas> studentai = new List<Studentas>();
                Random r = new Random();
                for (int j = 0; j < Math.Pow(10, i+1); j++)
                {
                    Studentas s = new Studentas();
                    s.vardas = "vardas" + j;
                    s.pavarde = "pavarde" + j;
                    s.Egzaminas = r.Next(0, 11);

                    for(int h = 0; h < 5; h++)
                    {
                        s.NamuDarbai.Add(r.Next(0, 11));
                    }

                    studentai.Add(s);
                }
                StreamWriter writer = new StreamWriter(Math.Pow(10, i + 1) + ".txt");
                foreach (Studentas s in studentai)
                {
                    writer.WriteLine(s.vardas + " " + s.pavarde + " " + s.NamuDarbai[0] + " " + s.NamuDarbai[1] + " " + s.NamuDarbai[2] + " " + s.NamuDarbai[3] + " " + s.NamuDarbai[4] + " " + s.Egzaminas);
                }
                writer.Close();

                List<Studentas> vargsiukai = new List<Studentas>();
                List<Studentas> galvociai = new List<Studentas>();
                foreach (Studentas s in studentai)
                {
                    if(s.BendrasVid() < 5)
                    {
                        vargsiukai.Add(s);
                    }
                    else
                    {
                        galvociai.Add(s);
                    }
                }
                StreamWriter writer1 = new StreamWriter(Math.Pow(10, i + 1) + "vargsiukai.txt");
                foreach (Studentas s in vargsiukai)
                {
                    writer1.WriteLine(s.vardas + " " + s.pavarde + " " + s.NamuDarbai[0] + " " + s.NamuDarbai[1] + " " + s.NamuDarbai[2] + " " + s.NamuDarbai[3] + " " + s.NamuDarbai[4] + " " + s.Egzaminas);
                }
                writer1.Close();

                StreamWriter writer2 = new StreamWriter(Math.Pow(10, i + 1) + "galvociai.txt");
                foreach (Studentas s in galvociai)
                {
                    writer2.WriteLine(s.vardas + " " + s.pavarde + " " + s.NamuDarbai[0] + " " + s.NamuDarbai[1] + " " + s.NamuDarbai[2] + " " + s.NamuDarbai[3] + " " + s.NamuDarbai[4] + " " + s.Egzaminas);
                }
                writer2.Close();
                watch.Stop();
                Console.WriteLine("Programa uztruko: " + watch.ElapsedMilliseconds + "ms su " + Math.Pow(10, i + 1) + " irasu");
            }
        }
    }
}
   
