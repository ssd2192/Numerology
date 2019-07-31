using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _739379_Assignment4
{
    class Program
    {

        static void Main(string[] args)
        {
            Gematria g = new Gematria();
            g.Run();

            Playground p = new Playground();
            p.Run();
            Console.ReadKey();
        }
    }

    class Gematria
    {

        public static Dictionary<string, int> LetterValue = new Dictionary<string, int>(){
                {"A",1},
                {"B", 2},
                {"C",3}
            };

        public void Run()
        {
            Console.WriteLine("Tell me your Name");
            string name = Console.ReadLine();
            this.RunGeomatriaCalculator(name);
            
        }

        private void RunGeomatriaCalculator(string name)
        {
            // walk over string and pluck
            foreach (char letter in name)
            {
                Console.WriteLine(letter);
                // int numValue = getletterNumber(letter);
                this.RunGeomatriaCalculator(letter);



            }

        }

        private void RunGeomatriaCalculator(char letter)
        {
            // walk over string and pluck
            int temp = LetterValue["B"];
            Console.WriteLine(temp);

        }

        private int getletterNumber(char letter)
        {
            int numValue = 0;

            switch (letter)
            {
                case 'A':
                    numValue = 1;
                    break;
            }

            return numValue;
        }
    }

    class Playground
    {
        public void Run()
        {
            Dictionary<string, int> LetterValue = new Dictionary<string, int>(){
                {"A",1},
                {"B", 2},
                {"C",3}
            };

            int temp = LetterValue["B"];
            Console.WriteLine(LetterValue["A"]);
        }
    }
}
