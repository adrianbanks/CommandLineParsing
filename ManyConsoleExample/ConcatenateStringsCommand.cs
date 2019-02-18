using System;
using Core;
using ManyConsole;

namespace ManyConsoleExample
{
    public sealed class ConcatenateStringsCommand : ConsoleCommand
    {
        private string text1;
        private string text2;

        public ConcatenateStringsCommand()
        {
            IsCommand("concatenate", "Concatenates two strings");
            HasRequiredOption("s1|string1=", "The first string", s => text1 = s);
            HasRequiredOption("s2|string2=", "The second string", s => text2 = s);
        }

        public override int Run(string[] remainingArguments)
        {
            var result = StringOperations.Concat(text1, text2);
            Console.WriteLine(result);
            return 0;
        }
    }
}
