static class LogLine
{
    public static string Message(string logLine)
    {
        var levels = new List<string> { "[ERROR]: ", "[WARNING]: ", "[INFO]: " };
        foreach (string level in levels)
        {
            if(logLine.Contains(level))
            {
                string logFiltered = logLine.Replace(level, "");
                return logFiltered.Trim();
            }
        }
    return logLine;
    }

    public static string LogLevel(string logLine)
    {
        var levels = new List<string> { "[ERROR]: ", "[WARNING]: ", "[INFO]: " };
        foreach (string level in levels)
        {
            if(logLine.Contains(level))
            {
                return level.Trim('[', ']', ':', ' ').ToLower();
            }
        }
    return logLine;
    }

    public static string Reformat(string logLine)
    {
        string message = Message(logLine);
        string level = LogLevel(logLine);
        string format = $"{message} ({level})";
        return format;
    }
    public static void Main()
    {
        Console.WriteLine(Reformat("[ERROR]: Invalid operation"));
        Console.WriteLine(Reformat("[WARNING]:  Disk almost full\r\n"));
        Console.WriteLine(Reformat("[INFO]: Operation completed"));

    }
}
