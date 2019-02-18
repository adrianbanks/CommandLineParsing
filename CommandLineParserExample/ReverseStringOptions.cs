using CommandLine;

namespace CommandLineParserExample
{
    [Verb("reverse", HelpText = "Reverses a string")]
    public sealed class ReverseStringOptions
    {
        [Option('s', "string", HelpText = "The string to reverse", Required = true)]
        public string Text { get; set; }
    }
}
