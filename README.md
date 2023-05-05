# TypeScriptSyntaxLab_2023
-------------------------------------------
C#
-------------------------------------------
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

string[] dogBreeds = new string[] { "Labrador", "Golden Retriever", "Bulldog" };

public string GetRandomBreed(string[] breeds)
{
	Random random = new Random();
	int index = random.Next(breeds.Length);
	return breeds[index];
}
-------------------------------------------
JavaScript
-------------------------------------------
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
-------------------------------------------
TypeScript
-------------------------------------------
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
