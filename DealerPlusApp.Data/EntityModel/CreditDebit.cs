namespace DealerPlusApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CreditDebit")]
    public partial class CreditDebit
    {
        public CreditDebit()
        {
            CreditDebitDatas = new HashSet<CreditDebitData>();
        }

        public int ID { get; set; }

        public int? MarketID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public bool? IsDeleted { get; set; }

        public int? CreatedUserAdminID { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? ModifiedUserAdminID { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual Market Market { get; set; }

        public virtual ICollection<CreditDebitData> CreditDebitDatas { get; set; }
    }
}
