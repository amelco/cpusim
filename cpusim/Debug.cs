namespace cpusim
{
    public static class Debug
    {
        public static ConsoleColor defaultForeGrundColor = Console.ForegroundColor;
        public static ConsoleColor debugForeGrundColor = ConsoleColor.DarkGray;

        public static void Info(bool isDebugging, string message)
        {
            if (isDebugging)
            {
                Console.ForegroundColor = debugForeGrundColor;
                Console.WriteLine(message);
                Console.ForegroundColor = defaultForeGrundColor;
            }
        }
    }
}
