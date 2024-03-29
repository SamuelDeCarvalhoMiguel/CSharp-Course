﻿using System;
using System.Diagnostics.Contracts;
using System.Globalization;
using Interface.Model.Entities;
using Interface.Entities;
using Interface.Services;
using Interface.Enums;

namespace Interface
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //example1();
      //example2();
      //exercise1();
      example3();

    }

    static void example1()
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

    static void example2()
    {
      Console.WriteLine("Enter rental data");
      Console.Write("Car model: ");
      string model = Console.ReadLine();
      Console.Write("Pickup (dd/MM/yyyy HH:mm): ");
      DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
      Console.Write("Return (dd/MM/yyyy HH:mm): ");
      DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

      Console.Write("Enter price per hour: ");
      double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write("Enter price per day: ");
      double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      CarRental carRental = new CarRental(start, finish, new Vehicle(model));

      RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

      rentalService.ProcessInvoice(carRental);

      Console.WriteLine("INVOICE:");
      Console.WriteLine(carRental.Invoice);

    }

    static void example3()
    {
      IShape s1 = new Circle() { Radius = 2.0, Color = Colors.White };
      IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Colors.Black };
      Console.WriteLine(s1);
      Console.WriteLine(s2);
    }

    static void exercise1()
    {

      Console.WriteLine("Enter contract data");
      Console.Write("Number: ");
      int contractNumber = int.Parse(Console.ReadLine());
      Console.Write("Date (dd/MM/yyyy): ");
      DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
      Console.Write("Contracts value: ");
      double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write("Enter number of installments: ");
      int months = int.Parse(Console.ReadLine());

      Contracts myContract = new Contracts(contractNumber, contractDate, contractValue);

      ContractService contractService = new ContractService(new PaypalService());
      contractService.ProcessContract(myContract, months);

      Console.WriteLine("Installments:");
      foreach (Installment installment in myContract.Installments)
      {
        Console.WriteLine(installment);

      }
    }
  }
}