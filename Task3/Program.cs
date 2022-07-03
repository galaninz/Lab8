using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "Log/log.txt";
            int chars = 0;
            int words = 0;
            int lines = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                string text = sr.ReadToEnd();
                string[] textArray = text.Split();
                Console.WriteLine(text);
                chars = text.Length;
                Console.WriteLine(File.GetAttributes(path));// Думал может есть что-то похожее на DriveInfo для файлов
               if (text[0] != ' ') // Так я добавил превое слово в первой строке, не понимаю как добавить первые слова в других строках (была идея сделать Split на двумерную матрицу string[,], не дает так сделать.                
                {
                    words = 1;
                }
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == ' ')
                    {
                        words++;
                    }
                }
                //while (sr.ReadLine() != null) Почему то не работает
                //{
                //    lines++;
                //} 
                lines = File.ReadAllLines(path).Length;
                Console.WriteLine(chars);
                Console.WriteLine(words);
                Console.WriteLine(lines);
            }

            Console.ReadKey();
        }
    }
}
