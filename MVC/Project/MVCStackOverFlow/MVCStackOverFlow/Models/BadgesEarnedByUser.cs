namespace MVCStackOverFlow.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BadgesEarnedByUser")]
    public partial class BadgesEarnedByUser
    {
        public int ID { get; set; }

        public int? UserID { get; set; }

        public int? BadgeID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfEarned { get; set; }

        public virtual Badge Badge { get; set; }

        public virtual User User { get; set; }
    }
}
