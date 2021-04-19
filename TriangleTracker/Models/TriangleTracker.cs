using System;
namespace TriangleTracker.Models
{
  public class Triangle
  {
    public string IsTriangle(int firstNumber, int secondNumber, int thirdNumber)
    {
      if ((firstNumber >= (secondNumber + thirdNumber)) || (secondNumber >= (firstNumber + thirdNumber)) || (thirdNumber >= (firstNumber + secondNumber))) 
      {
        Console.WriteLine("not a triangle");
        return "not a triangle";
      }
      else if ((firstNumber != secondNumber) && ((firstNumber != thirdNumber)) && ((secondNumber != thirdNumber)))
      {
        Console.WriteLine("scalene triangle");
        return "scalene triangle";
      }
      else if ((firstNumber == secondNumber) && (firstNumber == thirdNumber))
      {
        Console.WriteLine("equilateral triangle");
        return "equilateral triangle";
      }
      else
      {
        Console.WriteLine("isosceles triangle");
        return "isosceles triangle";
      }
    }
  }
}