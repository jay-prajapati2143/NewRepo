namespace MVCStackOverFlow.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Answer
    {
        public int AnswerID { get; set; }

        public int? QuestionID { get; set; }

        public int? UserID { get; set; }

        public string AnswerBody { get; set; }

        public int? Vote { get; set; }

        public virtual Question Question { get; set; }

        public virtual User User { get; set; }
    }
}
