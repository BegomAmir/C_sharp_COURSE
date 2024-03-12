using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace _16._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            Empoyee[] empoyees = new Empoyee[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите номер");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите имя");
                string name = Console.ReadLine();
                Console.WriteLine("Введите зп");
                int summa = Convert.ToInt32(Console.ReadLine());
                empoyees[i] = new Empoyee()
                {
                    Num = num,
                    Name = name,
                    Summa = summa
                };

            }
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(empoyees, options);
            using (StreamWriter sw = new StreamWriter("../../../Empoyees.json"))
            {
                sw.WriteLine(jsonString);
            }
        }

    }
}
