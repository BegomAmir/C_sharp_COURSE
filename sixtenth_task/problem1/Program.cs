using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.IO;

namespace problem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            Product[] product = new Product[n];
                for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите номер товара");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите название товара");
                string name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите стоимость товара");
                int price = Convert.ToInt32(Console.ReadLine());
                product[i] = new Product { Id = id, Name = name, Price = price };
            }
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(product, options);
            using(StreamWriter  sw = new StreamWriter("../../../Product.json"))
            {
                sw.WriteLine(jsonString);
            }
        }
    }
}
