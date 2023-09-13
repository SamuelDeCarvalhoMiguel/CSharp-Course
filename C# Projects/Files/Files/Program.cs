using System;
using System.IO;

namespace Files
{
  class Program
  {
    static void Main(string[] args)
    {

      example1();
    }

    static void example1()
    {
      string sourcePath = @"C:\Users\Sam\Documents\CSharp-Course\C# Projects\Files\Doc.txt";
      string targetPath = @"C:\Users\Sam\Documents\CSharp-Course\C# Projects\Files\Doc2.txt";

      try
      {
        FileInfo fileInfo = new FileInfo(sourcePath);
        //fileInfo.CopyTo(targetPath);  Cria uma copia do arquivo no destino apresentado.

        string[] lines = File.ReadAllLines(sourcePath);

        foreach (string line in lines)
        {
          Console.WriteLine(line);
        }
      }
      catch (IOException fileException)
      {
        Console.WriteLine("An error occurred!");
        Console.WriteLine(fileException.Message);
      }
    }
  }
}

