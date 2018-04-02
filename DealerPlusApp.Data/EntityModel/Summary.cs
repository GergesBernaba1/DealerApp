namespace DealerPlusApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Summary")]
    public partial class Summary
    {
        public Summary()
        {
            SummaryDatas = new HashSet<SummaryData>();
        }

        public int ID { get; set; }

        public int? MarketID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public bool? InTotal { get; set; }

        public int? CreatedUserAdminID { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? ModifiedUserAdminID { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual Market Market { get; set; }

        public virtual ICollection<SummaryData> SummaryDatas { get; set; }
    }
}
