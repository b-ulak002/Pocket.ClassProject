using System;
using System.ComponentModel.DataAnnotations;

namespace Pocket.ClassProject.Statement
{
    public class Statement
    {
        public int ID { get; set; }

        public string Company { get; set; }

        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }

        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }

        [EnumDataType(typeof(StatementCategory))]
        public StatementCategory Category { get; set; }

        [EnumDataType(typeof(BalanceStatus))]
        public BalanceStatus Status { get; set; }
    }
}