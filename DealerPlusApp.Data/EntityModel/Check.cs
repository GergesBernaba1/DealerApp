namespace DealerPlusApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Check")]
    public partial class Check
    {
        public int ID { get; set; }

        public int? MarketID { get; set; }

        public int? Employee { get; set; }

        [StringLength(100)]
        public string CheckType { get; set; }

        public decimal? Value { get; set; }

        [StringLength(100)]
        public string Comment { get; set; }

        public int? CreatedUserAdminID { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? ModifiedUserAdminID { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual Employee Employee1 { get; set; }

        public virtual Market Market { get; set; }
    }
}
