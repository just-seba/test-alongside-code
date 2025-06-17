using System.ComponentModel.DataAnnotations;

namespace TestAlongsideCode.Console.Configurations;

public class MainConfigurationTest
{
    [Test]
    public void Validate_Checks_For_Environment()
    {
        var config = new MainConfiguration { Environment = null! };
        Assert.Catch<ValidationException>(config.Validate);
    }
}
