public class Car
{
    private string? _model;
    private int _year;
    private decimal _price;
    private decimal _speed;

    public string? Model { get; set; }
    public int Year { get; set; }
    public decimal Price { get; set; }
    public decimal Speed { get; set; }

    public Car(string model, int year, decimal price, decimal speed)
    {
        Model = model;
        Year = year;
        Price = price;
        Speed = speed;
    }
    public string GetCarinfo()
    {
        return $"Model:{Model}, Year:{Year}, Price:{Price}$, Speed:{Speed} km";
    }
    public decimal CalculateDepreciation(int years)
    {
        decimal Procent = 0.1m;
        decimal nowPrice = Price*(decimal)Math.Pow((double)(1-Procent), years);
        return nowPrice;
    }
}