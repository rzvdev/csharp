using System;

namespace csharp
{
    class Utility
    {
        public void WriteColorLine(string s, string color)
        {
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color.Substring(0, 1).ToUpper() + color.Substring(1));
            Console.WriteLine(s);
            Console.ResetColor();
        }
    }
}
