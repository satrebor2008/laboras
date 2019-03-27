using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboras
{
    class Studentas
    {
        public string vardas;
        public string pavarde;
        public int Egzaminas;
        public List<int> NamuDarbai = new List<int>();

        public float BendrasVid()
        {
            return 0.3f * (NamuDarbai.Sum() / NamuDarbai.Count) + 0.7f * Egzaminas;
        }

        public float BendrasMed()
        {
            return 0.3f * Skaiciavimai.GetMedian(NamuDarbai.ToArray()) + 0.7f * Egzaminas;
        }

    }
}
