using System;
using System.Collections.Generic;
using Mono.Options;

namespace MonoOptionsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var verbosity = 0;
            var shouldShowHelp = false;
            var names = new List<string> ();
            var repeat = 1;

            var options = new OptionSet {
                { "n|name=", "the name of someone to greet.", n => names.Add (n) },
                { "r|repeat=", "the number of times to repeat the greeting.", (int r) => repeat = r },
                { "v", "increase debug message verbosity", v => { if (v != null) ++verbosity; } },
                { "h|help", "show this message and exit", h => shouldShowHelp = h != null },
            };

            try
            {
                var extra = options.Parse (args);
            }
            catch (OptionException e)
            {
                Console.Write ("greet: ");
                Console.WriteLine (e.Message);
                Console.WriteLine ("Try `greet --help' for more information.");
            }
        }
    }
}
