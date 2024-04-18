using System;
using System.Collections.Generic;

    // Klassen för Aktiepost
public class StockPost
{
    private string StockName;
    private int ValueOnBuy;
    private int Value;
    private int DateForBuy;
    private int AmountStock;

    // Konstruktor för Aktiepost

    public StockPost(string stockname, int valueonbuy, int amountastock)
    {
        StockName = stockname;
        ValueOnBuy = valueonbuy;
        AmountStock = amountastock;
        Value = 0;
        DateForBuy = 0;

    }
    public override string ToString()
    {
        return $"Aktie: {StockName}, Värde vid köp: {ValueOnBuy}, Aktuellt värde: {Value}, Antal aktier: {AmountStock}";
    }
}


public class Bankkonto
{
    // Attribut
    private string Owner;
    private double Saldo;
    private int AccountNumber;
    private List<StockPost> Stockposts; 
    private double Savings;

    // Konstruktor
    public Bankkonto(string owner, double saldo, int accountNumber, double Saves )
    {
        this.Owner = owner;
        this.Saldo = saldo;
        this.AccountNumber = accountNumber;
        this.Stockposts = new List<StockPost>();
        this.Savings = Saves;
        Console.WriteLine("-----------------------------\n");
    }

    // Metod för att sätta in pengar
    public void CashIn(double cash)
    {
        this.Saldo += cash;
        Console.WriteLine($"{cash}Kr har satts in på kontot!");
        Console.WriteLine("-----------------------------\n");
    }

    // Metod för att ta ut pengar
    public void CashOut(double cash)
    {
        if (cash <= this.Saldo)
        {
            this.Saldo -= cash;
            Console.WriteLine($"{cash}Kr har tagits ut från kontot");
            Console.WriteLine("-----------------------------\n");
        }
        else
        {
            Console.WriteLine("Otillräckligt saldo för att göra uttag!!");
            Console.WriteLine("-----------------------------\n");
        }
    }

    // Metod för att sätta in månadssparande 
    public void MontlySavings(double Saves)
    {
        this.Savings = Saves;
        Console.WriteLine($"Månadssparande {Savings}Kr");
        Console.WriteLine("-----------------------------\n");

    }
    public void AddToStockPost(StockPost stockPosts)
    {
        StockPost.Add(stockPosts);
        Console.WriteLine("-----------------------------\n");
    }
    public void PrintStockPosts()
    {
        Console.WriteLine($"\nAktiePoster för {Owner}");
    }

    // Metod för att skriva ut Bankinfo
    public void PrintInfo()
    {
        Console.WriteLine($"\nKontos Ägare: {this.Owner}");
        Console.WriteLine($"Saldo: {this.Saldo}");
        Console.WriteLine($"KontoNrummer: {this.AccountNumber}");
        Console.WriteLine($"Månadssparande: {this.Savings}");
        Console.WriteLine($"Aktie: {this.Stock}");

    }
    public void PrintStockInfo()
    {
        Console.WriteLine($"StockPost för {Owner}:");
        foreach (var stockPosts in StockPost)
        {
            Console.WriteLine(stockPosts.ToString());
        }
    }
}
