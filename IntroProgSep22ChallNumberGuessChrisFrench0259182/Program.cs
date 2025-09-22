using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroProgSep22ChallNumberGuessChrisFrench0259182
{
    internal class Program
    {


        static Random random = new Random();


        static int Guess = 0;
        static int myGuess = 0;



        static void Main(string[] args)
        {
            int NumberToGuess = random.Next(1, 25);
            /*
                        Console.WriteLine("Please guess a number between 1 to 25");
                        string Guess = Console.ReadLine();
                        int myGuess = int.Parse(Guess);
                        */



            //bool Correct = true;// check to see if guess is correct

            // {
            //while (false)
            while (myGuess != NumberToGuess)
            {
                Console.WriteLine("Please guess a number between 1 to 25");
                string Guess = Console.ReadLine();
                int myGuess = int.Parse(Guess);
                // if (myGuess == NumberToGuess)
               // Console.ReadKey();
             /*  if (myGuess == NumberToGuess)
                {
                    Console.WriteLine($"Dang... you are good Dawg.... you guessed {Guess}, and the number to guess was {NumberToGuess}! ");
                    Console.ReadKey(true);
                }      
                // movin stuff around in  order

                */

                if (myGuess > NumberToGuess)
                {
                    Console.WriteLine("Opps not quite enough... guess again. ");
                    Console.ReadKey(true);
                    //guessMyNumber();
                }
                else if (myGuess < NumberToGuess)
                {
                    Console.WriteLine("A little over the mark there... Guess again. ");
                    Console.ReadKey(true);
                    //guessMyNumber();
                }

                else
                {
                    Console.WriteLine($"Dang... you are good Dawg.... you guessed {Guess}, and the number to guess was {NumberToGuess}! ");
                    Console.ReadKey(true);

                }

                //while (false)
                /*
                if (myGuess > NumberToGuess)
                {
                    Console.WriteLine("Opps not quite enough... guess again. ");
                    Console.ReadKey();
                    //guessMyNumber();
                }
                else if (myGuess < NumberToGuess)
                {
                    Console.WriteLine("A little over the mark there... Guess again. ");
                    Console.ReadKey();
                    //guessMyNumber();
                }
                break;   */
            }



        }
    }
    
}













