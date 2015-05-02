using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Magic8Ball
{
    /// <summary>
    /// Entry point for magic 8 ball program
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            //Preserve current Console Text Color
            ConsoleColor oldColor = Console.ForegroundColor;


            Title();
            Random randomObject = new Random();
            //Random stuff

            //Loop Forever
            while(true){
                //This Block of code will ask and store a question
                string input = GetQuestion();

                int numtosleep = randomObject.Next(5) + 1;
                Console.WriteLine("Thinking About Your Answer, Please Stand By...");
                Thread.Sleep(numtosleep * 1000);
                

                if(input.Length == 0)
                {
                    Console.WriteLine("You need to type a question fool");
                    continue;
                }

                //use random number to determine response
                if (input.ToLower() == "quit")
                {
                    break;
                }

                //If user insults You kill them
                if (input.ToLower() == "You Suck")
                {
                    Console.WriteLine("You suck even more, Bye!");
                    break;
                }
                int rand = randomObject.Next(4);
                Console.ForegroundColor = (ConsoleColor)rand.Next(15);
                switch (rand)
                {
                    case 0:
                        {
                            Console.WriteLine("YES!");
                            break;
                        }

                    case 1:
                        {
                            Console.WriteLine("NO!");
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("HELL NO!");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("OMG YAAAAAAAS!");
                            break;
                        }

                }

            }//end of while loop
            
            //clean up
            Console.ForegroundColor = oldColor;
        }
        static void Title()
        {
            //sets console Color
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("M");

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("agic 8 ball");
        }

        /// <summary>
        /// Will return what the user types.
        /// </summary>
        /// <returns></returns>
        static string GetQuestion()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Ask a question: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string input = Console.ReadLine();
            return input;
        }
    }
}
