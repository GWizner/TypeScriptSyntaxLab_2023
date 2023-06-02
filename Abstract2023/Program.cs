using Abstract2023;

//Animal myGeneralAnimal = new Animal(); //abstract class cannot be insantiated must be inherited
Dog dog = new Dog();
Pig pig = new Pig();

//myGeneralAnimal.AnimalSound();

//pig.AnimalSound();
//dog.AnimalSound();

List<Animal> animals = new List<Animal>()
{
    dog,
    pig
};

foreach (Animal animal in animals)
{
    animal.AnimalSound();
}