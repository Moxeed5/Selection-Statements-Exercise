using System.Security.Cryptography.X509Certificates;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
           

            var r = new Random();

            var favNum = r.Next(1,25);

            int maxGuess = 4;
            
            Console.WriteLine("You have 5 guesses...");

            for (int i = 0; i < 5; i++)
            {
                    //Here is how this for loop is working: 
                    // The loop will iterate 5 times starting at 0 (0,1,2,3,4) 
                    //first, the loop will check if i (the loop counter), is the same as maxGuesses (which is set to 4)
                    //if that condition is not true, the loop checks to see if the userINput is lower or higher, or correct. 
                    //if none of those conditions are met, the loops starts over checking the first if statement, and then looping through the rest
                    //the two ways to break the loop are i being == maxGuesses, or guessing the number correctly.

                    Console.WriteLine("Guess my favorite number: ");

                    var userInput = int.Parse(Console.ReadLine());

                    if (i == maxGuess)
                    {
                        Console.WriteLine("Out of Guesses");
                        break;
                    }
                    if (userInput > favNum)
                    {
                        Console.WriteLine($"Too high, you have {4-i} guesses left... try again");
                    }
                    else if (userInput < favNum)
                    {
                        Console.WriteLine($"Too low, you have {4-i} guesses left... try again");
                    }
                    
                    else 
                    {
                        Console.WriteLine("Correct!");
                        
                        break;
                    }
                    
            }

            
        }

        




    }
}
