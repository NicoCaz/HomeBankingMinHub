﻿using HomeBankingMinHub.Models;
using System;
using System.Text.Json.Serialization;

namespace HomeBankingMindHub.Models
{
    public class TransactionDTO
    {
        [JsonIgnore]

        public long Id { get; set; }
        public string Type { get; set; }
        public double Amount { get; set; }
        public String Description { get; set; }
        public DateTime Date { get; set; }
        public Account Account { get; set; }

    }
}