using System;

public class Bankkonto
{
    // Attribut
    private string Owner;
    private double Saldo;
    private int AccountNumber;
    private string Stock;
    private double Savings;

    // Konstruktor
    public Bankkonto(string owner, double saldo, int accountNumber, double Saves)
    {
        this.Owner = owner;
        this.Saldo = saldo;
        this.AccountNumber = accountNumber;
        this.Stock = " ";
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
    public void StockSaves(string stock)
    {
        this.Stock = stock;
        Console.WriteLine($"Vald Aktie: {stock}");
        Console.WriteLine("-----------------------------\n");
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
}
