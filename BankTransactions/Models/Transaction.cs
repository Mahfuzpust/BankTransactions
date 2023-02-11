using System.ComponentModel.DataAnnotations;

namespace BankTransactions.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        public string AccountNumber { get; set; }
        public string BeneficiaryName { get; set; }
        public string BankName { get; set; }
        public string SWIFTName { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
