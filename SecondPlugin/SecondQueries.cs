using System.Linq;
using TemplateData;

namespace SecondPlugin
{
    public class SecondQueries : DataQueries
    {
        public override Users GetUserFirstUser()
        {
            return Database.DataUsers.LastOrDefault();
        }
    }
}
