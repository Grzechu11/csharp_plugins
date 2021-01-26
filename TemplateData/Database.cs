using System.Collections.Generic;

namespace TemplateData
{
    public static class Database
    {
        public static IEnumerable<Users> DataUsers = new List<Users>();

        public static void InitData()
        {
            Database.DataUsers = new List<Users>
            {
                new Users{ FirstName = "C", LastName = "D" },
                new Users{ FirstName = "B", LastName = "K" },
                new Users{ FirstName = "A", LastName = "A" },
            };
        }
    }
}
