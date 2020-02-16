using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Please type a number:");
     int faveNumber = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine(faveNumber * 50);
    Console.WriteLine("Please type a number:");
     int faveNumber2 = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine(faveNumber2 + 25);
    Console.WriteLine("Please type a number:");
     int faveNumber3 = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine(faveNumber3 / 12.5);
    Console.WriteLine("Please type a number:");
     int faveNumber4 = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine(faveNumber4 > 50);
    Console.WriteLine("Please type a number:");
     int faveNumber5 = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine(faveNumber5 % 7);
  }
}