namespace MVCStackOverFlow.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TechWantToWorkWith")]
    public partial class TechWantToWorkWith
    {
        public int ID { get; set; }

        public int? UserID { get; set; }

        [StringLength(30)]
        public string TechYouWantToWorkWith { get; set; }

        public virtual User User { get; set; }
    }
}
