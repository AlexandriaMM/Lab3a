using System;

class Program {
  public static void Main (string[] args) {
    //storing celsius from input
    Console.WriteLine ("Enter temperature in Celsius");
    int temperature = Convert.ToInt32(Console.ReadLine());
    
    //converting to farenheit and displaying
    int farenheit = (temperature * 9/5) + 32;
    Console.WriteLine("Farenheit equivalent for " + temperature + " degree celsius is " + farenheit);
    
    //checking if the temperature is below freezing or above boiling and displaying output accordingly
    if (farenheit < 32)
    {
      Console.WriteLine("This temperature is below freezing of 32 degree Farenheit");
    }
    else if (farenheit > 212)
    {
      Console.WriteLine("This temperature is above boiling point of 212 degree Farenheit");
    }
  }
}