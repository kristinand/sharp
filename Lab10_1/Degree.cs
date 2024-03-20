using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_1
{
    internal class Degree
    {
        private int gradus;
        private int min;
        private int sec;

        public Degree(int gradus, int min=0, int sec=0)
        {
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;
        }

        public int Gradus
        {
            get {
                return gradus;
            }

            set
            {
                if (value < 0)
                {
                    gradus = 0;
                }
                else
                {
                    gradus = value % 360;
                }
            }
        }

        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                if (value < 0)
                {
                    min = 0;
                }
                else if (value >= 60)
                {
                    Gradus += value / 60;
                    min = value % 60;
                } else
                {
                    min = value;
                }
                
            }
        }

        public int Sec
        {
            get
            {
                return sec;
            }
            set
            {
                if (value < 0)
                {
                    sec = 0;
                }
                else if (value >= 60)
                {
                    Min += value / 60;
                    sec = value % 60;
                }
                else
                {
                    sec = value;
                }

            }
        }

        public double ToRad()
        {
            return gradus * Math.PI / 180 + min * Math.PI / (180 * 60) + sec * Math.PI / (180 * 60 * 60);
        }
    }
}
