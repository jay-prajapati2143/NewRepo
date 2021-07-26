namespace MVCStackOverFlow.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IndustriesToExclude")]
    public partial class IndustriesToExclude
    {
        public int ID { get; set; }

        public int? UserID { get; set; }

        [StringLength(30)]
        public string IndustryToExclude { get; set; }

        public virtual User User { get; set; }
    }
}
