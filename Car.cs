using System;
using System.Collections.Generic;

class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;
}

public class Program
{
  public static void Main()
  {
    Car porsche = new Car();
    porsche.MakeModel = "2014 Porsche 911";
    porsche.Price= 114432;
    porsche.Miles = 92810;

    Car ford = new Car();
    ford.MakeModel = "2011 Ford F450";
    ford.Price = 55995;
    ford.Miles = 14241;

    Car lexus = new Car();
    lexus.MakeModel = "2013 Lexus RX 350";
    lexus.Price = 44700;
    lexus.Miles = 20000;

    Car mercedes = new Car();
    mercedes.MakeModel = "Mercedes Benz CLS550";
    mercedes.Price = 39900;
    mercedes.Miles = 37979;


    List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes }; //Create List of Cars
    foreach(Car automobile in Cars) //for each Car in "Cars" list...
    {
      Console.WriteLine(automobile.MakeModel); // Write in console the MakeModel
    }
    Console.WriteLine("Enter maximum price: "); //Ask user for Input...
    int intMaxPrice = int.Parse(Console.ReadLine()); // User Inputs string, which converted to int...

    List<Car> CarsMatchingSearch = new List<Car>(); // Create new "CarsMatchingSearch" List

    foreach (Car automobile in Cars) // for each Car in "Cars" list...
    {
      if (automobile.Price < intMaxPrice) // if automobile price is less than user input of price...
      {
        CarsMatchingSearch.Add(automobile); // Add automobile to "CarsMatchingSearch" List
      }
    }

    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.MakeModel);
    }
  }
}
