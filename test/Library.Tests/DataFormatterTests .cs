namespace TestDateFormat;

public class DataFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void FechaBlanco()
    {
    
        string input = "";
        string expected = "Vacio" ;
        string output = DateFormatter.ChangeFormat(input);
        Assert.AreEqual(expected,output);
    }
    [Test]
    public void FormatoNoCorrecto()
    {
        string input = "12/01/20004";
        string expected = "Error";
        string output = DateFormatter.ChangeFormat(input);
        Assert.AreEqual(expected, output);
    }
    [Test]
    public void FormatoCorrecto()
    {
        string input = "12/01/2004";
        string expected = "2004-01-12";
        string output = DateFormatter.ChangeFormat(input);
        Assert.AreEqual(expected, output);
    }
}