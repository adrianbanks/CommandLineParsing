using System;
using System.Collections;
using System.Collections.Generic;
using Core;
using McMaster.Extensions.CommandLineUtils;

namespace CommandLineUtilsExamples
{
    class Program
    {
        static int Main(string[] args)
        {
            var app = new CommandLineApplication();
            app.HelpOption(inherited: true);

            app.Command("add", addCommand =>
            {
                addCommand.Description = "Adds two integers";
                var number1 = addCommand.Argument<int>("int1", "The first integer to sum").IsRequired();
                var number2 = addCommand.Argument<int>("int2", "The second integer to sum").IsRequired();

                addCommand.OnExecute(() =>
                {
                    var result = IntOperations.Add(number1.ParsedValue, number2.ParsedValue);
                    Console.WriteLine(result);
                    return 0;
                });
            });

            app.Command("concatenate", concatenateCommand =>
            {
                concatenateCommand.Description = "Concatenates two strings";
                var text1 = concatenateCommand.Argument("string1", "The first string").IsRequired();
                var text2 = concatenateCommand.Argument("string2", "The second string").IsRequired();

                concatenateCommand.OnExecute(() =>
                {
                    var result = StringOperations.Concat(text1.Value, text2.Value);
                    Console.WriteLine(result);
                    return 0;
                });
            });

            app.Command("double", doubleCommand =>
            {
                doubleCommand.Description = "Doubles an integer";
                var number = doubleCommand.Argument<int>("int", "The integer to double").IsRequired();

                doubleCommand.OnExecute(() =>
                {
                    var result = IntOperations.Double(number.ParsedValue);
                    Console.WriteLine(result);
                    return 0;
                });
            });

            app.Command("duplicate", duplicateCommand =>
            {
                duplicateCommand.Description = "Duplicates a string";
                var text = duplicateCommand.Argument("string", "The string to duplicate").IsRequired();

                duplicateCommand.OnExecute(() =>
                {
                    var result = StringOperations.Duplicate(text.Value);
                    Console.WriteLine(result);
                    return 0;
                });
            });

            app.Command("join", joinCommand =>
            {
                joinCommand.Description = "Joins multiple strings";
                // TODO: how to make this work?
                var strings = joinCommand.Argument<IEnumerable<string>>("strings", "The strings to join").IsRequired();

                joinCommand.OnExecute(() =>
                {
                    var result = StringOperations.Join(strings.ParsedValue);
                    Console.WriteLine(result);
                    return 0;
                });
            });

            app.Command("reverse", reverseCommand =>
            {
                reverseCommand.Description = "Reverses a string";
                var text = reverseCommand.Argument("string", "The string to reverse").IsRequired();

                reverseCommand.OnExecute(() =>
                {
                    var result = StringOperations.Reverse(text.Value);
                    Console.WriteLine(result);
                    return 0;
                });
            });

            app.OnExecute(() =>
            {
                app.ShowHelp();
                return 1;
            });

            return app.Execute(args);
        }
    }
}
