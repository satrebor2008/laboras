using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboras
{
    class skaitymas
    {
        

        public static void Start3()
        {

            List<Studentas> studentai = new List<Studentas>();

            string line;
           
                StreamReader file = new StreamReader("kursiokai.txt");
                while ((line = file.ReadLine()) != null)
                {
                    string[] args = line.Split(' ');

                    if (args.Length != 8) continue;
                    Studentas stud = new Studentas();
                    stud.vardas = args[0];
                    stud.pavarde = args[1];
                    for (int i=0; i<5; i++)
                    {

                        stud.NamuDarbai.Add(int.Parse(args[2 + i]));
                       
                    }
                stud.Egzaminas = int.Parse(args[7]);


                    studentai.Add(stud);
                }

                file.Close();


            studentai.Sort((x,y) => x.vardas.CompareTo(y.vardas));
            Console.WriteLine("{0, -15}{1, -15}{2, -25}{3, -25} ", "Vardas", "Pavarde", "Galutinis (vid.)", "Galutinis (med.)");
            Console.WriteLine("-----------------------------------------------------------------------");

            foreach (Studentas s in studentai)
            {
                Console.WriteLine("{0, -15}{1, -15}{2, -25}{3, -25}", s.vardas, s.pavarde, s.BendrasVid(), s.BendrasMed());
            }

        }
    }
}

