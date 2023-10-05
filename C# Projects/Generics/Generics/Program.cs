using Generics.Entities;
using Generics.Services;

namespace Generics
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //example1();
      //example2();
      example3();
    }

    static void example1()
    {
      PrintService<int> printService = new PrintService<int>();

      Console.Write("How many values? ");
      int valuesAmount = int.Parse(Console.ReadLine());

      for (int i = 0; i < valuesAmount; i++)
      {
        int values = int.Parse(Console.ReadLine());
        printService.AddValue(values);
      }

      printService.Print();
    }

    static void example2()
    {
      List<Product> list = new List<Product>();

      Console.Write("Enter amount of products: ");
      int amount = int.Parse(Console.ReadLine());

      for (int i = 0; i < amount; i++)
      {
        string[] productData = Console.ReadLine().Split(',');
        string productName = productData[0];
        double productValue = double.Parse(productData[1]);
        list.Add(new Product(productName, productValue));
      }

      CalculationService calculationService = new CalculationService();

      Product highestValueProduct = calculationService.HighestValue(list);

      Console.WriteLine("Max: ");
      Console.WriteLine(highestValueProduct);
    }

    static void example3()
    {

      Client firstClient = new Client { Name = "Maria", Email = "maria@gmail.com" };
      Client secondClient = new Client { Name = "Alex", Email = "alex@gmail.com" };

      Console.WriteLine(firstClient.Equals(secondClient));
      Console.WriteLine(firstClient == secondClient);
      Console.WriteLine(firstClient.GetHashCode());
      Console.WriteLine(secondClient.GetHashCode());


    }

  }
}