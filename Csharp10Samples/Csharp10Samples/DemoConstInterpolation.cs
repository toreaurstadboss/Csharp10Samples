using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Csharp10Samples
{
    //Sample code From const C# reference on MSDN (docs.microsoft.com) https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/const
    public static class DemoConstInterpolation
    {

        public static void RunDemo()
        {
            //We can now interpolate expressions and assign them to a const as long as the expressions used are also constant strings
            const string Language = "C#";
            const string Platform = ".NET";
            const string Version = "10.0";
            //try to uncomment line below - compiler is clever enough to forbid this ! :-D  gives CS0133 error
            //const string FooBar = DateTime.Now.ToString();
            const string FullProductName = $"{Platform} - Language: {Language} Version: {Version}";

            WriteLine($"Here is your const: {FullProductName}"); 

        }
    }
}
