using System;
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
                var number1 = addCommand.Option<int>("-i1|--int1", "The first integer to sum", CommandOptionType.SingleValue).IsRequired();
                var number2 = addCommand.Option<int>("-i2|--int2", "The second integer to sum", CommandOptionType.SingleValue).IsRequired();

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
                var text1 = concatenateCommand.Option("-s1|--string1", "The first string", CommandOptionType.SingleValue).IsRequired();
                var text2 = concatenateCommand.Option("-s2|--string2", "The second string", CommandOptionType.SingleValue).IsRequired();

                concatenateCommand.OnExecute(() =>
                {
                    var result = StringOperations.Concat(text1.Value(), text2.Value());
                    Console.WriteLine(result);
                    return 0;
                });
            });

            app.Command("double", doubleCommand =>
            {
                doubleCommand.Description = "Doubles an integer";
                var number = doubleCommand.Option<int>("-i|--int", "The integer to double", CommandOptionType.SingleValue).IsRequired();

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
                var text = duplicateCommand.Option("-s|--string", "The string to duplicate", CommandOptionType.SingleValue).IsRequired();

                duplicateCommand.OnExecute(() =>
                {
                    var result = StringOperations.Duplicate(text.Value());
                    Console.WriteLine(result);
                    return 0;
                });
            });

            app.Command("join", joinCommand =>
            {
                joinCommand.Description = "Joins multiple strings";
                var strings = joinCommand.Option("-s|--strings", "The strings to join", CommandOptionType.MultipleValue).IsRequired();

                joinCommand.OnExecute(() =>
                {
                    var result = StringOperations.Join(strings.Values);
                    Console.WriteLine(result);
                    return 0;
                });
            });

            app.Command("reverse", reverseCommand =>
            {
                reverseCommand.Description = "Reverses a string";
                var text = reverseCommand.Option("-s|--string", "The string to reverse", CommandOptionType.SingleValue).IsRequired();

                reverseCommand.OnExecute(() =>
                {
                    var result = StringOperations.Reverse(text.Value());
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
