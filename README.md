# TypeScriptSyntaxLab_2023
## C#
```C#
public class Dog
{
	public string Name { get; set; }
	public string Breed { get; set; }

	public Dog(string name, string breed)
	{
    	Name = name;
    	Breed = breed;
	}

	public string Bark()
	{
    	return "Woof!";
	}
}

class Program {
  static void Main(string[] args) {
    string[] dogBreeds = {"Labrador", "Golden Retriever", "Bulldog"};

    string GetRandomBreed(string[] breeds) {
      Random rand = new Random();
      int index = rand.Next(breeds.Length);
      return breeds[index];
    }

    Dog dog = new Dog("Rover", "Beagle");
    Console.WriteLine(dog.Name);
    Console.WriteLine(dog.Breed);
    Console.WriteLine(dog.Bark());
    Console.WriteLine(GetRandomBreed(dogBreeds));
  }
}
```

## JavaScript
```JavaScript
class Dog {
    constructor(name, breed) {
      this.name = name;
      this.breed = breed;
     };
     Bark() {
    return "Woof!";
  }
}
   const dogBreeds = ["Labrador", "Golden Retriever", "Bulldog"];

      function GetRandomBreed(breeds) {
  let index = Math.floor(Math.random() * breeds.length);
  return breeds[index];
}

const dog = new Dog("Rover", "Beagle");
console.log(dog.name);
console.log(dog.breed);
console.log(dog.bark());
console.log(getRandomBreed(dogBreeds));
```

## TypeScript
```TypeScript
class Dog {
  name: string;
  breed: string;

  constructor(name: string, breed: string) {
    this.name = name;
    this.breed = breed;
  }

  Bark(): string {
    return "Woof!";
  }
}

const dogBreeds: string[] = ["Labrador", "Golden Retriever", "Bulldog"];

function GetRandomBreed(breeds: string[]): string {
  let index: number = Math.floor(Math.random() * breeds.length);
  return breeds[index];
}

const dog: Dog = new Dog("Rover", "Beagle");
console.log(dog.name);
console.log(dog.breed);
console.log(dog.Bark());
console.log(GetRandomBreeds(dogBreeds));
```
