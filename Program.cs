

namespace _12._05._2024CodeTask;

public class Program
{
    static void Main(string[] args)
    {
        Vehicle[] Vehicles = new Vehicle[2];
        Vehicles[0] = new Car("Blue", 2019, "Corolla","toyota",180);
        Vehicles[1] = new Bus(5,"red",1989);
        foreach (var v in Vehicles) {
            v.ShowInfo();
        }
        
    }
}
