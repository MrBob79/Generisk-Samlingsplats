using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Skapar inmatning för ett nytt konto
        Console.WriteLine("Skriv in ditt Namn som ägare för kontot:");
        string owner = Console.ReadLine();

        Console.WriteLine("Skriv in ditt nuvarande Saldo:");
        double saldo = double.Parse(Console.ReadLine());

        Console.WriteLine("Skriv in ditt kontonummer: ");
        int accountNumber = int.Parse(Console.ReadLine());

        // Användaren anger hur mycket man vill månadsspara
        Console.WriteLine("Skriv hur mycket du vill månadsspara: ");
        double savings = double.Parse(Console.ReadLine());

        Bankkonto konto = new Bankkonto(owner, saldo, accountNumber, savings);
              
        // Sätt in pengar
        Console.WriteLine("Ange hur mycket du vill sätta in: ");
        double deposit = double.Parse(Console.ReadLine());
        konto.CashIn(deposit);

        // Ta ut pengar
        Console.WriteLine("Ange hur mycket pengar du vill ta ut: ");
        double withdrawal = double.Parse(Console.ReadLine());
        konto.CashOut(withdrawal);

        List<StockPost> stockPostsList = new List<StockPost>();


        // Lägg till aktieposter
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Ange information för aktie {i + 1}:");
            Console.Write("Namn: ");
            string stockName = Console.ReadLine();
            Console.Write("Värde vid köp: ");
            int valueatBuy = int.Parse(Console.ReadLine());
            Console.Write("Antal aktier: ");
            int amountStock = int.Parse(Console.ReadLine());

            StockPost stockPost = new StockPost(stockName, valueatBuy, amountStock);
            stockPostsList.Add(stockPost);             
        }
        foreach (var stockPost in stockPostsList)
        {
            konto.AddToStockPost(stockPost);
        }

        konto.PrintInfo();
        konto.PrintStockPosts();
    }
}


