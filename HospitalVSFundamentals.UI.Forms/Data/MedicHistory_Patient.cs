//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalVSFundamentals.UI.Forms.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class MedicHistory_Patient
    {
        public int MedicHistory_Patient1 { get; set; }
        public Nullable<System.Guid> PatientId { get; set; }
        public Nullable<System.Guid> MedicHistoryId { get; set; }
    
        public virtual MedicHistory MedicHistory { get; set; }
        public virtual Patients Patients { get; set; }
    }
}
