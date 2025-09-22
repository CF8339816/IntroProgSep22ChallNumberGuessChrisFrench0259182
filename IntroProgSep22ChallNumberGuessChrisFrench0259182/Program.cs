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
        
        
        
        
        
        static void Main(string[] args)
        {

            void GuessingGame()
            { 

                int NumberToGuess = random.Next(1,25);
            
                Console.WriteLine("Please guess a number between 1 to 25");
                int Guess = Console.Readkey();
                

                bool isGuessCorrect() // check to see if guess is correct

                {
                    if (Guess = NumberToGuess)
                    {
                        return true;
                    }

                    else
                    {
                        return false;
                    }
                }

                while (false)

                {

                    if (Guess)
                    {
                        if (Guess > NumberToGuess)
                        {
                            Console.WriteLine("Opps not quite enough... guess again. ");

                        }
                        else if (Guess < NumberToGuess)
                        {
                            Console.WriteLine("A little over the mark there... Guess again. ");

                        }

                    }
                    else
                    {

                        Console.WriteLine($"Dang... you are good Dawg.... you guessed {Guess}, and the number to guess was {NumberToGuess}! ");
                        Console.WriteLine("Wana play again?   Y= yes N = no. ");

                        string playagain = Console.ReadLine();

                        if (playagain = Y)
                        {
                            GuessingGame();

                        }
                        else
                        {
                            break;
                        }

                    }
                }











                Console.ReadKey();
            }













        }
    }
}
