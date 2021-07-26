namespace MVCStackOverFlow.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Education")]
    public partial class Education
    {
        public int ID { get; set; }

        public int? UserID { get; set; }

        [StringLength(30)]
        public string Degree { get; set; }

        [StringLength(50)]
        public string University { get; set; }

        public int? FromYear { get; set; }

        public int? ToYear { get; set; }

        [StringLength(200)]
        public string Summary { get; set; }

        public virtual User User { get; set; }
    }
}
