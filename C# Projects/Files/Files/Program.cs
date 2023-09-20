using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace Files
{
  class Program
  {
    static void Main(string[] args)
    {

      //example1();
      //example2();
      //example3();
      //example4();
      //example5();
      //example6();
      exercise();
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

    static void example4()
    {
      string sourcePath = @"C:\Users\Sam\Documents\CSharp-Course\C# Projects\Files\Doc.txt";
      string targetPath = @"C:\Users\Sam\Documents\CSharp-Course\C# Projects\Files\Doc2.txt";

      try
      {
        string[] lines = File.ReadAllLines(sourcePath);

        using (StreamWriter streamWriter = File.AppendText(targetPath))
        {
          foreach (string line in lines)
          {
            streamWriter.WriteLine(line.ToUpper());
          }
        }
      }
      catch (IOException fileException)
      {
        Console.WriteLine("An error occurred!");
        Console.WriteLine(fileException.Message);
      }
    }

    static void example5()
    {
      string path = @"C:\Users\Sam\Documents\CSharp-Course\C# Projects\Files\myfolder";

      try
      {
        IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

        Console.WriteLine("FOLDERS: ");
        foreach (string folder in folders)
        {
          Console.WriteLine(folder);
        }

        IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

        Console.WriteLine("FILES: ");
        foreach (string file in files)
        {
          Console.WriteLine(file);
        }

        Directory.CreateDirectory(path + @"/newfolder");
      }
      catch (IOException fileException)
      {
        Console.WriteLine("An error occurred!");
        Console.WriteLine(fileException.Message);
      }
    }

    static void example6()
    {
      string path = @"C:\Users\Sam\Documents\CSharp-Course\C# Projects\Files\myfolder\Docs\Doc.txt";

      Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
      Console.WriteLine("PathSeparator: " + Path.PathSeparator);
      Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
      Console.WriteLine("GetRandomFileName: " + Path.GetFileName(path));
      Console.WriteLine("GetExtension: " + Path.GetExtension(path));
      Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
      Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
      Console.WriteLine("GetTempPath: " + Path.GetTempPath());

    }

    static void exercise()
    {
      Console.Write("Enter file full path: ");
      string sourceFilePath = Console.ReadLine();

      try
      {
        string[] lines = File.ReadAllLines(sourceFilePath);

        string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
        string targetFolderPath = sourceFolderPath + @"\out";
        string targetFilePath = targetFolderPath + @"\summary.csv";

        Directory.CreateDirectory(targetFolderPath);

        using (StreamWriter sw = File.AppendText(targetFilePath))
        {
          foreach (string line in lines)
          {

            string[] fields = line.Split(',');
            string name = fields[0];
            double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
            int quantity = int.Parse(fields[2]);

            Product prod = new Product(name, price, quantity);

            sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
          }
        }
      }
      catch (IOException e)
      {
        Console.WriteLine("An error occurred");
        Console.WriteLine(e.Message);
      }

    }
  }
}

