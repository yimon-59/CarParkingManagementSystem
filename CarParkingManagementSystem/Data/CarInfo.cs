//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarParkingManagementSystem.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class CarInfo
    {
        public int Id { get; set; }
        public string PlateNumber { get; set; }
        public string ShopName { get; set; }
        public System.DateTime TimeIn { get; set; }
        public Nullable<System.DateTime> TimeOut { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public Nullable<decimal> ReceiptAmount { get; set; }
        public Nullable<int> IsReciptUsed { get; set; }
    }
}