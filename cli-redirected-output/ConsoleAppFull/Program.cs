using System;
using System.Diagnostics;
using System.IO;

namespace ConsoleAppFull
{
  class Program
  {
    static void Main(string[] args)
    {
      var startInfo = new ProcessStartInfo
      {
        FileName = @"dotnet.exe",
        Arguments = @"exec ""..\..\..\ConsoleAppNetCore\bin\Debug\netcoreapp2.1\ConsoleAppNetCore.dll""",
        UseShellExecute = false,
        RedirectStandardOutput = true,
        RedirectStandardError = true,
        RedirectStandardInput = true
      };

      var process = Process.Start(startInfo);
      var output = process.StandardOutput.ReadToEnd();

      process.WaitForExit();

      Console.WriteLine("Output read: " + output);

      if (File.Exists("error.txt"))
        Console.WriteLine("Error in started process: " + File.ReadAllText("error.txt"));

      Console.ReadKey();
    }
  }
}
