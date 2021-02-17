using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private const string COMMAND_TYPE = "Command";
        public string Read(string args)
        {

            string[] input = args.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            string command = (input[0] + COMMAND_TYPE).ToLower();
            string[] arguments = input.Skip(1).ToArray();

            Assembly assembly = Assembly.GetCallingAssembly();

            Type[] allTypes = Assembly.GetCallingAssembly().GetTypes();

            Type neededType = allTypes.FirstOrDefault(x => x.Name.ToLower() == command);

            if (neededType == null)
            {
                throw new ArgumentException("Invalid command type!");
            }

            ICommand activate = (ICommand)Activator.CreateInstance(neededType);

            if (activate == null)
            {
                throw new ArgumentException("Invalid command type!");
            }

            string result = activate.Execute(arguments);

            return result;
        }
    }
}
