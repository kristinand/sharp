using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15_1
{
    internal class ArithProgression : ISeries
    {
        private int n = 0;
        private int a1;
        private int d { get; set; }

        public ArithProgression(int d)
        {
            this.d = d;
        }

        public int GetNext()
        {
            n += 1;
            return a1 + (n - 1) * d;
        }

        public void Reset()
        {
            n = 0;

        }

        public void SetStart(int x)
        {
            a1 = x;
        }
    }
}
