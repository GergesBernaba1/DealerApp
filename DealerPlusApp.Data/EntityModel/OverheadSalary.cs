namespace DealerPlusApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OverheadSalary")]
    public partial class OverheadSalary
    {
        public int ID { get; set; }

        public int? EmployeeID { get; set; }

        public int? MarketID { get; set; }

        public decimal? Value { get; set; }

        public DateTime? InitalDate { get; set; }

        [StringLength(100)]
        public string Comment { get; set; }

        public int? CreatedUserAdminID { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? ModifiedUserAdminID { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
