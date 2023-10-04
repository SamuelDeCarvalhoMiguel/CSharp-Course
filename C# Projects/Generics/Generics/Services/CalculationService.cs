namespace Generics.Services
{
  class CalculationService
  {
    public T HighestValue<T>(List<T> list) where T : IComparable
    {
      if (list.Count == 0)
        throw new Exception("The list can not be empty.");

      T max = list[0];

      for (int i = 1; i < list.Count; i++)
      {
        if (list[i].CompareTo(max) > 0)
        {
          max = list[i];
        }
      }

      return max;
    }
  }
}
