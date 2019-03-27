using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboras
{
    class Skaiciavimai
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
    }
}
