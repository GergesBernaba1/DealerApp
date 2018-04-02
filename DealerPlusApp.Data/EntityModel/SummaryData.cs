namespace DealerPlusApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SummaryData")]
    public partial class SummaryData
    {
        public int ID { get; set; }

        public int? EmployeeID { get; set; }

        public int? SummaryID { get; set; }

        public int? StoreID { get; set; }

        public decimal? Value { get; set; }

        public DateTime? InitialDate { get; set; }

        [StringLength(100)]
        public string Comment { get; set; }

        public int? CreatedUserAdminID { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? ModifiedUserAdminID { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual Store Store { get; set; }

        public virtual Summary Summary { get; set; }
    }
}
