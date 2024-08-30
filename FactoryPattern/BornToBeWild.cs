namespace FactoryPattern;

public class BornToBeWild : IVehicle
{
    public BornToBeWild()
    {
        
    }

    public void Drive()
    {
        Console.WriteLine("Born to be wild.");
    }
}