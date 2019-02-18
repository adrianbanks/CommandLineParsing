using System;
using Core;
using ManyConsole;

namespace ManyConsoleExample
{
    public sealed class ReverseStringCommand : ConsoleCommand
    {
        private string text;

        public ReverseStringCommand()
        {
            IsCommand("reverse", "Reverses a string");
            HasRequiredOption("s|string=", "The string to reverse", s => text = s);
        }

        public override int Run(string[] remainingArguments)
        {
            var result = StringOperations.Reverse(text);
            Console.WriteLine(result);
            return 0;
        }
    }
}
