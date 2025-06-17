namespace TestAlongsideCode.ClassLibrary;

public class MyService
{
    public virtual string ToUpperCase(string input) => input.ToUpperInvariant();

    public virtual string ToLowerCase(string input) => input.ToLowerInvariant();
}
