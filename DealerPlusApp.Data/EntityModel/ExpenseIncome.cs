namespace DealerPlusApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExpenseIncome")]
    public partial class ExpenseIncome
    {
        public ExpenseIncome()
        {
            ExpenseIncomeDatas = new HashSet<ExpenseIncomeData>();
        }

        public int ID { get; set; }

        public int? EmployeeID { get; set; }

        public int? MarketID { get; set; }

        public int? StoreID { get; set; }

        [StringLength(1)]
        public string Type { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public decimal? DefualtValue { get; set; }

        public bool? ChangeEveryMonth { get; set; }

        public bool? FixedValue { get; set; }

        public bool? IsDeleted { get; set; }

        public int? CreatedUserAdminID { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? ModifiedUserAdminID { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Market Market { get; set; }

        public virtual Store Store { get; set; }

        public virtual ICollection<ExpenseIncomeData> ExpenseIncomeDatas { get; set; }
    }
}
