using HomeBankingMindHub.Models;
using System;
using System.Collections.Generic;

namespace HomeBankingMinHub.Models
{
    public class Account{
        private static int InstanceCount = 0;
        public long Id { get; set; }

        public string Number { get; set; }

        public DateTime CreationDate { get; set; }

        public double Balance { get; set; }

        public Client Client { get; set; }

        public long ClientId { get; set; }
        public ICollection<Transaction> Transactions { get; set; }

        public Account()
        {
            InstanceCount++;
        }

        public static int TotalInstances
        {
            get { return InstanceCount; }
        }

    }
}
