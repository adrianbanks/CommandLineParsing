using System.Collections.Generic;
using CommandLine;

namespace CommandLineParserExample
{
    [Verb("join", HelpText = "Joins multiple strings")]
    public sealed class JoinStringsOptions
    {
        [Option('s', "strings", HelpText = "The strings to join")]
        public IEnumerable<string> Strings{ get; set; }
    }
}
