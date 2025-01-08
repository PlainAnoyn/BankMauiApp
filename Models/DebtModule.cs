using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMauiApp.Models
{
    public class DebtModel
    {
        public DebtModel(string DebtId, string TransactionType, string DebtTitle, DateTime DebtDate,
                      string DebtSource, float DebtAmount, string TransactionFlow,
                      string DebtStatus, string TransactionStatus, string Username, string debtNote)
        {
            this.DebtId = DebtId;
            this.TransactionType = TransactionType;
            this.DebtTitle = DebtTitle;
            this.DebtDate = DebtDate;
            this.DebtSource = DebtSource;
            this.DebtAmount = DebtAmount;
            this.TransactionFlow = TransactionFlow;
            this.DebtStatus = DebtStatus;
            this.TransactionStatus = TransactionStatus;
            this.Username = Username;
            this.DebtNote = debtNote;
        }

        public string DebtId { get; set; }

        public string TransactionType { get; set; }

        public string DebtTitle { get; set; }

        public string DebtNote { get; set; }

        public DateTime DebtDate { get; set; }

        public string DebtSource { get; set; }

        public float DebtAmount { get; set; }

        public string TransactionFlow { get; set; }

        public string DebtStatus { get; set; }

        public string TransactionStatus { get; set; }

        public string Username { get; set; }
    }
}
