using System;
using TriangleTracker.Models;

namespace TriangleTracker
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter the first number");
      int firstNumber = int.Parse(Console.ReadLine());

      Console.WriteLine("Enter the second number");
      int secondNumber = int.Parse(Console.ReadLine());

      Console.WriteLine("Enter the third number");
      int thirdNumber = int.Parse(Console.ReadLine());

      Triangle inputtedTriangle = new Triangle();
      string result = inputtedTriangle.IsTriangle(firstNumber, secondNumber, thirdNumber);

      Console.WriteLine($"This is {result}. ");
    }
  }
}
  