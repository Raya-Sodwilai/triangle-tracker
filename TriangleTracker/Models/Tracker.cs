using System;
using TriangleTracker.Models;

namespace TriangleTracker
{
  public class Tracker
  {
    public static void Main()
    {
      Console.WriteLine("Enter a number");
      string stringFirstNumber = Console.ReadLine();
      int firstNumber = int.Parse(stringFirstNumber);

      Console.WriteLine("Enter a number");
      string stringSecondNumber = Console.ReadLine();
      int secondNumber = int.Parse(stringSecondNumber);

      Console.WriteLine("Enter a number");
      string stringThirdNumber = Console.ReadLine();
      int thirdNumber = int.Parse(stringThirdNumber);

      if ((firstNumber > (secondNumber + thirdNumber)) || (secondNumber > (firstNumber + thirdNumber)) || (thirdNumber > (firstNumber + secondNumber))) 
      {
        Console.WriteLine("not a triangle");
      }
      else if ((firstNumber != secondNumber) && ((firstNumber != thirdNumber)) && ((secondNumber != thirdNumber)))
      {
        Console.WriteLine("scalene triangle");
      }
      else if ((firstNumber == secondNumber) && (firstNumber == thirdNumber))
      {
        Console.WriteLine("equilateral triangle");
      }
      else
      {
        Console.WriteLine("isosceles triangle");
      }
    }
  }
}
  