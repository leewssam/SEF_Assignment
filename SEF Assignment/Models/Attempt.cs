//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SEF_Assignment.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Attempt
    {
        public string Stu_ID { get; set; }
        public string Puzzle_ID { get; set; }
        public byte Puzzle_Status { get; set; }
        public int Attempt_Score { get; set; }
        public System.DateTime DateTime_Stamp { get; set; }
    
        public virtual Puzzle Puzzle { get; set; }
        public virtual Student Student { get; set; }
    }
}
