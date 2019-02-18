using System;
using Core;
using ManyConsole;

namespace ManyConsoleExample
{
    public sealed class DoubleIntegerCommand : ConsoleCommand
    {
        private int number;

        public DoubleIntegerCommand()
        {
            IsCommand("double", "Doubles an integer");
            HasRequiredOption<int>("i|int=", "The integer to double", i => number = i);
        }

        public override int Run(string[] remainingArguments)
        {
            var result = IntOperations.Double(number);
            Console.WriteLine(result);
            return 0;
        }
    }
}
