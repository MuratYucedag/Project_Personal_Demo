//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_Personal_Demo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblMember
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblMember()
        {
            this.TblMemberRole = new HashSet<TblMemberRole>();
        }
    
        public int MemberID { get; set; }
        public string MemberName { get; set; }
        public string MemberSurname { get; set; }
        public string MemberPassword { get; set; }
        public string MemberMail { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblMemberRole> TblMemberRole { get; set; }
    }
}
