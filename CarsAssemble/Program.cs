static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        double ratio = 0.0;
        if (speed == 0)
        {
            return ratio;
        } 
        else if ((speed > 0) && (speed <= 4))
        {
            ratio = 1;
        } 
        else if ((speed >4 ) && (speed <=8))
        {
            ratio = 0.90;
        }
        else if (speed == 9)
        {
            ratio = 0.80;
        } else if (speed == 10)
        {
            ratio = 0.77;
        }
        return ratio;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        double ratio = SuccessRate(speed);
        double rate = speed * 221;
        return ratio * rate;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        double result = ProductionRatePerHour(speed);
        return (int)(result / 60);
    }
    public static void Main()
    {
        Console.WriteLine(WorkingItemsPerMinute(6));
    }
}
