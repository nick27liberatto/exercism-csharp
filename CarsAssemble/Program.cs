static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed == 0)
        {
            return 0.0;
        } 
        else if ((speed => 1) && (speed <= 4))
        {
            return 0.100;
        } 
        else if ((speed =>5) && (speed <=8))
        {
            return 0.90;
        }
        else if (speed == 9)
        {
            return 0.80;
        } else if (speed == 10)
        {
            return 0.77;
        }
        return speed;
    }
    
    // public static double ProductionRatePerHour(int speed)
    // {
    //     throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");
    // }

    // public static int WorkingItemsPerMinute(int speed)
    // {
    //     throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
    // }
    public static void Main()
    {
        Console.WriteLine(SuccessRate(10));
    }
}
