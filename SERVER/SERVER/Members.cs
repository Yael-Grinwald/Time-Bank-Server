//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SERVER
{
    using System;
    using System.Collections.Generic;
    
    public partial class Members
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public int locationId { get; set; }
        public int DomainsId { get; set; }
        public int FreeTimeId { get; set; }
        public int HoursDeposit { get; set; }
    
        public virtual Domains Domains { get; set; }
        public virtual FreeTime FreeTime { get; set; }
        public virtual Locations Locations { get; set; }
    }
}
