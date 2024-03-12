using problem1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;
            using (StreamReader sr = new StreamReader("../../../Product.json"))
            {
                jsonString = sr.ReadToEnd();
            }
            Product[] products = JsonSerializer.Deserialize < Product[]>(jsonString);
            Product maxProduct = products[0];
            foreach(Product p in products)
            {
                if(p.Price > maxProduct.Price)
                {
                    maxProduct = p;
                }
            }
            Console.WriteLine($"{maxProduct.Name} имеет наибольшую цену");
            Console.ReadKey();
        }
    }
}
