using NUnit.Framework;
using static NUnit.Framework.Assert;
using static Task3.Task3;

namespace Task3;

public class Tests
{
    [Test]
    public void FTest()
    {
        That(F(-10.0), Is.EqualTo(0.0).Within(1e-5));
        That(F(-1.5), Is.EqualTo(0.0).Within(1e-5));
        That(F(0.0), Is.EqualTo(1.0).Within(1e-5));
        That(F(2.5), Is.EqualTo(1.0).Within(1e-5));
        That(F(1.0), Is.EqualTo(-1.0).Within(1e-5));
        That(F(3.5), Is.EqualTo(-1.0).Within(1e-5));
    }

    [Test]
    public void NumberOfDaysTest()
    {
        That(NumberOfDays(2021), Is.EqualTo(365));
        That(NumberOfDays(300), Is.EqualTo(365));
        That(NumberOfDays(2020), Is.EqualTo(366));
        That(NumberOfDays(2000), Is.EqualTo(366));
        
    }

    [Test]
    public void Rotate2Test()
    {
        That(Rotate2('С', 1, -1), Is.EqualTo('С'));
        That(Rotate2('С', 2, 2), Is.EqualTo('С'));
        That(Rotate2('С', 1, 1), Is.EqualTo('Ю'));
        That(Rotate2('С', -1, -1), Is.EqualTo('Ю'));
        That(Rotate2('С', 1, 2), Is.EqualTo('В'));
        That(Rotate2('С', -1, 2), Is.EqualTo('З'));
    }

    [Test]
    public void AgeDescriptionTest()
    {
        That(AgeDescription(20), Is.EqualTo("двадцать лет"));
        That(AgeDescription(35), Is.EqualTo("тридцать пять лет"));
        That(AgeDescription(42), Is.EqualTo("сорок два года"));
        That(AgeDescription(51), Is.EqualTo("пятьдесят один год"));
        That(AgeDescription(63), Is.EqualTo("шестьдесят три года"));
        That(AgeDescription(69), Is.EqualTo("шестьдесят девять лет"));
    }

    [Test]
    public void MainTest()
    {
        Main(Array.Empty<string>());
    }
}