//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace scaffef.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblPhase
    {
        public tblPhase()
        {
            this.tblSubCategories = new HashSet<tblSubCategory>();
        }
    
        public int PhaseID { get; set; }
        public string phaseName { get; set; }
    
        public virtual ICollection<tblSubCategory> tblSubCategories { get; set; }
    }
}
