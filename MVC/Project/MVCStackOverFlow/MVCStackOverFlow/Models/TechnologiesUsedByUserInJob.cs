namespace MVCStackOverFlow.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TechnologiesUsedByUserInJob")]
    public partial class TechnologiesUsedByUserInJob
    {
        public int ID { get; set; }

        public int? UserID { get; set; }

        [StringLength(20)]
        public string Technologies { get; set; }

        public virtual User User { get; set; }
    }
}
