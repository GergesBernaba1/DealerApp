namespace DealerPlusApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CreditDebitData")]
    public partial class CreditDebitData
    {
        public int ID { get; set; }

        public int? CreditDebitID { get; set; }

        public int? StoreID { get; set; }

        public int? EmplyeeID { get; set; }

        public decimal? Value { get; set; }

        [StringLength(100)]
        public string Comment { get; set; }

        public DateTime? InitalDate { get; set; }

        public int? CreatedUserAdminID { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? ModifiedUserAdminID { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual CreditDebit CreditDebit { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Store Store { get; set; }
    }
}
