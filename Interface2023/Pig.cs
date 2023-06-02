namespace Interface2023
{
    public class Pig : IAnimal, IAdoptable
    {
        public string FavoriteFood { get; set; }

        public void adopt()
        {
            Console.WriteLine("Pig was adopted!");
        }

        public void AnimalSound()
        {
            Console.WriteLine("Oink");
        }

        public void Run()
        {
            Console.WriteLine("Pig Runs!");
        }
    }
}
