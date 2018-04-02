namespace DealerPlusApp.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UsersAdmin")]
    public partial class UsersAdmin
    {
        public UsersAdmin()
        {
            Markets = new HashSet<Market>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [MaxLength(50)]
        public byte[] Password { get; set; }

        [StringLength(15)]
        public string FirstName { get; set; }

        [StringLength(15)]
        public string SecondName { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(10)]
        public string PhoneNumber { get; set; }

        public bool? Islocked { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedAdminSystemID { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? ModifiedAdminSystemID { get; set; }

        public virtual ICollection<Market> Markets { get; set; }
    }
}
