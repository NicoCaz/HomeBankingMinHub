
using System;

namespace HomeBankingMindHub.Models
{
    public class Card
    {
        public long Id { get; set; }
        public string CardHolder { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public string Number { get; set; }
        public int Cvv { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ThruDate { get; set; }
        public long ClientId { get; set; }

        public static string GenerateRandomCardNumber()
        {
            Random random = new Random();
            string cardNumber = "";

            for (int i = 0; i < 16; i++)
            {
                cardNumber += random.Next(0, 10);

                if (i < 15 && (i + 1) % 4 == 0)
                {
                    cardNumber += "-";
                }
            }
            return cardNumber;
        }
    }
}

