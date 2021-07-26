namespace MVCStackOverFlow.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WorkExperience")]
    public partial class WorkExperience
    {
        public int ID { get; set; }

        public int? UserID { get; set; }

        [StringLength(30)]
        public string JobTitle { get; set; }

        [StringLength(30)]
        public string CompanyName { get; set; }

        public int? YearOfJoinning { get; set; }

        [StringLength(200)]
        public string Responsibilities { get; set; }

        public virtual User User { get; set; }
    }
}
