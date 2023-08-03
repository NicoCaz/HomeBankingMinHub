using System.Collections.Generic;
using System.Security.Principal;
using HomeBankingMindHub.dtos;
using HomeBankingMindHub.Models;

namespace HomeBankingMindHub.Models
{
    public class ClientLoan
    {
        public long Id { get; set; }
        public double Amount { get; set; }
        public string Payments { get; set; }
        public long ClientId { get; set; }
        public Client Client { get; set; }
        public long LoanId { get; set; }
        public Loan Loan { get; set; }

    }
}




