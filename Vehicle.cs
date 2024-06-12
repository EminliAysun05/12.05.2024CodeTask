

namespace _12._05._2024CodeTask;

public abstract class Vehicle
{
    public string Color { get; set; }
    public int Year { get; set; }
    public abstract void ShowInfo();
    public Vehicle(string color, int year)
    {
        this.Color = color;
        this.Year = year;

    }
    

}
