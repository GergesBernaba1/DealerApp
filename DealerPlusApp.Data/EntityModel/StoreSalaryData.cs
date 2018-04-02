namespace DealerPlusApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StoreSalaryData")]
    public partial class StoreSalaryData
    {
        public int ID { get; set; }

        public int? EmployeeID { get; set; }

        public int? StoreSalaryID { get; set; }

        public int? StoreID { get; set; }

        public decimal? Value { get; set; }

        [StringLength(100)]
        public string Comment { get; set; }

        public int? CreatedUserNameID { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? ModifiedUserNameID { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Store Store { get; set; }

        public virtual StoreSalary StoreSalary { get; set; }
    }
}
