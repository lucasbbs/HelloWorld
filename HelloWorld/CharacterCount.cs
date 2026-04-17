using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld;
public class CharacterCount
{
    public (bool Success, int[] Counts) GetCharacterCountWithStatus(string? line)
    {
        if (string.IsNullOrEmpty(line))
            return (false, Array.Empty<int>());

        var words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var counts = words.Select(w => w.Length).ToArray();
        return (true, counts);
    }
}
