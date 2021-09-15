using Csharp10Samples;
using System.Threading.Tasks;
using static System.Console;


// See https://aka.ms/new-console-template for more information

//C# Language Hightlights: Top level statements video - top level statements are fun 

// https://www.youtube.com/watch?v=Ge9qaMI8Cc4

WriteLine("Hulloh, lets run some code in Top level statements. This has been available since C# 9 tho. Finding the .net framework version..");

await Task.Delay((int) (0.2D * 1000.0D)); //yes, can await in top level statements 


string framework = AppDomain.CurrentDomain.SetupInformation.TargetFrameworkName ?? "dunno";
WriteLine($"This is running {framework} with CSharp language version {GetLanaguageVersion(framework)}");


//https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/configure-language-version

string GetLanaguageVersion(string targetFramework) => targetFramework switch {

// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/switch-expression

    ".NETCoreApp,Version=v6.0" => "C# 10",
    ".NETCoreApp,Version=v5.0" => "C# 9",

    _ => "dunno" //fallback
};

DemoConstInterpolation.RunDemo();


//Uncomment language below to reveal C# version ! 

//#error version

WriteLine("Hit the any key to continue ...");

Console.ReadKey();
