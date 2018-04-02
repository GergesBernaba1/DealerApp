namespace DealerPlusApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MRQVSCash")]
    public partial class MRQVSCash
    {
        public int ID { get; set; }

        public int? EmployeeID { get; set; }

        public int? MarketID { get; set; }

        public decimal? OriginalReport { get; set; }

        public decimal? SkimReport { get; set; }

        public decimal? Cash { get; set; }

        [StringLength(2)]
        public string Check { get; set; }

        public decimal? Diff { get; set; }

        [StringLength(50)]
        public string CommentOriginalReport { get; set; }

        [StringLength(50)]
        public string CommentSkimRevport { get; set; }

        [StringLength(50)]
        public string CommentCash { get; set; }

        [StringLength(50)]
        public string CommentCheck { get; set; }

        [StringLength(50)]
        public string CommentDiff { get; set; }

        [Column(TypeName = "date")]
        public DateTime? InitalDate { get; set; }

        public int? CreatedUserAdminID { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? ModifiedUserAdminID { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Market Market { get; set; }
    }
}
