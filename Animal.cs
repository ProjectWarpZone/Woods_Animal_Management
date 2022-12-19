using System;

public class Animal
{
    public string animalName;
    public string animalGender;

    public Animal(string name, string gender)
    {
        animalName = name;
        animalGender = gender;
    }
}

public class Dog : Animal
{
    public Dog(string name, string gender) : base(name, gender)
    {
        animalName = name;
        animalGender = gender;
    }
}

public class Cat : Animal
{
    public Cat(string name, string gender) : base(name, gender)
    {
        animalName = name;
        animalGender = gender;
    }
}

public class Bunny : Animal
{
    public Bunny(string name, string gender) : base(name, gender)
    {
        animalName = name;
        animalGender = gender;
    }
}