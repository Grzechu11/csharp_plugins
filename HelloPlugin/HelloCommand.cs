using PluginBase;
using System;
using TemplateData;

namespace HelloPlugin
{
    public class HelloCommand : ICommand
    {
        public string Name { get => "hello"; }
        public string Description { get => "Displays hello message."; }

        public int Execute()
        {
            Console.WriteLine($"{nameof(HelloCommand)} Hello !!!");
            var userQ = new DataQueries();
            var fUser = userQ.GetUserFirstUser();
            Console.WriteLine($"FirstUser: {fUser.FirstName} {fUser.LastName}");
            return 0;
        }
    }
}
