//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ToraMen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ToraMen()
        {
            this.Children1 = new HashSet<Children>();
        }
    
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public Nullable<int> telephon { get; set; }
        public Nullable<int> cellularTelephone1 { get; set; }
        public Nullable<int> cellularTelephone2 { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public int buildingNumber { get; set; }
        public Nullable<int> homeNumber { get; set; }
        public Nullable<int> zipCode { get; set; }
        public System.DateTime birthDate { get; set; }
        public int children { get; set; }
        public int fullDay { get; set; }
        public int doingTest { get; set; }
        public Nullable<decimal> refundTransportation { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Children> Children1 { get; set; }
        public virtual ToraMen ToraMen1 { get; set; }
        public virtual ToraMen ToraMen2 { get; set; }
        public virtual ToraMen ToraMen11 { get; set; }
        public virtual ToraMen ToraMen3 { get; set; }

        public static implicit operator List<object>(ToraMen v)
        {
            throw new NotImplementedException();
        }
    }
}
