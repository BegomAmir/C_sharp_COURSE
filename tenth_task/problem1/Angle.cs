using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1
{
    internal class Angle
    {
        int gradus;
        int min;
        int sec;
        public bool isCorrect = true;

        public Angle(int gradus, int min, int sec)
        {
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;
        }
        public int Gradus
        {
            get
            {
                return gradus;
            }
            set
            {
                if (value > 360 || value < 0)
                    isCorrect = false;
                else
                    gradus = value;
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
                if (value > 60 || value < 0)
                    isCorrect = false;
                else
                    min = value / 60;
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
                if (value > 60 || value < 0)
                    isCorrect = false;
                else
                    sec = value / 3600;
            }
        }
        public double ToRadian()
        {
            double radian = (gradus + min + sec) * 3.1415926535 / 180;
            return radian;
        }
    }
}
