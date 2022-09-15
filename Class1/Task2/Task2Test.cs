using NUnit.Framework;
using static NUnit.Framework.Assert;
using static Task2.Task2;

namespace Task2;

public class Tests
{
    [Test]
    public void Min3Test1()
    {
        That(Min3(2, 0, 3), Is.EqualTo(0));
    }

    [Test]
    public void Min3Test2()
    {
        That(Min3(5, 5, 5), Is.EqualTo(5));
    }

    [Test]
    public void Min3Test3()
    {
        That(Min3(-4, -1, -10), Is.EqualTo(-10));
    }
    
    [Test]
    public void Min3Test4()
    {
        That(Min3(-4, 0, 10), Is.EqualTo(-4));
    }

    [Test]
    public void Max3Test1()
    {
        That(Max3(2, 0, 3), Is.EqualTo(3));
    }

    [Test]
    public void Max3Test2()
    {
        That(Max3(5, 5, 5), Is.EqualTo(5));
    }

    [Test]
    public void Max3Test3()
    {
        That(Max3(-4, -1, -10), Is.EqualTo(-1));
    }
    
    [Test]
    public void Max3Test4()
    {
        That(Max3(-4, 0, 10), Is.EqualTo(10));
    }

    [Test]
    public void Deg2RadTest1()
    {
        That(Deg2Rad(180.0), Is.EqualTo(Math.PI).Within(1e-5));
        That(Deg2Rad(2 * 360 + 180.0), Is.EqualTo(5 * Math.PI).Within(1e-5));
    }

    [Test]
    public void Deg2RadTest2()
    {
        That(Deg2Rad(0), Is.EqualTo(0));
        That(Deg2Rad(2 * 360), Is.EqualTo(4 * Math.PI).Within(1e-5));
    }

    [Test]
    public void Deg2RadTest3()
    {
        That(Deg2Rad(45.0), Is.EqualTo(Math.PI / 4).Within(1e-5));
        That(Deg2Rad(360 + 45.0), Is.EqualTo(9 * Math.PI / 4).Within(1e-5));
    }


    [Test]
    public void Deg2RadTest4()
    {
        That(Deg2Rad(150.0), Is.EqualTo(5 * Math.PI / 6).Within(1e-5));
        That(Deg2Rad(360 + 150.0), Is.EqualTo(17 * Math.PI / 6).Within(1e-5));
    }

    [Test]
    public void Deg2RadTest5()
    {
        That(Deg2Rad(240.0), Is.EqualTo(4 * Math.PI / 3).Within(1e-5));
        That(Deg2Rad(360 + 240.0), Is.EqualTo(10 * Math.PI / 3).Within(1e-5));
    }

    [Test]
    public void Deg2RadTest6()
    {
        That(Deg2Rad(270.0), Is.EqualTo(3 * Math.PI / 2).Within(1e-5));
        That(Deg2Rad(360 + 270.0), Is.EqualTo(7 * Math.PI / 2).Within(1e-5));
    }

    [Test]
    public void Rad2DegTest1()
    {
        That(Rad2Deg(Math.PI), Is.EqualTo(180.0).Within(1e-5));
        That(Rad2Deg(5 * Math.PI), Is.EqualTo(5 * 180.0).Within(1e-5));
    }

    [Test]
    public void Rad2DegTest2()
    {
        That(Rad2Deg(0), Is.EqualTo(0));
        That(Rad2Deg(2 * Math.PI), Is.EqualTo(360).Within(1e-5));
    }

    [Test]
    public void Rad2DegTest3()
    {
        That(Rad2Deg(Math.PI / 4), Is.EqualTo(45.0).Within(1e-5));
        That(Rad2Deg(9 * Math.PI / 4), Is.EqualTo(360 + 45.0).Within(1e-5));
    }

    [Test]
    public void Rad2DegTest4()
    {
        That(Rad2Deg(5 * Math.PI / 6), Is.EqualTo(150.0).Within(1e-5));
        That(Rad2Deg(17 * Math.PI / 6), Is.EqualTo(360 + 150.0).Within(1e-5));
    }

    [Test]
    public void Rad2DegTest5()
    {
        That(Rad2Deg(4 * Math.PI / 3), Is.EqualTo(240.0).Within(1e-5));
        That(Rad2Deg(10 * Math.PI / 3), Is.EqualTo(360 + 240.0).Within(1e-5));
    }
    
    [Test]
    public void Rad2DegTest6()
    {
        That(Rad2Deg(3 * Math.PI / 2), Is.EqualTo(270.0).Within(1e-5));
        That(Rad2Deg(7 * Math.PI / 2), Is.EqualTo(360 + 270.0).Within(1e-5));
    }

}