using System;
using Core;
using ManyConsole;

namespace ManyConsoleExample
{
    public sealed class AddIntegersCommand : ConsoleCommand
    {
        private int number1;
        private int number2;

        public AddIntegersCommand()
        {
            IsCommand("add", "Adds two integers");
            HasRequiredOption<int>("i1|int1=", "The first integer to sum", i => number1 = i);
            HasRequiredOption<int>("i2|int2=", "The second integer to sum", i => number2 = i);
        }

        public override int Run(string[] remainingArguments)
        {
            var result = IntOperations.Add(number1, number2);
            Console.WriteLine(result);
            return 0;
        }
    }
}
