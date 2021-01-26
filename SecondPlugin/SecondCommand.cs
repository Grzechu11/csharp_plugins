using PluginBase;
using System;

namespace SecondPlugin
{
    public class SecondCommand : ICommand
    {
        public string Name { get => "Second"; }
        public string Description { get => "Displays Second message."; }

        public int Execute()
        {
            Console.WriteLine($"{nameof(SecondCommand)} Hello !!!");
            var userQ = new SecondQueries();
            var fUser = userQ.GetUserFirstUser();
            Console.WriteLine($"FirstUser: {fUser.FirstName} {fUser.LastName}");
            return 0;
        }
    }
}
