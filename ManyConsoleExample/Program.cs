using System;
using ManyConsole;

namespace ManyConsoleExample
{
    class Program
    {
        static int Main(string[] args)
        {
            var commands = ConsoleCommandDispatcher.FindCommandsInAllLoadedAssemblies();
            var exitCode = ConsoleCommandDispatcher.DispatchCommand(commands, args, Console.Out);
           return exitCode;
        }
    }
}
