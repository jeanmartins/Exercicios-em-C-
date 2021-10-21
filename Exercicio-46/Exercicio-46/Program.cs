using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Exercicio46.Entities;
namespace Exercicio46
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\in.txt";
            HashSet<LogRecord> set = new HashSet<LogRecord>();
            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord(name, instant));
                    }
                    Console.WriteLine("Total Users: " + set.Count);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
            

        }
    }
}
