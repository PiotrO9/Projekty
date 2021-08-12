namespace WpfEntityframeworkWithDbfirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sampleTable")]
    public partial class sampleTable
    {
        public int id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
    }
}
