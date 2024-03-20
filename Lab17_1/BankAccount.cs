using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17_1
{
    internal class BankAccount<T>
    {
        private T num;
        private double balance;
        private string name;

        public T Num {
            get { return num; }
            set { num = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
