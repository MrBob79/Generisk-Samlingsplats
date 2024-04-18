using System;


class Program
{
    static void Main(string[] args)
    {
        // Skapar inmatning för ett nytt konto
        Console.WriteLine("Skriv in ditt Namn som ägare för kontot:");
        string Owner = Console.ReadLine();

        Console.WriteLine("Skriv in ditt nuvarande Saldo:");
        double Saldo = double.Parse(Console.ReadLine());

        Console.WriteLine("Skriv in ditt kontonummer: ");
        int accountNumber = int.Parse(Console.ReadLine());

        // Användaren anger hur mycket man vill månadsspara
        Console.WriteLine("Skriv hur mycket du vill månadsspara: ");
        double Saves = double.Parse(Console.ReadLine());

        Bankkonto konto = new Bankkonto(Owner, Saldo, accountNumber, Saves);

        // Sätt in pengar
        Console.WriteLine("Ange hur mycket du vill sätta in: ");
        double deposit = double.Parse(Console.ReadLine());
        konto.CashIn(deposit);

        // Ta ut pengar
        Console.WriteLine("Ange hur mycket pengar du vill ta ut: ");
        double insert = double.Parse(Console.ReadLine());
        konto.CashOut(insert);


        // Lägg till aktieposter
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Ange information för aktie {i + 1}:");
            Console.Write("Namn: ");
            string StockName = Console.ReadLine();
            Console.Write("Värde vid köp: ");
            int ValueatBuy = int.Parse(Console.ReadLine());
            Console.Write("Antal aktier: ");
            int AmountStock = int.Parse(Console.ReadLine());

            StockPost stockPosts = new Aktiepost(StockName, ValueatBuy, AmountStock);
            konto.AddToStockPost(stockPosts);
        }

        konto.PrintInfo();
        konto.AddToStockPost();
    }
}


