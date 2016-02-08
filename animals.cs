using System;
using System.Collections.Generic;

public class Animal
{
  public string Name;
  public string Species;
  public string Color;
  public string Age;

  public Animal(string animalName, string animalSpecies, string animalColor, string animalAge)
  {
    Name = animalName;
    Species = animalSpecies;
    Color = animalColor;
    Age = animalAge;
  }
  public bool IsACat(string animalSpecies, string speciesChoice)
  {
    if (animalSpecies == speciesChoice)
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  public bool IsADog(string animalSpecies, string speciesChoice)
  {
    if (animalSpecies == speciesChoice)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}

class Program
{
  public static void Main()
  {
    Animal suki = new Animal("Suki","cat","black", "13");
    Animal richu = new Animal("Richu Pichu","cat","white and tan","15");
    Animal eligh = new Animal("Eligh","dog","German Shepard Chow","12");
    Animal juniper = new Animal("Juniper","dog","Australian and German Shepard","1");

    List<Animal> Animals = new List<Animal>() {suki, richu, eligh, juniper};
    Console.WriteLine("Hello! We have animals!");
    Console.WriteLine("Would you like to see the animals by cat or dog? : Press 1");
    Console.WriteLine("Would you like to sort the animals by age? : Press 2");
    string searchChoice = Console.ReadLine();

    int searchChoiceInt = int.Parse(searchChoice);

    if (searchChoiceInt == 1)
    {
      Console.WriteLine("Cats or dogs?");
      string speciesChoice = Console.ReadLine();
      char[] charsToTrim = {'s'};
      speciesChoice = speciesChoice.TrimEnd(charsToTrim);
      Console.WriteLine("You searched for a " + speciesChoice);

      List<Animal> AnimalsMatchingSearch = new List<Animal>();
      foreach (Animal animal in Animals)
      {
        if (animal.IsACat(animal.Species, speciesChoice))
        {
          AnimalsMatchingSearch.Add(animal);
        }
        else if (animal.IsADog(animal.Species, speciesChoice))
        {
          AnimalsMatchingSearch.Add(animal);
        }
      }
      foreach (Animal animal in AnimalsMatchingSearch)
      {
        Console.WriteLine("Check out " + animal.Name + ", so cute! A lovely " + animal.Color + " breed of " + animal.Species);
        Console.WriteLine(animal.Name + " is " + animal.Age.ToString() + " years old.");
      }
    }
    else if (searchChoiceInt == 2)
    {
      Console.WriteLine("What is the maximum age to search for?");
      string maxAge = Console.ReadLine();
      int maxAgeInt = int.Parse(maxAge);

      List<Animal> AnimalsMatchingSearch = new List<Animal>();
      foreach (Animal animal in Animals)
      {
        int animalAge = int.Parse(animal.Age);
        if (animalAge <= maxAgeInt)
        {
          AnimalsMatchingSearch.Add(animal);
        }
      }
    }
    else
    {
      Console.WriteLine("Please Select one or two");
    }
  }
}
