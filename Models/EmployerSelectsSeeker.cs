//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JOBPORTAL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployerSelectsSeeker
    {
        public int EmployerSelectsSeekerID { get; set; }
        public Nullable<int> EmployerId { get; set; }
        public Nullable<int> JobSeekerId { get; set; }
    
        public virtual Employer Employer { get; set; }
        public virtual JobSeeker JobSeeker { get; set; }
    }
}
