//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfApp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class PersonAddress
    {
        public int PersonAddressId { get; set; }
        public int PersonId { get; set; }
        public int AddressId { get; set; }
    
        public virtual Address Address { get; set; }
        public virtual Person Person { get; set; }
    }
}
