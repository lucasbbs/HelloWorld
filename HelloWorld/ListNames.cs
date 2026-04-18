namespace HelloWorld;

public class ListNames
{
    public List<string> GetListNames(string input)
    {
        var names = input.Split(" ");
        var listNames = new List<string>();
        foreach (var name in names)
        {
            listNames.Add(name);
        }

        return listNames;
    }
}
