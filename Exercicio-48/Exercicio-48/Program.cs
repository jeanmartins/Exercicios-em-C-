using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Exercicio_48
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\in.csv";
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string [] line = sr.ReadLine().Split(',');
                        string candidate = line[0];
                        int votes = int.Parse(line[1]);
                        if (dictionary.ContainsKey(candidate))
                        {
                            dictionary[candidate] += votes;
                        }
                        else
                        {
                            dictionary[candidate] = votes;
                        }
                    }
                    foreach(KeyValuePair<string,int> item in dictionary)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
