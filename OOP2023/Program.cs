



using OOP2023;
using System.Net.NetworkInformation;

Pig myPig = new Pig();
Pig myPig2 = new Pig();
Pig myDog = new Pig();
Pig myDog2 = new Pig();

List<Animal> animals = new List<Animal>()
{
    myPig, myPig2, myDog, myDog2
};

foreach (Animal animal in animals)
{
    animal.AnimalSound();
}