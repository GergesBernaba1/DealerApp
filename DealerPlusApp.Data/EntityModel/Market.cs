

namespace DealerPlusApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using DealerPlusApp.Core.Data;


    [Table("Market")]
    public partial class Market : AuditableEntity<long>
    {
        public Market()
        {
            Checks = new HashSet<Check>();
            CreditDebits = new HashSet<CreditDebit>();
            Employees = new HashSet<Employee>();
            ExpenseIncomes = new HashSet<ExpenseIncome>();
            MRQVSCashes = new HashSet<MRQVSCash>();
            OverheadExpenses = new HashSet<OverheadExpense>();
            ProfitAndLoseAlls = new HashSet<ProfitAndLoseAll>();
            Stores = new HashSet<Store>();
            StoreSalaries = new HashSet<StoreSalary>();
            Summaries = new HashSet<Summary>();
        }

        public int ID { get; set; }

        public int? UserAdminID { get; set; }

        [StringLength(100)]
        public string MarketName { get; set; }

        [StringLength(200)]
        public string MarketAddess { get; set; }

        [StringLength(10)]
        public string PhoneNumber { get; set; }

        [StringLength(50)]
        public string StoreCount { get; set; }

        public bool? IsDeleted { get; set; }

        public int? CreatedUserAdminID { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? ModifiedUserAdminID { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<Check> Checks { get; set; }

        public virtual ICollection<CreditDebit> CreditDebits { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

        public virtual ICollection<ExpenseIncome> ExpenseIncomes { get; set; }

        public virtual UsersAdmin UsersAdmin { get; set; }

        public virtual ICollection<MRQVSCash> MRQVSCashes { get; set; }

        public virtual ICollection<OverheadExpense> OverheadExpenses { get; set; }

        public virtual ICollection<ProfitAndLoseAll> ProfitAndLoseAlls { get; set; }

        public virtual ICollection<Store> Stores { get; set; }

        public virtual ICollection<StoreSalary> StoreSalaries { get; set; }

        public virtual ICollection<Summary> Summaries { get; set; }
    }
}
