using System;
using System.IO;

namespace ConsoleAppNetCore
{
  class Program
  {
    static void Main(string[] args)
    {
      File.Delete("error.txt");

      try
      {
        Console.WriteLine($"Width: {Console.WindowWidth}");
        Console.WriteLine("Hello World!");
      }
      catch (Exception e)
      {
        File.WriteAllText("error.txt", e.Message + Environment.NewLine + e.StackTrace);
      }
    }
  }
}
