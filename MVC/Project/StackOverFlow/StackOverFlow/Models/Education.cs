//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StackOverFlow.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Education
    {
        public int ID { get; set; }
        public Nullable<int> UserID { get; set; }
        public string Degree { get; set; }
        public string University { get; set; }
        public Nullable<int> FromYear { get; set; }
        public Nullable<int> ToYear { get; set; }
        public string Summary { get; set; }
    
        public virtual User User { get; set; }
    }
}
