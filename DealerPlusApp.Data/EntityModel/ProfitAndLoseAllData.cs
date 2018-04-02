namespace DealerPlusApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProfitAndLoseAllData")]
    public partial class ProfitAndLoseAllData
    {
        public int ID { get; set; }

        public int? ProfitLoseAllID { get; set; }

        public int? StoreID { get; set; }

        public decimal? Value { get; set; }

        public DateTime? IntialDate { get; set; }

        [StringLength(100)]
        public string Comment { get; set; }

        public int? CreatedUserAdminID { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? ModifiedUserAdminID { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual ProfitAndLoseAll ProfitAndLoseAll { get; set; }

        public virtual Store Store { get; set; }
    }
}
