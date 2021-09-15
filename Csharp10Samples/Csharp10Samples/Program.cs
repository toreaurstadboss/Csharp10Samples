// See https://aka.ms/new-console-template for more information

string framework = AppDomain.CurrentDomain.SetupInformation.TargetFrameworkName;
Console.WriteLine($"This is running {framework} with CSharp language version {GetLanaguageVersion(framework)}");

Console.WriteLine("Hit the any key to continue");

Console.ReadKey();


//https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/configure-language-version

string GetLanaguageVersion(string targetFramework) => targetFramework switch {

// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/switch-expression

    ".NETCoreApp,Version=v6.0" => "C# 10",
    ".NETCoreApp,Version=v5.0" => "C# 9",

    _ => "dunno" //fallback
};


//#error version
