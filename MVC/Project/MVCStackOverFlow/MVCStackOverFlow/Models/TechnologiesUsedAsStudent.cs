namespace MVCStackOverFlow.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TechnologiesUsedAsStudent")]
    public partial class TechnologiesUsedAsStudent
    {
        public int ID { get; set; }

        public int? UserID { get; set; }

        [StringLength(20)]
        public string Technology { get; set; }

        public virtual User User { get; set; }
    }
}
