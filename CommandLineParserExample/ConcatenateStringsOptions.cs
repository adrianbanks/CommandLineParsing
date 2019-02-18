using CommandLine;

namespace CommandLineParserExample
{
    [Verb("concatenate", HelpText = "Concatenates two strings")]
    public sealed class ConcatenateStringOptions
    {
        [Option('s', "string1", HelpText = "The first string", Required = true)]
        public string Text1 { get; set; }

        [Option('t', "string2", HelpText = "The second string", Required = true)]
        public string Text2 { get; set; }
    }
}
