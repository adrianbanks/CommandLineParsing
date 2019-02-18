using CommandLine;

namespace CommandLineParserExample
{
    [Verb("duplicate", HelpText = "Duplicates a string")]
    public sealed class DuplicateStringOptions
    {
        [Option('s', "string", HelpText = "The string to duplicate", Required = true)]
        public string Text { get; set; }
    }
}
