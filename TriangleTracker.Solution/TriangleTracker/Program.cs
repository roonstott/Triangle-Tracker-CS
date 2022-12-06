using System;
using TriangleTracker.Models;

public class Program
{

  public static void Main()
  {
    Console.WriteLine("Enter 3 number separated by comma: ");
    string[] sideString = Console.ReadLine().Split(",");
    int[] sides = Array.ConvertAll(sideString, int.Parse);

    // Console.WriteLine("Enter 1st side: ");
    // int side1 = int.Parse(Console.ReadLine());

    // Console.WriteLine("Enter 2nd side: ");
    // int side2 =int.Parse( Console.ReadLine());

    // Console.WriteLine("Enter 3rd side: ");
    // int side3 = int.Parse(Console.ReadLine());

    Triangle triangle = new Triangle(sides);
    Console.WriteLine(triangle.TriangleType());

    Console.WriteLine("Do you want to try again?[y][n]");
    string ans = Console.ReadLine().Trim().ToLower();
    if(ans == "y") {
      Main();
    }    
  }
}