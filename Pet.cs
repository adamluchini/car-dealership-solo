using System;
using System.Collections.Generic;

class Pet
{
  public string Name;
  public string Type;
  public string Breed;
  public int Age;
  public int Price;
}

class Program
{
  public static void Main()
  {
    Pet zelda = new Pet();
    zelda.Name = "Zelda";
    zelda.Type = "Dog";
    zelda.Breed = "Border Collie";
    zelda.Age = 7;
    zelda.Price = 25;

    Pet piper = new Pet();
    piper.Name = "Piper";
    piper.Type = "Cat";
    piper.Breed = "Tabby";
    piper.Age = 4;
    piper.Price = 15;

    Pet osa = new Pet();
    osa.Name = "Osa";
    osa.Type = "Dog";
    osa.Breed = "Black Lab";
    osa.Age = 2;
    osa.Price = 125;

    Pet osha = new Pet();
    osha.Name = "Osha";
    osha.Type = "Dog";
    osha.Breed = "Corgi";
    osha.Age = 5;
    osha.Price = 60;

    Pet dyno = new Pet();
    dyno.Name = "Dyno";
    dyno.Type = "Cat";
    dyno.Breed = "Forest Cat";
    dyno.Age = 8;
    dyno.Price = 10;

    List<Pet> PetList= new List<Pet>(){zelda, piper, osa, osha, dyno};
    // foreach (Pet salePet in PetList)
    // {
    //   Console.WriteLine(salePet.Name);
    // }
    Console.WriteLine("What type of animal:  ");
    string petType = Console.ReadLine();

    List<Pet> TypeList = new List<Pet>();
    foreach(Pet salePet in PetList)
    {
      if (petType == "Dog")
      {
        TypeList.Add(zelda);
        TypeList.Add(osa);
        TypeList.Add(osha);
      }else{
        TypeList.Add(piper);
        TypeList.Add(dyno);
      }
    }




    // Console.WriteLine("Enter max price:  ");
    // string stringMaxPrice = Console.ReadLine();
    // int maxPrice = int.Parse(stringMaxPrice);
    //
    // List<Pet> PriceList = new List<Pet>();
    // foreach(Pet salePet in PetList)
    // {
    //   if (salePet.Price <= maxPrice)
    //   {
    //     PriceList.Add(salePet);
    //     // TypeList.Add(osa);
    //     // TypeList.Add(osha);
    //   }
    // }
    //
    // Console.WriteLine("Enter max age:  ");
    // string stringMaxAge = Console.ReadLine();
    // int maxAge = int.Parse(stringMaxAge);
    //
    // List<Pet> AgeList = new List<Pet>();
    // foreach(Pet salePet in PriceList)
    // {
    //   if (salePet.Age <= maxAge)
    //   {
    //     AgeList.Add(salePet);
    //     // TypeList.Add(osa);
    //     // TypeList.Add(osha);
    //   }
    // }
    //
    foreach (Pet salePet in TypeList)
    {
      Console.WriteLine(salePet.Name);
    }
  }
}
