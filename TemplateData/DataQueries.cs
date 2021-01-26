using System;
using System.Linq;

namespace TemplateData
{
    public class DataQueries
    {
        public Users GetUserByFirstName(string firstName) => Database.DataUsers.FirstOrDefault(x => x.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));

        public virtual Users GetUserFirstUser()
        {
            return Database.DataUsers.FirstOrDefault();
        }
    }
}
