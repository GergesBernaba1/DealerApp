using DealerPlusApp.Core.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DealerPlusApp.Data
{

    [Table("Employee")]
    public partial class Employee : AuditableEntity<long>
    {
        public Employee()
        {
            Checks = new HashSet<Check>();
            CreditDebitDatas = new HashSet<CreditDebitData>();
            ExpenseIncomes = new HashSet<ExpenseIncome>();
            MRQVSCashes = new HashSet<MRQVSCash>();
            OverheadExpenseDatas = new HashSet<OverheadExpenseData>();
            OverheadSalaries = new HashSet<OverheadSalary>();
            StoreSalaryDatas = new HashSet<StoreSalaryData>();
        }

        public int ID { get; set; }

        public int? MarketID { get; set; }

        public int? StoreID { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string SecondName { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [MaxLength(50)]
        public byte[] Password { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(10)]
        public string PhoneNumber { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsMarketManager { get; set; }

        public bool? IsStoreManager { get; set; }

        public int? CreatedUserAdminID { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(10)]
        public string ModifiedUserAdminID { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<Check> Checks { get; set; }

        public virtual ICollection<CreditDebitData> CreditDebitDatas { get; set; }

        public virtual Market Market { get; set; }

        public virtual Store Store { get; set; }

        public virtual ICollection<ExpenseIncome> ExpenseIncomes { get; set; }

        public virtual ICollection<MRQVSCash> MRQVSCashes { get; set; }

        public virtual ICollection<OverheadExpenseData> OverheadExpenseDatas { get; set; }

        public virtual ICollection<OverheadSalary> OverheadSalaries { get; set; }

        public virtual ICollection<StoreSalaryData> StoreSalaryDatas { get; set; }
    }
}
