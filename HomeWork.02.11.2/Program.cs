using System;

class Program
{
    static void Main(string[] args)
    {
        Passport passport = new Passport(123, "John Doe", "USA", 98765);
        passport.ShowPassport();
        System.Console.WriteLine();
        ForeignPassport foreignPassport = new ForeignPassport(456, "Alice Smith", "UK", 54321);
        foreignPassport.ShowPassport();
    }
}

class Passport
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Country { get; private set; }
    public int Inn { get; private set; }

    public Passport(int id, string name, string country, int inn)
    {
        Id = id;
        Name = name;
        Country = country;
        Inn = inn;
    }

    public virtual void ShowPassport()
    {
        Console.WriteLine($"Passport name: {Name}");
        Console.WriteLine($"Passport ID: {Id}");
        Console.WriteLine($"Passport country: {Country}");
        Console.WriteLine($"Passport INN: {Inn}");
    }
}

class ForeignPassport : Passport
{
    public ForeignPassport(int id, string name, string country, int inn) : base(id, name, country, inn) { }

    public override void ShowPassport()
    {
        Console.WriteLine($"Foreign Passport name: {Name}");
        Console.WriteLine($"Foreign Passport ID: {Id}");
        Console.WriteLine($"Foreign Passport country: {Country}");
        Console.WriteLine($"Foreign Passport INN: {Inn}");
    }
}