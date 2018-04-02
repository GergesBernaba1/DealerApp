namespace DealerPlusApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OverheadExpenseData")]
    public partial class OverheadExpenseData
    {
        public int ID { get; set; }

        public int? OHExpenseID { get; set; }

        public int? EmployeeID { get; set; }

        public decimal? Value { get; set; }

        [StringLength(100)]
        public string Comment { get; set; }

        public DateTime? InitalDate { get; set; }

        public int? CreatedUserAdminID { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(10)]
        public string ModifiedUserAdminID { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual OverheadExpense OverheadExpense { get; set; }
    }
}
