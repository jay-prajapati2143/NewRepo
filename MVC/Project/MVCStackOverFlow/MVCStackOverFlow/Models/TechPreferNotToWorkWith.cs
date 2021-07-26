namespace MVCStackOverFlow.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TechPreferNotToWorkWith")]
    public partial class TechPreferNotToWorkWith
    {
        public int ID { get; set; }

        public int? UserID { get; set; }

        [StringLength(30)]
        public string TechPeferNotToWorkWith { get; set; }

        public virtual User User { get; set; }
    }
}
