using CommandLine;

namespace CommandLineParserExample
{
    [Verb("add", HelpText = "Adds two integers")]
    public sealed class AddIntegersOptions
    {
        [Option('i', "int1", HelpText = "The first integer to sum", Required = true)]
        public int Number1{ get; set; }

        [Option('j', "int2", HelpText = "The second integer to sum", Required = true)]
        public int Number2{ get; set; }
    }
}
