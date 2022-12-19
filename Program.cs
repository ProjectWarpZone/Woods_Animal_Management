/*
 * Program Name: Animal Management
 * Programmer: Kyan Woods
 * Date: 12/19/2022
 *
 * Description: Similar to UserManagement but with animals. Adds animals to a list and creates them as one of three animals.
 */

bool isLooping = true;

List<Dog> dogs = new List<Dog>();
List<Cat> cats = new List<Cat>();
List<Bunny> bunnies = new List<Bunny>();

while (isLooping)
{
    Console.WriteLine("Name: ");
    string name = Console.ReadLine();
    Console.WriteLine("Gender: ");
    string gender = Console.ReadLine();

    Console.WriteLine("Pet Type (1 for Dog, 2 for Cat, 3 for Bunny): ");

    int type = int.Parse(Console.ReadLine());

    Console.Clear();

    if (type == 1)
    {
        dogs.Add(new Dog(name, gender));
        Console.WriteLine(name + " is created as a Dog.");
    }
    else if (type == 2)
    {
        cats.Add(new Cat(name, gender));
        Console.WriteLine(name + " is created as a Cat.");
    }
    else if (type == 3)
    {
        bunnies.Add(new Bunny(name, gender));
        Console.WriteLine(name + " is created as a Bunny.");
    }
    else
    {
        Console.WriteLine("No animal created due to invalid selection.");
    }

    Console.WriteLine("All Dogs:");
    foreach (Dog dog in dogs)
    {
        Console.WriteLine(dog.animalName);
    }

    Console.WriteLine("All admins:");
    foreach (Cat cat in cats)
    {
        Console.WriteLine(cat.animalName);
    }

    Console.WriteLine("All Bunnies:");
    foreach (Bunny bun in bunnies)
    {
        Console.WriteLine(bun.animalName);
    }
}







































//"WarpZone was here!"