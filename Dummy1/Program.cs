namespace RoShamBoLab
{
    abstract class Player
    {
        public string name { get; set; }
        public Roshambo JanKenPon = Roshambo.Rock;
        public Roshambo playerAtk;

        public enum Roshambo
        {
            Rock,
            Paper,
            Scissors
        }


        public virtual Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;
        }
    }
    class RockPlayer : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;
        }
    }
    class RandomPlayer : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            Random rand = new Random();
            int rand1 = rand.Next(0, 3);
            return (Roshambo)rand1;
        }
    }
    class HumanPlayer : Player
    {
        public HumanPlayer()
        {
            Console.WriteLine("Hello, user, please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine();
        }
        public override Roshambo GenerateRoshambo()
        {
            string Jan = "paper";
            string Ken = "scissors";
            string Pon = "rock";

            Console.WriteLine("Okay, " + name + " choose your weapon (Rock, Paper, or Scissors): ");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == Jan)
            {
                return Roshambo.Paper;
            }
            else if (userInput == Ken)
            {
                return Roshambo.Scissors;
            }
            else if (userInput == Pon)
            {
                return Roshambo.Rock;
            }
            else return 0;
        }
    }
    public class Validator
    {

        public static bool getContinue()
        {
            bool result = true;
            while (true)
            {
                Console.Write("You ready for more? (y/n): ");
                string choice = Console.ReadLine().ToLower().Trim();
                choice = choice.Trim();
                Console.WriteLine();
                if (choice == "y" || choice == "yes")
                {
                    result = true;
                    break;
                }
                else if (choice == "n" || choice == "no")
                {

                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("I do not understand your input. Please try again.");
                    Console.WriteLine();
                }
            }
            return result;
        }
        /*public static string getUserWeapon()
        {
            HumanPlayer player0 = new HumanPlayer();
            bool userInput = true;
            while (true)
            {
                Console.WriteLine("Okay, " + player0.name + " choose your weapon (Rock, Paper, or Scissors): ");
                string userWeap = Console.ReadLine().ToLower().Trim();
                userWeap = userWeap.Trim();
                Console.WriteLine();
                if (userWeap == "rock" || userWeap == "paper" || userWeap == "scissors")
                {
                    userInput = true;
                    break;
                }
                else
                {
                    Console.WriteLine("You have THREE choices... ROCK... PAPER... or SCISSORS! Please try again.");
                    Console.WriteLine();
                }
            }
            return userWeap;
        }*/
        public static int getUserOpp()
        {
            HumanPlayer player0 = new HumanPlayer();
            int userOpp = 0;

            while (true)
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine($"{player0.name}, are you ready? Choose your opponent (Input 1 for RockPlayer" +
                        $" or input 2 for RandomPlayer): ");
                        userOpp = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Ummm... no, just... no. Try again.");
                        Console.WriteLine();
                    }

                }
                if (userOpp != 1 && userOpp != 2)
                {
                    Console.WriteLine("Your options are 1 or 2. That's it...");
                    Console.WriteLine();
                }
                else if (userOpp == 1 || userOpp == 2)
                {
                    break;
                }
            }
            return userOpp;

        }
        public class Program
        {
            public static void Main(string[] args)
            {
                Player.Roshambo opponentAtk = new Player.Roshambo();
                Player.Roshambo playerAtk = new Player.Roshambo();
                HumanPlayer player0 = new HumanPlayer();
                playerAtk = player0.GenerateRoshambo();
                Player opponent = null;
                bool keepAsk = true;
                int wins = 0;


                while (keepAsk)
                {
                    int userOpp = Validator.getUserOpp();

                    if (userOpp == 1)
                    {
                        opponent = new RockPlayer();
                    }
                    else if (userOpp == 2)
                    {
                        opponent = new RandomPlayer();
                    }
                    opponentAtk = opponent.GenerateRoshambo();

                    if (userOpp == 1)
                    {
                        Console.WriteLine("Seriously? Alright, for the EASY win...");
                        Console.WriteLine();

                        if (playerAtk == Player.Roshambo.Paper)
                        {
                            Console.WriteLine($"{playerAtk} vs. {opponentAtk}!");
                            Console.WriteLine("Surprise, surprise! You win... -_-");
                            Console.WriteLine();
                            wins++;
                        }
                        else if (playerAtk == Player.Roshambo.Rock)
                        {
                            Console.WriteLine($"{playerAtk} vs. {opponentAtk}!");
                            Console.WriteLine("Hoookaaay, dunno what you're tryin' ta do here, but it's a tie (obviously).");
                            Console.WriteLine();
                        }
                        else if (playerAtk == Player.Roshambo.Scissors)
                        {
                            Console.WriteLine($"{playerAtk} vs. {opponentAtk}!");
                            Console.WriteLine("Wait, what?! Uh, I guess you lose? Geez, I hope you can throw hands better than you- hmm, actually, " +
                                "I guess technically you ARE throwing your hand right now. Maybe you should just hang it up and go home.");
                            Console.WriteLine();
                        }
                    }
                    else if (userOpp == 2)
                    {
                        if (opponentAtk == Player.Roshambo.Rock && playerAtk == Player.Roshambo.Rock)
                        {
                            Console.WriteLine($"{playerAtk} vs. {opponentAtk}");
                            Console.WriteLine("Tie!");
                            Console.WriteLine("No, winner. Two losers.");
                            Console.WriteLine();
                        }
                        else if (opponentAtk == Player.Roshambo.Rock && playerAtk == Player.Roshambo.Paper)
                        {
                            Console.WriteLine($"{playerAtk} vs. {opponentAtk}");
                            Console.WriteLine("GOOOOOT 'IIIIIIM! Score one for the good guys.");
                            Console.WriteLine();
                            wins++;
                        }
                        else if (opponentAtk == Player.Roshambo.Rock && playerAtk == Player.Roshambo.Scissors)
                        {
                            Console.WriteLine($"{playerAtk} vs. {opponentAtk}");
                            Console.WriteLine("You just got knocked the **** out!");
                            Console.WriteLine();
                        }
                        else if (opponentAtk == Player.Roshambo.Paper && playerAtk == Player.Roshambo.Rock)
                        {
                            Console.WriteLine($"{playerAtk} vs. {opponentAtk}");
                            Console.WriteLine("Sorry, no dice. Maybe you can get 'im in the next round.");
                            Console.WriteLine();
                        }
                        else if (opponentAtk == Player.Roshambo.Paper && playerAtk == Player.Roshambo.Paper)
                        {
                            Console.WriteLine($"{playerAtk} vs. {opponentAtk}");
                            Console.WriteLine("BOOOOOOORIIIING!! C'mon let's get some action!");
                            Console.WriteLine();
                        }
                        else if (opponentAtk == Player.Roshambo.Paper && playerAtk == Player.Roshambo.Scissors)
                        {
                            Console.WriteLine($"{playerAtk} vs. {opponentAtk}");
                            Console.WriteLine("Oooooh, so close (not rerally).");
                            Console.WriteLine("Better luck next time.");
                            Console.WriteLine();
                        }
                        else if (opponentAtk == Player.Roshambo.Scissors && playerAtk == Player.Roshambo.Rock)
                        {
                            Console.WriteLine($"{playerAtk} vs. {opponentAtk}");
                            Console.WriteLine("Two men enter! One man leaves!Two men enter! One man leaves!");
                            Console.WriteLine();
                        }
                        else if (opponentAtk == Player.Roshambo.Scissors && playerAtk == Player.Roshambo.Paper)
                        {
                            Console.WriteLine($"{playerAtk} vs. {opponentAtk}");
                            Console.WriteLine("Yeeoouuch! You just got burned, baby!");
                            Console.WriteLine();
                        }
                        else if (opponentAtk == Player.Roshambo.Scissors && playerAtk == Player.Roshambo.Scissors)
                        {
                            Console.WriteLine($"{playerAtk} vs. {opponentAtk}");
                            Console.WriteLine("Two men enter...");
                            Console.WriteLine("and then stare at eachother...");
                            Console.WriteLine("and look really stupid.");
                            Console.WriteLine();
                        }

                    }
                    keepAsk = Validator.getContinue();
                }
            }
        }
    }
}