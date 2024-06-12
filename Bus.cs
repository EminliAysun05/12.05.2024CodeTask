

namespace _12._05._2024CodeTask;

public class Bus: Vehicle
{
    public int PassengerCount { get; set; }
    public Bus(int passengercount, string color, int year): base(color,year)
    {
        this.PassengerCount = passengercount;
    }
    public override void ShowInfo()
    {
        Console.WriteLine($"{PassengerCount},{Color},{Year}");
    }
}
