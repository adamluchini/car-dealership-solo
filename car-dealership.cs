using System;
using System.Collections.Generic;

class Car
{
  public string Make;
  public string Model;
  public int Price;
  public int Miles;
}

class Program
{
  public static void Main()
  {
    Car datsun = new Car();
    datsun.Make = "Datsun";
    datsun.Model = "510";
    datsun.Price = 2500;
    datsun.Miles = 80000;

    Car matrix = new Car();
    matrix.Make = "Toytoa";
    matrix.Model = "Matrix";
    matrix.Price = 8000;
    matrix.Miles = 62500;

    Car fiat = new Car();
    fiat.Make = "Fiat";
    fiat.Model = "22";
    fiat.Price = 32000;
    fiat.Miles = 2400;

    List<Car> CarList= new List<Car>(){datsun, matrix, fiat}; //makes of list of all cars
    // foreach(Car saleCar in CarList)
    // {
    //   Console.WriteLine(saleCar.Make); //displays all the cars in a list
    // }

    Console.WriteLine("Enter maximum price: "); //the user wants to enter a max price and generate a list of valid cars for sale
    string stringMaxPrice = Console.ReadLine(); //the console reads the input and stores it as a string under the variable "stringMaxPrice"
    int maxPrice = int.Parse(stringMaxPrice); //the string is parsed and converted into an integer and stored as "maxPrice"

    List<Car> PriceMatchingList = new List<Car>(); //makes a new list based on user input of maxPrice
    foreach (Car saleCar in CarList)
    {
      if (saleCar.Price <= maxPrice) //if the car is too expensive it doesn't get added
      {
        PriceMatchingList.Add(saleCar); //all cars that qualify get added
      }
    }
    // foreach (Car saleCar in PriceMatchingList)
    // {
    //   Console.WriteLine(saleCar.Make);
    // }

    //searching for cars for max price AND max mileage

    Console.WriteLine("Enter maximum mileage: ");
    string stringMaxMileage = Console.ReadLine();
    int maxMileage = int.Parse(stringMaxMileage);

    List<Car> MileageMatchingList = new List<Car>();
    foreach (Car saleCar in PriceMatchingList) //uses PriceMatchingList instead of all list.
    {
      if (saleCar.Miles <= maxMileage)
      {
        MileageMatchingList.Add(saleCar);
      }
    }
    foreach (Car saleCar in MileageMatchingList)
    {
      Console.WriteLine(saleCar.Make);
    }
  }
}
