using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker.Models;

namespace Program.Tests
{
  [TestClass]
  public class TriangleTrackerTest
  {
    public void IsTriangle_IsNotATriangle_NotATriangle()
    {
      Triangle testNot = new Triangle();
      Assert.AreEqual("not a triangle", testNot.IsTriangle(5,7,9));
    }

    [TestMethod]
    public void IsTriangle_IsScalene_Scalene()
    {
      Triangle testScalene = new Triangle();
      Assert.AreEqual("scalene triangle", testScalene.IsTriangle(2,3,4));
    }

    [TestMethod]
    public void IsTriangle_IsEquilateral_Equilateral()
    {
      Triangle testEquilateral = new Triangle();
      Assert.AreEqual("equilateral triangle", testEquilateral.IsTriangle(5,5,5));
    }

    [TestMethod]
    public void IsTriangle_IsIsosceles_Isosceles()
    {
      Triangle testIsosceles = new Triangle();
      Assert.AreEqual("isosceles triangle", testIsosceles.IsTriangle(5,5,7));
    }
  }
}