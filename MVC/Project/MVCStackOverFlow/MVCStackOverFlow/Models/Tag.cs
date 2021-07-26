namespace MVCStackOverFlow.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tag
    {
        public int ID { get; set; }

        public int? QuestionID { get; set; }

        [StringLength(30)]
        public string TagName { get; set; }

        public virtual Question Question { get; set; }
    }
}
