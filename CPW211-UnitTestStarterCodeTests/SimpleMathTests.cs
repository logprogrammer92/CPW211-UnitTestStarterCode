using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests;

[TestClass()]
public class SimpleMathTests
{
    [TestMethod()]
    [DataRow(5, 10)]
    [DataRow(0, 100)]
    [DataRow(-1, -10)]
    [DataRow(0, -0)]
    public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
    {
        // Use the DataRow values to test the Add method
        double result = num1 + num2;
        Assert.AreEqual(result, SimpleMath.Add(num1, num2));
    }

    [TestMethod]
    [DataRow(5, 10)]
    [DataRow(0, 100)]
    [DataRow(-1, -10)]
    public void Multiply_TwoNumbers_ReturnsProduct(double a, double b)
    {
        // Use a few pairs of values to test the Multiply method
        double result = a * b;
        Assert.AreEqual(result, SimpleMath.Multiply(a, b));
    }

    [TestMethod]
    public void Divide_DenominatorZero_ThrowsArgumentException()
    {

        Assert.ThrowsExactly<ArgumentException>(() => SimpleMath.Divide(10, 0), "Denominator cannot be zero");
    }

    [TestMethod]
    [DataRow(10, 2)]
    [DataRow(100, 10)]
    [DataRow(-10, -2)]
    public void Divide_TwoNumbers_ReturnsQuotient(double a, double b)
    {
        
        double result = a / b;
        Assert.AreEqual(result, SimpleMath.Divide(a, b));
    }

    // TODO: Add a new test to test the subtract method with two valid numbers
    [TestMethod]
    [DataRow(10, 5)]
    [DataRow(0, 0)]
    [DataRow(-5, -10)]
    public void Subtract_TwoNumbers_ReturnsDifference(double a, double b)
    {
        double result = a - b;
        Assert.AreEqual(result, SimpleMath.Subtract(a, b));
    }
}