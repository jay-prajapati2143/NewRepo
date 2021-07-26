namespace MVCStackOverFlow.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JobProfile")]
    public partial class JobProfile
    {
        public int ID { get; set; }

        public int? UserID { get; set; }

        [StringLength(30)]
        public string JobType { get; set; }

        [StringLength(30)]
        public string Role { get; set; }

        [StringLength(50)]
        public string JobSearchStatus { get; set; }

        [StringLength(30)]
        public string Industry { get; set; }

        [Column(TypeName = "money")]
        public decimal? MinAnnualSalary { get; set; }

        public int? MinExperience { get; set; }

        public int? MaxExperience { get; set; }

        public virtual User User { get; set; }
    }
}
