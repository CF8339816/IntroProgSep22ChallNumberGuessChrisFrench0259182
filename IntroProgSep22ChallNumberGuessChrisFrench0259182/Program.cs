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

        static int NumberToGuess;
        static int Guess;
        static int myGuess;



        static void Main(string[] args)
        {
            int NumberToGuess = random.Next(1, 25);

            Console.WriteLine("Please guess a number between 1 to 25");
            string Guess = Console.ReadLine();
            int myGuess = int.Parse(Guess);
            

            Console.ReadKey();


            bool Correct = true;// check to see if guess is correct
                 
            {
                if (myGuess == NumberToGuess)
                {
                    Console.WriteLine($"Dang... you are good Dawg.... you guessed {Guess}, and the number to guess was {NumberToGuess}! ");

                }


                else
                {
                   
                }
            

                while (false)

            

                if (myGuess > NumberToGuess)
                {
                    Console.WriteLine("Opps not quite enough... guess again. ");
                    //guessMyNumber();
                }
                else if (myGuess < NumberToGuess)
                {
                    Console.WriteLine("A little over the mark there... Guess again. ");
                    //guessMyNumber();
                }
                else
                {
                    break;
                }


            }















            /* 
             GameStart();
             guessMyNumber();
             guessing();









         }

         // methods below here
         static void GameStart()
         { 

             int NumberToGuess = random.Next(1,25);

             Console.WriteLine("Please guess a number between 1 to 25");
             string Guess = Console.ReadLine();
             int myGuess = int.Parse(Guess);


             Console.ReadKey();
         }

         static void guessMyNumber()
         { 
             Console.WriteLine("Please guess a number between 1 to 25");
             string Guess = Console.ReadLine();
             int myGuess = int.Parse(Guess);

             guessing();
         }
         static void guessing()
         {
             guessMyNumber();

             {
                 bool isGuessCorrect() // check to see if guess is correct

                 {
                     if (myGuess == NumberToGuess)
                     {
                         Console.WriteLine($"Dang... you are good Dawg.... you guessed {Guess}, and the number to guess was {NumberToGuess}! ");

                     }


                     else
                     {
                         return false;
                     }
                 }

                 while (false)

                 {

                     if (myGuess > NumberToGuess)
                     {
                         Console.WriteLine("Opps not quite enough... guess again. ");
                         guessMyNumber();
                     }
                     else if (myGuess < NumberToGuess)
                     {
                         Console.WriteLine("A little over the mark there... Guess again. ");
                         guessMyNumber();
                     }
                     else
                     {
                         break;
                     }


                 }
             }
         }

 */


        }
    }
}
