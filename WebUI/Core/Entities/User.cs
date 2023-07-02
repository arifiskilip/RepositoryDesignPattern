using System.Collections.Generic;

namespace WebUI.Core.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Account> Accounts { get; set; }
    }
}
