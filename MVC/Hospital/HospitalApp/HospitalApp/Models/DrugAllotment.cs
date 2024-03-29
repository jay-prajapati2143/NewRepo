//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DrugAllotment
    {
        public int ID { get; set; }
        public Nullable<int> PatientID { get; set; }
        public string DrugName { get; set; }
        public byte[] Morning { get; set; }
        public byte[] Afternoon { get; set; }
        public byte[] Evenning { get; set; }
        public byte[] Night { get; set; }
    
        public virtual Patient Patient { get; set; }
    }
}
