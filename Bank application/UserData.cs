namespace Bank_application
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserData")]
    public partial class UserData
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AccountNumber { get; set; }

        [StringLength(25)]
        public string Password { get; set; }

        public double? Amount { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool IsAdmin { get; set; }
    }
}
