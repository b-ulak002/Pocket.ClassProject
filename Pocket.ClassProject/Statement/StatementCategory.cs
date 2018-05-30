using System.ComponentModel.DataAnnotations;

namespace Pocket.ClassProject.Statement
{
    public enum StatementCategory
    {
        Home,
        Auto,
        Insurance,

        [Display(Name = "Credit Card")]
        CreditCard,
        Utility,
        Education,
        Maintenance
    }
}