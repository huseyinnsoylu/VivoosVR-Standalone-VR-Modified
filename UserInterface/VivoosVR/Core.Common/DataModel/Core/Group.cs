//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Common.DataModel.Core
{
    
    using System.Runtime.Serialization;
    
    using System;
    using System.Collections.Generic;
    
    [DataContract(IsReference = true)]
    public partial class Group
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Group()
        {
            this.Users = new HashSet<User>();
        }
    
    	[DataMember]
        public System.Guid Id { get; set; }
    	[DataMember]
        public System.Guid BranchId { get; set; }
    
    	[DataMember]
        public virtual Branch Branch { get; set; }
    	[DataMember]
        public virtual Consumer Consumer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    	[DataMember]
        public virtual ICollection<User> Users { get; set; }
    }
}
