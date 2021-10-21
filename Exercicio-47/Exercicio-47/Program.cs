using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_47
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();
            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());
            for(int i =1; i<=n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                courseA.Add(x);
            }
            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                courseB.Add(x);
            }
            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                courseC.Add(x);
            }
            HashSet<int> allCourses = new HashSet<int>(courseA);
            allCourses.UnionWith(courseB);
            allCourses.UnionWith(courseC);

            Console.WriteLine("Total students: " + allCourses.Count);
        }
    }
}
