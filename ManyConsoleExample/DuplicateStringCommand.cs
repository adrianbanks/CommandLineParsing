using System;
using Core;
using ManyConsole;

namespace ManyConsoleExample
{
    public sealed class DuplicateStringCommand : ConsoleCommand
    {
        private string text;

        public DuplicateStringCommand()
        {
            IsCommand("duplicate", "Duplicates a string");
            HasRequiredOption("s|string=", "The string to duplicate", s => text = s);
        }

        public override int Run(string[] remainingArguments)
        {
            var result = StringOperations.Duplicate(text);
            Console.WriteLine(result);
            return 0;
        }
    }
}
