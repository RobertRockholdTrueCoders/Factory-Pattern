namespace FactoryPattern;

public class ThreeWheeler : IVehicle
{
    public ThreeWheeler()
    {
        
    }

    public void Drive()
    {
        Console.WriteLine("Head out on the highway.");
    }
}