//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mehroz_assignment
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentManagementSystem
    {
        public int studentId { get; set; }
        public string studentName { get; set; }
        public double studentCGPA { get; set; }
        public int studentSemester { get; set; }
        public string studentDepartment { get; set; }
        public string studentUniversity { get; set; }
    
        public virtual StudentManagementSystem StudentManagementSystem1 { get; set; }
        public virtual StudentManagementSystem StudentManagementSystem2 { get; set; }
    }
}