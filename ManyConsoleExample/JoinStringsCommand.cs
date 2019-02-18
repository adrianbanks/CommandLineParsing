using System;
using Core;
using ManyConsole;

namespace ManyConsoleExample
{
    public sealed class JoinStringsCommand : ConsoleCommand
    {
        public JoinStringsCommand()
        {
            IsCommand("join", "Joins multiple strings");
            AllowsAnyAdditionalArguments(" <string1> <string2> ... <stringN>");
        }

        public override int Run(string[] remainingArguments)
        {
            var result = StringOperations.Join(remainingArguments);
            Console.WriteLine(result);
            return 0;
        }
    }
}
