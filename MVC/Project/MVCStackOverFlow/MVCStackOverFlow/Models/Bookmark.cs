namespace MVCStackOverFlow.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bookmark
    {
        public int ID { get; set; }

        public int? UserID { get; set; }

        public int? QuestionID { get; set; }

        public virtual Question Question { get; set; }

        public virtual User User { get; set; }
    }
}
