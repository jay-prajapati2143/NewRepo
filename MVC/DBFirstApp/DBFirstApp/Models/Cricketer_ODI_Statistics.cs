//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBFirstApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cricketer_ODI_Statistics
    {
        public int ODI_ID { get; set; }
        public Nullable<int> Cricketer_ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Half_Century { get; set; }
        public Nullable<int> Century { get; set; }
    
        public virtual Cricketer Cricketer { get; set; }
    }
}
