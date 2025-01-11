﻿namespace BankMauiApp.Models
{
    public class AppData
    {
        public List<User> Users { get; set; } = new List<User>();
        public List<Debt> Debts { get; set; } = new List<Debt>();
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}