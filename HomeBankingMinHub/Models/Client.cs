using System.Collections.Generic;
using System.Security.Principal;
using HomeBankingMinHub.Models;

namespace HomeBankingMindHub.Models
{
    public class Client

    {
        private static int InstanceCount = 0;
        public long Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public ICollection<Account> Accounts { get; set; }

        public Client()
        {
            InstanceCount++;
        }

        public static int TotalInstances
        {
            get { return InstanceCount; }
        }
    }

}




