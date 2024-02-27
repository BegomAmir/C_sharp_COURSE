using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1
{
    sealed internal class MultiBuilding : Building
    {
        int floors {  get; set; }
        public MultiBuilding(string adress, int length, int windth, int height, int floors)
            :base(adress,length,windth,height)
        {
            this.floors = floors;
        }
        public string Print()
        {
            string result = base.Print();
            result += $", этажность - {floors}";
            return result;
        }
    }
}
