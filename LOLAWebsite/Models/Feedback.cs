//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LOLAWebsite.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Feedback
    {
        public int Feedback_ID { get; set; }
        public Nullable<int> Course_ID { get; set; }
        public string Id { get; set; }
        public Nullable<int> Teacher_ID { get; set; }
        public string Course_Marketing { get; set; }
        public Nullable<bool> Course_Registration_Type { get; set; }
        public Nullable<int> Course_Rating { get; set; }
        public Nullable<int> Student_Comment { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Course Cours { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
