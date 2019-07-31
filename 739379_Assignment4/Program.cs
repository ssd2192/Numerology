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
        int temp;

        public static Dictionary<string, int> LetterValue = new Dictionary<string, int>(){
                {"A",1},
                {"B",2},
                {"C",3},
                {"D",4},
                {"E",5},
                {"F",6},
                {"G",7},
                {"H",8},
                {"I",9},
                {"J",10},
                {"K",11},
                {"L",12},
                {"M",13},
                {"N",14},
                {"O",15},
                {"P",16},
                {"Q",17},
                {"R",18},
                {"S",19},
                {"T",20},
                {"U",21},
                {"V",22},
                {"W",23},
                {"X",24},
                {"Y",25},
                {"Z",26}
            };

        public void Run()
        {
            Console.WriteLine("Tell me your Name");
            string name = Console.ReadLine();
            int total = this.RunGeomatriaCalculator(name);

            Console.WriteLine("Total is " + total);


        }

        private int RunGeomatriaCalculator(string name)
        {
            int GematricValue = 0, total = 0;
            int n, m, sum = 0;
            // walk over string and pluck
            foreach (char letter in name)
            {
                Console.WriteLine(letter);
                // int numValue = getletterNumber(letter);
                //this.RunGeomatriaCalculator(letter);

                GematricValue = this.ReturnGeomatriaCalculator(letter.ToString());
                total += GematricValue;


            }


            sum = reduceSum();
            int reduceSum()
            {
                while (total > 0 || sum > 9)
                {
                    if (total == 0)
                    {
                        total = sum;
                        sum = 0;
                    }
                    sum += total % 10;
                    total /= 10;
                }
                return sum;

               
                
            }
            

            return sum;

        }

        private int ReturnGeomatriaCalculator(string v)
        {
            return LetterValue[v.ToUpper()];
        }

        private void RunGeomatriaCalculator(char letter)
        {
            // walk over string and pluck
            temp = LetterValue[letter.ToString()];
           // Console.WriteLine(temp);

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
            //Console.WriteLine(LetterValue["A"]);
        }
    }
}
