//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThuongMaiDienTu
{
    using System;
    using System.Collections.Generic;
    
    public partial class ORDER_HISTORY
    {
        public int IdHistory { get; set; }
        public int IdUser { get; set; }
        public int IdOrder { get; set; }
        public string Comment { get; set; }
        public Nullable<System.DateTime> DateHistory { get; set; }
        public int IdStatus { get; set; }
    
        public virtual ORDER ORDER { get; set; }
        public virtual ORDER ORDER1 { get; set; }
        public virtual PAYMENT_STATUS PAYMENT_STATUS { get; set; }
        public virtual PAYMENT_STATUS PAYMENT_STATUS1 { get; set; }
        public virtual USER USER { get; set; }
        public virtual USER USER1 { get; set; }
    }
}