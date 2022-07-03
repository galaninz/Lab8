using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\MSI";
            string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
            foreach (string f in files)
            {
                Console.WriteLine(f);
            }
            Console.ReadKey();
        }
    }
}
