namespace TestAlongsideCode.ClassLibrary;

public class MyServiceTest
{
    [Test]
    public void ToUpperCase_Returns_Expected_Value()
    {
        var mixed = "Hello World";
        var result = new MyService().ToUpperCase(mixed);
        Assert.That(result, Is.EqualTo("HELLO WORLD"));
    }
}
