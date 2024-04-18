using System;

    // Klassen för Aktiepost
public class StockPost
{
    private string stockName;
    private int valueOnBuy;
    private int value;
    private int dateForBuy;
    private int amountStock;

    // Konstruktor för Aktiepost

    public StockPost(string stockName, int valueOnBuy, int amountStock)
    {
        this.stockName = stockName;
        this.valueOnBuy = valueOnBuy;
        this.amountStock = amountStock;
        this.value = 0;
        // Skapar en slumpmässig generator
        Random random = new Random();
        // Räknar ut ett slumpmässigt värde på det totala värdet på varje aktie
        double changePercentage = (random.NextDouble() *20) -10;
        double changeFactor = 1 + (changePercentage / 100);
        this.value = (int)(valueOnBuy * changeFactor);
        // Slumpar ut ett datum mellan 1-31
        this.dateForBuy = random.Next(1, 31);

    }
    public override string ToString()
    {
        return $"Aktie: {stockName}, Värde vid köp: {valueOnBuy}, Aktuellt värde: {value}, Antal aktier: {amountStock}, Dags datum för köp: {dateForBuy}";
    }
}


public class Bankkonto
{
    // Attribut
    private string owner;
    private double saldo;
    private int accountNumber;
    private List<StockPost> stockposts; 
    private double savings;

    // Konstruktor
    public Bankkonto(string owner, double saldo, int accountNumber, double savings )
    {
        this.owner = owner;
        this.saldo = saldo;
        this.accountNumber = accountNumber;
        this.stockposts = new List<StockPost>();
        this.savings = savings;
        Console.WriteLine("-----------------------------\n");
    }

    // Metod för att sätta in pengar
    public void CashIn(double cash)
    {
        this.saldo += cash;
        Console.WriteLine($"{cash}Kr har satts in på kontot!");
        Console.WriteLine("-----------------------------\n");
    }

    // Metod för att ta ut pengar
    public void CashOut(double cash)
    {
        if (cash <= this.saldo)
        {
            this.saldo -= cash;
            Console.WriteLine($"{cash}Kr har tagits ut från kontot");
            Console.WriteLine("-----------------------------\n");
        }
        else
        {
            Console.WriteLine("Otillräckligt saldo för att göra uttag!!");
            Console.WriteLine("-----------------------------\n");
        }
    }

    /*
    // Metod för att sätta in månadssparande 
    public void MontlySavings(double Saves)
    {
        this.Savings = Saves;
        Console.WriteLine($"Månadssparande {Savings}Kr");
        Console.WriteLine("-----------------------------\n");

    }*/
    public void AddToStockPost(StockPost stockPost)
    {
        stockposts.Add(stockPost);
    }
    public void PrintStockPosts()
    {
        Console.WriteLine($"\nAktiePoster för {owner}");
        foreach (var stockPost in stockposts)
        {
            Console.WriteLine(stockPost.ToString());
        }
    }

    // Metod för att skriva ut Bankinfo
    public void PrintInfo()
    {
        Console.WriteLine($"\nKontos Ägare: {this.owner}");
        Console.WriteLine($"Saldo: {this.saldo}");
        Console.WriteLine($"KontoNrummer: {this.accountNumber}");
        //Console.WriteLine($"Månadssparande: {this.savings}");
        

    }
    /*public void PrintStockInfo()
    {
        Console.WriteLine($"StockPost för {Owner}:");
        foreach (var stockPosts in StockPost)
        {
            Console.WriteLine(stockPosts.ToString());
        }
    }*/
}
