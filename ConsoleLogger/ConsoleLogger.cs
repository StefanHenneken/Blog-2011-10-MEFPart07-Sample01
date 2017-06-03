using System;
using System.ComponentModel.Composition;
using Formatter;

namespace Logger
{
    [Export]
    public class ConsoleLogger
    {
        [Import]
        private Func<FormatterBase> FormatterFunc { get; set; }

        public void Log(string message)
        {
            string formattedString = FormatterFunc().Format(message);
            Console.WriteLine(formattedString);
        }
    }
}
