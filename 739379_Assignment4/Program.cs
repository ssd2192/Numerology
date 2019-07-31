using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _739379_Assignment4
{
    class Program
    {
        static string name;
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me your Name");
            name = Console.ReadLine();

            Console.ReadKey();
        }
    }

    class Playground
    {
        public void Run()
        {
            Dictionary<string, int> Gematria = new Dictionary<string, int>(){
                {"A",1},
                {"B", 2},
                {"C",3}
            };
            Console.WriteLine(Gematria["A"]);
        }
    }
}
