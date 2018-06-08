namespace DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string Username { get; set; }

        [Column(TypeName = "date")]
        public DateTime? LastLogin { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateCreated { get; set; }

        [StringLength(50)]
        public string Password { get; set; }
    }
}
