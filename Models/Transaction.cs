﻿namespace BankMauiApp.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int UserId { get; set; } // Link transaction to a user
        public decimal Debit { get; set; } // Cash out
        public decimal Credit { get; set; } // Cash in
        public DateTime Date { get; set; }
        public string Description { get; set; } = string.Empty; // Initialize to avoid null references
    }
}