//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AceTuitionPaymentSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_subject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_subject()
        {
            this.tb_child_subject = new HashSet<tb_child_subject>();
        }
    
        public int subject_id { get; set; }
        public string subject_chinese_name { get; set; }
        public string subject_english_name { get; set; }
        public string subject_grade { get; set; }
        public string subject_status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_child_subject> tb_child_subject { get; set; }
    }
}