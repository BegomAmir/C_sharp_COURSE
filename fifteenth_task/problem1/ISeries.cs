using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1
{
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void Reset();

    }
    class ArithProgression : ISeries
    {
        public int Step { get; set; }
        public int CurrentValue { get; set; }
        public int StartValue { get; set; }

        public int getNext()
        {
            CurrentValue += Step;
            return CurrentValue;
        }

        public void Reset()
        {
            CurrentValue = StartValue;
        }

        public void setStart(int x)
        {
            StartValue = x;
            CurrentValue = StartValue;

        }
        public void setStep(int s)
        {
            Step = s;
        }
    }
    class GeomProgression : ISeries
    {
        public int Step { get; set; }
        public int CurrentValue { get; set; }
        public int StartValue { get; set; }
        public int getNext()
        {
            CurrentValue *= Step;
            return CurrentValue;
        }

        public void Reset()
        {
            CurrentValue = StartValue;
        }

        public void setStart(int x)
        {
            StartValue = x;
            CurrentValue = StartValue;
        }
        public void setStep(int s)
        {
            Step = s;
        }
    }
}
