using Autofac;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolName.Command;
using ToolName.Contract;
using ToolName.Properties;

namespace ToolName
{
    class Program
    {
        private static readonly string[] _commandList = new string[]
        {
            "all",
            "cpp",
            "reversed1",
            "reversed2"
        };

        private static IContainer Container { get; set; }

        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Help();
            }

            if (!Directory.Exists(args[0]))
            {
                IncorectPath();
            }
            if (args.Length < 2 || !_commandList.Contains(args[1].ToLower()))
            {
                IncorectCommand();
            }

            string startDirectory = Path.GetFullPath(args[0]);
            string commandName = args[1].ToLower();
            string outputFile = (args.Length > 2) ? args[2] : "results.txt";

            ContainerSetup();

            var command = Container.ResolveNamed<ICommand>(commandName);
            var result = command.Execute(startDirectory).ToList();

            var saver = Container.Resolve<ISaveService>();
            saver.SaveResult(result, outputFile);
        }

        private static void ContainerSetup()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<FileService>().As<IFileService>();
            builder.RegisterType<DiskSaveService>().As<ISaveService>();

            builder.RegisterType<CppCommand>().Named<ICommand>("cpp");
            builder.RegisterType<AllCommand>().Named<ICommand>("all");
            builder.RegisterType<Reversed1Command>().Named<ICommand>("reversed1");
            builder.RegisterType<Reversed2Command>().Named<ICommand>("reversed2");

            Container = builder.Build();
        }

        private static void IncorectCommand()
        {
            Console.WriteLine(Resources.IncorrectCommand);
            Help();
        }

        private static void IncorectPath()
        {
            Console.WriteLine(Resources.IncorrectStartPath);
            Help();
        }

        private static void Help()
        {
            Console.WriteLine("ToolName START_DIR <"+ string.Join("|", _commandList) + "> [OUTPUT_File]");
            Exit();
        }

        private static void Exit()
        {
            Environment.Exit(0);
        }
    }
}
