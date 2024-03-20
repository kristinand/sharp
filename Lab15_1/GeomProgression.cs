using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_1
{
    internal class GeomProgression : ISeries
    {
        private int n = 0;
        private int b1;
        private int q { get; set; }

        public GeomProgression(int q)
        {
            this.q = q;
        }

        public int GetNext()
        {
            n += 1;
            return b1*(int)Math.Pow(q, n-1);
        }

        public void Reset()
        {
            n = 0;

        }

        public void SetStart(int x)
        {
            b1 = x;
        }
    }
}
