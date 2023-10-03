using Generics.Services;

namespace Generics
{
  internal class Program
  {
    static void Main(string[] args)
    {
      example1();
    }

    static void example1()
    {
      PrintService<int> printService = new PrintService<int>();

      Console.Write("How many values? ");
      int valuesAmount = int.Parse(Console.ReadLine());

      for (int i = 0; i < valuesAmount; i++)
      {
        int values = int .Parse(Console.ReadLine());
        printService.AddValue(values);
      }

      printService.Print();
    }
  }
}