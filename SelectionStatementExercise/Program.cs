namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            

            var r = new Random();

            var favNum = r.Next(1,1000);

            bool correct = false;


            while (!correct)
            {

                Console.WriteLine("Guess my favorite number: ");

                var userInput = int.Parse(Console.ReadLine());


                if (userInput > favNum)
                {
                    Console.WriteLine("Too high try again");
                }
                else if (userInput < favNum)
                {
                    Console.WriteLine("Too low, try again");
                } 
                

            }

            Console.WriteLine("Correct");
        }

        




    }
}
