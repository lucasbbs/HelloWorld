using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Variables;
internal class Variables
{
    public byte byteNumber = 2;
    public int intNumber = 2;
    public float floatNumber = 2.5f;
    public char charLetter = 'A';
    public string stringText = "Hello, World!";
    public bool boolIsTrue = true;
    public void ShowByte()
    {
        Console.WriteLine(byteNumber);
    }
    public void ShowInt()
    {
        Console.WriteLine(intNumber);
    }
    public void ShowFloat()
    {
        Console.WriteLine(floatNumber);
    }

    public void ShowChar()
    {
        Console.WriteLine(charLetter);
    }

    public void ShowString()
    {
        Console.WriteLine(stringText);
    }
    
    public void ShowBool()
    {
        Console.WriteLine(boolIsTrue);
    }
}
