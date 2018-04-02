
using DealerPlusApp.Core.Data;

namespace DealerPlusApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Store")]
    public partial class Store : AuditableEntity<long>
    {
        public Store()
        {
            CreditDebitDatas = new HashSet<CreditDebitData>();
            Employees = new HashSet<Employee>();
            ExpenseIncomes = new HashSet<ExpenseIncome>();
            ProfitAndLoseAllDatas = new HashSet<ProfitAndLoseAllData>();
            StoreSalaryDatas = new HashSet<StoreSalaryData>();
            SummaryDatas = new HashSet<SummaryData>();
        }

        public int ID { get; set; }

        public int? MarketID { get; set; }

        [StringLength(50)]
        public string StoreName { get; set; }

        [StringLength(100)]
        public string StoreAddress { get; set; }

        [StringLength(10)]
        public string PhoneNumber { get; set; }

        public bool? IsDeleted { get; set; }

        public int? CreatedUserAdminID { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? ModifiedUserAdminID { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<CreditDebitData> CreditDebitDatas { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

        public virtual ICollection<ExpenseIncome> ExpenseIncomes { get; set; }

        public virtual Market Market { get; set; }

        public virtual ICollection<ProfitAndLoseAllData> ProfitAndLoseAllDatas { get; set; }

        public virtual ICollection<StoreSalaryData> StoreSalaryDatas { get; set; }

        public virtual ICollection<SummaryData> SummaryDatas { get; set; }
    }
}
