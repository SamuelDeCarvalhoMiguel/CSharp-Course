using System;
using System.IO;

namespace Files
{
  class Program
  {
    static void Main(string[] args)
    {

      //example1();
      //example2();
      example3();
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
    static void example2()
    {
      string path = @"C:\Users\Sam\Documents\CSharp-Course\C# Projects\Files\Doc.txt";

      FileStream fileStream = null;
      StreamReader streamReader = null;

      try
      {
        fileStream = new FileStream(path, FileMode.Open);
        streamReader = new StreamReader(fileStream);

        while (!streamReader.EndOfStream)
        {
          string line = streamReader.ReadLine();

          Console.WriteLine(line);
        }
      }
      catch (IOException fileException)
      {
        Console.WriteLine("An error occurred!");
        Console.WriteLine(fileException.Message);
      }
      finally
      {
        if (streamReader != null)
          streamReader.Close();
        if (fileStream != null)
          fileStream.Close();
      }
    }

    static void example3()
    {

      string path = @"C:\Users\Sam\Documents\CSharp-Course\C# Projects\Files\Doc2.txt";

      try
      {
        using (StreamReader streamReader = File.OpenText(path))
        {
          while (!streamReader.EndOfStream)
          {
            string line = streamReader.ReadLine();
            Console.WriteLine(line);
          }
        }
      }
      catch (IOException exception)
      {
        Console.WriteLine("An error occurred");
        Console.WriteLine(exception.Message);
      }
    }

  }
}

