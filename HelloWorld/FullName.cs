namespace HelloWorld;

public class FullName
{
    public string GetFullName(string firstName, string lastName)
    {
        return string.Format("{0} {1}", firstName, lastName);
    }
}