//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CineSeatDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public string OrderID { get; set; }
        public string VisitorID { get; set; }
        public string SectionID { get; set; }
        public string SeatID { get; set; }
    
        public virtual Section Section { get; set; }
        public virtual Visitor Visitor { get; set; }
    }
}
