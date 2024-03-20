using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_1
{
    internal class Building
    {
        private string address;
        private double length;
        private double width;
        private double height;

        public Building(double length, double width, double height, string address)
        {
            this.Address = address;
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public string Address {
            get { return address; }
            set 
            { 
                address = value.ToString();
                
            }
        }

        public double Length
        {
            get { return length; }
            set
            {
                length = value;
            }
        }

        public double Width
        {
            get { return width; }
            set
            {
                width = value;
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                height = value;
            }
        }

        public void Print()
        {
            Console.WriteLine("Адрес: {0}.\nВысота: {1}, ширина: {2}, длина: {3}.", Address, Height, Width, Length);
        }
    }

    internal class MultiBuilding:Building
    {
        private int floors { get; set; }

        public MultiBuilding(int floors, double length, double width, double height, string address)
            :base(length, width, height, address)
        {
            this.floors = floors;
        }

        public void Print()
        {
            base.Print();
            Console.WriteLine("Этажность: {0}.", floors);
        }
    }
}
