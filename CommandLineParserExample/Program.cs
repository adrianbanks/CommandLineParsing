using System;
using CommandLine;
using Core;

namespace CommandLineParserExample
{
    class Program
    {
        static int Main(string[] args)
        {
            return Parser.Default.ParseArguments<
                    AddIntegersOptions,
                    ConcatenateStringOptions,
                    DoubleIntegerOptions,
                    DuplicateStringOptions,
                    JoinStringsOptions,
                    ReverseStringOptions
                >(args)
                .MapResult(
                    (AddIntegersOptions options) => RunAndReturnErrorCode(options),
                    (ConcatenateStringOptions options) => RunAndReturnErrorCode(options),
                    (DoubleIntegerOptions options) => RunAndReturnErrorCode(options),
                    (DuplicateStringOptions options) => RunAndReturnErrorCode(options),
                    (JoinStringsOptions options) => RunAndReturnErrorCode(options),
                    (ReverseStringOptions options) => RunAndReturnErrorCode(options),
                    errors => 1
                );
        }

        private static int RunAndReturnErrorCode(AddIntegersOptions options)
        {
            var result = IntOperations.Add(options.Number1, options.Number2);
            Console.WriteLine(result);
            return 0;
        }

        private static int RunAndReturnErrorCode(ConcatenateStringOptions options)
        {
            var result = StringOperations.Concat(options.Text1, options.Text2);
            Console.WriteLine(result);
            return 0;
        }

        private static int RunAndReturnErrorCode(DoubleIntegerOptions options)
        {
            var result = IntOperations.Double(options.Number);
            Console.WriteLine(result);
            return 0;
        }

        private static int RunAndReturnErrorCode(DuplicateStringOptions options)
        {
            var result = StringOperations.Duplicate(options.Text);
            Console.WriteLine(result);
            return 0;
        }

        private static int RunAndReturnErrorCode(JoinStringsOptions options)
        {
            var result = StringOperations.Join(options.Strings);
            Console.WriteLine(result);
            return 0;
        }

        private static int RunAndReturnErrorCode(ReverseStringOptions options)
        {
            var result = StringOperations.Reverse(options.Text);
            Console.WriteLine(result);
            return 0;
        }
    }
}
