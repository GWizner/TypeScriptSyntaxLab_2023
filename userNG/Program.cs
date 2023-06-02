using System;



class GC
{





    static public void Main(String[] args)

    {




        Random rand = new Random();


        bool realInteger = false;
        int userNumberGuess = 0;
        int randomNumber = rand.Next(20) + 1;
        bool correctGuess = false;
        int numGuesses = 0;


        Console.WriteLine("Hello, User!");
        Console.WriteLine("Welcome to our number guessing game. " + randomNumber);
       /*     Console.WriteLine("We have chosen a number between 1 and 20.");
            Console.WriteLine();
            Console.WriteLine("Can you guess what it is? ");
            string userInput = Console.ReadLine();
            realInteger = int.TryParse(userInput, out userNumberGuess);

            if (realInteger == false)
            {
                Console.WriteLine("Huh?! O_o");
                
            }
            else if (userNumberGuess < 1 || userNumberGuess > 20)
            {
                Console.WriteLine("Um... ONE TO TWENTY...");
                
            }
            else if (userNumberGuess < randomNumber || userNumberGuess > randomNumber)
            {
                Console.WriteLine("WRONG!!!");
            }
            else
            {
                Console.WriteLine("You got it!");
            }
        }

        Console.WriteLine();
        if (realInteger == false)
        {
            Console.WriteLine("Funny...");
        }
        else if (numGuesses == 1)
        {
            Console.WriteLine("Wowsa, 1st try!!");
        }

        else
        {
            Console.WriteLine($"It took you {numGuesses} tries.");
        }

        Console.WriteLine();
        Console.WriteLine("Press any key to exit.");*/
    }
}