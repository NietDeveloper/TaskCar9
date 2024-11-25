namespace TaskCar9
{
    public class Program
    {
        static void Main()
        {
            Car car = new Car("Nexia3", 2023, 13500, 25000);
            car.Model = "Tracker";
            car.Year = 2024;
            car.Price = 20000;
            car.Speed = 7000;
            decimal diference = car.CalculateDepreciation(5);
            System.Console.WriteLine(car.GetCarinfo());
            System.Console.WriteLine($"5 yildan keying narxi:{diference}");
        }
    }
}