using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Services
{
  class PrintService<T>
  {
    private T[] ValuesList = new T[10];
    private int Count = 0;

    public PrintService() { }

    public void AddValue(T value)
    {
      if (Count == 10)
      {
        throw new Exception("PrintService is full!");
      }
      ValuesList[Count] = value;
      Count++;
    }

    public T FirstValue()
    {
      if (Count == 0)
      {
        throw new Exception("PrintService is empty!");
      }
      return ValuesList[0];
    }

    public void Print()
    {
      Console.Write("[");

      for (int i = 0; i < Count - 1; i++)
      {
        Console.Write($"{ValuesList[i]}, ");
      }

      if (Count > 0)
      {
        Console.Write($"{ValuesList[Count - 1]}");
      }

      Console.WriteLine("]");


      if (Count > 0)
      {
        Console.Write($"First: {ValuesList[0]}");
      }
    }
  }
}
