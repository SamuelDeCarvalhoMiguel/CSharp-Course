namespace Interface
{
  internal class Program
  {
    static void Main(string[] args)
    {
      double basicPayment;
      double tax;
      double taxValue;
      double totalPayment;

      Console.WriteLine("Enter real Data: ");

      Console.Write("Car model: ");
      string carModel = Console.ReadLine();

      Console.WriteLine("Pickup (dd/mm/yyyy hh:mm): ");
      DateTime pickupTime = DateTime.Parse(Console.ReadLine());

      Console.WriteLine("Return (dd/mm/yyyy hh:mm): ");
      DateTime returnTime = DateTime.Parse(Console.ReadLine());

      Console.WriteLine("Price per hour: ");
      double pricePerHour = double.Parse(Console.ReadLine());

      Console.WriteLine("Price per day: ");
      double pricePerDay = double.Parse(Console.ReadLine());

      TimeSpan duration = returnTime.Subtract(pickupTime);

      if (duration.TotalMinutes > 720)
      {
        if (duration.Hours > 0)
        {
          duration = duration.Add(TimeSpan.FromDays(1));
          duration = duration.Subtract(TimeSpan.FromHours(1));
        }
        basicPayment = pricePerDay * duration.Days;
      }
      else
      {
        if (duration.Minutes > 0)
        {
          duration = duration.Add(TimeSpan.FromHours(1));
          duration = duration.Subtract(TimeSpan.FromMinutes(duration.Minutes));
        }
        basicPayment = pricePerHour * duration.Hours;
      }

      tax = (basicPayment <= 100) ? 20 : 15;
      taxValue = basicPayment * (tax / 100);

      totalPayment = basicPayment + taxValue;

      Console.WriteLine($"Basic payment: {basicPayment}");
      Console.WriteLine($"Tax: {taxValue}");
      Console.WriteLine($"Total payment: {totalPayment}");

    }
  }
}