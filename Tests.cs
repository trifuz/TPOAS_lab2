using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class EllipseTests
{
    [TestMethod]
    public void Area_CorrectValues()
    {
        Ellipse e = new Ellipse();
        e.Init(4, 2);
        double expected = Math.PI * 8;

        double actual = e.Area();

        Assert.AreEqual(expected, actual, 0.000001);
    }

    [TestMethod]
    public void Init_InvalidValues_DefaultSet()
    {
        Ellipse e = new Ellipse();
        double expected = Math.PI * 2;

        e.Init(1, 5);
        double actual = e.Area();

        Assert.AreEqual(expected, actual, 0.000001);
    }

    [TestMethod]
    public void PropertyB_ValidChange()
    {
        Ellipse e = new Ellipse();
        e.Init(5, 2);
        double expected = Math.PI * 15;

        e.B = 3;
        double actual = e.Area();

        Assert.AreEqual(expected, actual, 0.000001);
    }

    [TestMethod]
    public void PropertyB_InvalidChange()
    {
        Ellipse e = new Ellipse();
        e.Init(5, 2);
        double expected = Math.PI * 5;

        e.B = 10;
        double actual = e.Area();

        Assert.AreEqual(expected, actual, 0.000001);
    }

    [TestMethod]
    public void Add_TwoEllipses()
    {
        Ellipse e1 = new Ellipse();
        e1.Init(4, 2);

        Ellipse e2 = new Ellipse();
        e2.Init(6, 3);

        double expected = Math.PI * 50;

        Ellipse result = Ellipse.add(e1, e2);
        double actual = result.Area();

        Assert.AreEqual(expected, actual, 0.000001);
    }

    [TestMethod]
    public void Add_ResultNotNull()
    {
        Ellipse e1 = new Ellipse();
        e1.Init(2, 1);

        Ellipse e2 = new Ellipse();
        e2.Init(3, 2);

        Ellipse result = Ellipse.add(e1, e2);

        Assert.IsNotNull(result);
    }

    [TestMethod]
    public void Init_NegativeValues()
    {
        Ellipse e = new Ellipse();
        double expected = Math.PI * 2;

        e.Init(-5, -1);
        double actual = e.Area();

        Assert.AreEqual(expected, actual, 0.000001);
    }

    [TestMethod]
    public void Area_PositiveCheck()
    {
        Ellipse e = new Ellipse();
        e.Init(3, 1);

        double actual = e.Area();

        Assert.IsTrue(actual > 0);
    }

    [TestMethod]
    public void B_EqualsA_Invalid()
    {
        Ellipse e = new Ellipse();
        e.Init(5, 2);
        double expected = Math.PI * 5;

        e.B = 5;
        double actual = e.Area();

        Assert.AreEqual(expected, actual, 0.000001);
    }

    [TestMethod]
    public void Multiple_Add()
    {
        Ellipse e1 = new Ellipse();
        e1.Init(2, 1);

        Ellipse e2 = new Ellipse();
        e2.Init(3, 2);

        Ellipse e3 = Ellipse.add(e1, e2);
        Ellipse e4 = Ellipse.add(e3, e1);

        Assert.IsNotNull(e4);
    }
}
