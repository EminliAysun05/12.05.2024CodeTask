

namespace _12._05._2024CodeTask;

public class Car: Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int MaxSpeed { get; set; }
    public Car(string color, int year, string brand, string model, int maxspeed) : base(color,year)
    {
        this.Brand = brand;
        this.Model = model;
        this.MaxSpeed = maxspeed;




    }
    public override void ShowInfo()
    {
        Console.WriteLine($"{Color},{Year},{Brand},{Model},{MaxSpeed}");
    }
    
}
