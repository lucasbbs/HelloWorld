using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld;
class Carro
{
    bool ligado = false;
    DateTime now = DateTime.Now;

    public string GetNowFormatted()
    {
        return now.ToString("d MMMM yyyy");
    }

}
