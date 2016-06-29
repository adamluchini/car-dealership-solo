using System;
using System.Collections.Generic;

class Car
{
  private string _make;
  private string _model;
  private int _price;
  private int _mileage;
  private string _message;

  public void SetMake(string newMake)
  {
    _make = newMake;
  }

  public string GetMake()
  {
    return _make;
  }

  public void SetModel(string newModel)
  {
    _model = newModel;
  }

  public string GetModel()
  {
    return _model;
  }

  public void SetPrice(int newPrice)
  {
    if (newPrice >= 0){
    _price = newPrice;
    } else {
      Console.WriteLine("invalid price");
    }
  }

  public int GetPrice()
  {
    return _price;
  }

  public void SetMileage(int newMileage)
  {
    if (newMileage >= 0){
    _mileage = newMileage;
    } else {
      Console.WriteLine("invalid mileage");
    }
  }

  public int GetMileage()
  {
    return _mileage;
  }

  public void SetMessage(string newMessage)
  {
    _message = newMessage;
  }
  public string GetMessage()
  {
    return _message;
  }

  public Car() {}
  public Car (string make, string model, int price, int mileage, string message)
    {
    _make = make;
    _model = model;
    _price = price;
    _mileage = mileage;
    _message = message;
  }
}

class Program
{
  public static void Main()
  {

      //uses contructor on line 70 to build
    Car datsun = new Car("Datsun", "510", 2500, 80000, "Cool vintage Datsun!");
    Car matrix = new Car("Toyota", "Matrix", 12000, 60000, "Roomy hatchback");
    Car fiat = new Car("Fiat", "G22", 35000, 9000, "fun zippy car");
    Car delorean = new Car("DMC", "DeLorean", 10000, 80000, "SWEEEEET!!!");

    List<Car> CarList= new List<Car>(){datsun, matrix, fiat, delorean}; //makes of list of all cars
    Console.WriteLine("Enter max price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    List<Car> PriceList = new List<Car>();
    foreach (Car saleCar in CarList)
    {
      if (saleCar.GetPrice() <=maxPrice)
      {
        PriceList.Add(saleCar);
      }
    }

    Console.WriteLine("Enter max mileage: ");
    string stringMaxMileage = Console.ReadLine();
    int maxMileage = int.Parse(stringMaxMileage);

    List<Car> MileageList = new List<Car>();
    foreach (Car saleCar in PriceList)
    {
      if (saleCar.GetMileage() <=maxMileage)
      {
        MileageList.Add(saleCar);
      }
    }

    foreach (Car saleCar in MileageList)
    {
      Console.WriteLine(saleCar.GetMake() + ": " + saleCar.GetMessage());
    }
  }
}
