using CommandLine;

namespace CommandLineParserExample
{
    [Verb("double", HelpText = "Doubles an integer")]
    public sealed class DoubleIntegerOptions
    {
        [Option('i', "int", HelpText = "The integer to double", Required = true)]
        public int Number{ get; set; }
    }
}
