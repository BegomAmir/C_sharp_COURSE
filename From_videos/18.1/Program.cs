using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> month = new Dictionary<string,int>();
            month.Add("jan", 31);
            month.Add("feb", 28);
            month.Add("mar", 31);
            month.Add("apr", 30);
            month.Add("may", 31);
            month.Add("jun", 30);
            month.Add("jul", 31);
            month.Add("aug", 31);
            month.Add("sep", 30);
            month.Add("oct", 31);
            month.Add("nov", 30);
            month.Add("dec", 31);
            Console.WriteLine(month["may"]);
            Console.ReadKey();

            //LinkedList<int> ll = new LinkedList<int>();
            //ll.AddLast(1);
            //ll.AddLast(2);
            //ll.AddLast(3);
            //LinkedListNode<int> node = ll.First;
            //node.Previous = ll.Last;
            //ArrayList
            //List <int> list = new List <int>(); 
            //list.Add (1);
            //list.Add (2);
            //list.Add (3);
            //int[] array = new int[3] {4,5,6};
            //list.AddRange (array);
            //list.RemoveAt(3);
            //list.Reverse ();
            //for(int i = 0; i < list.Count; i++)
            //{
            //    list[i]++;
            //}
            //foreach(int l in list)
            //{
            //    Console.WriteLine (l);
            //}
            //Console.ReadKey();
        }
    }
}
