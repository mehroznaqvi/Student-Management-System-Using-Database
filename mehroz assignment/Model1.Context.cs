﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StudentManagementSystemEntities1 : DbContext
    {
        public StudentManagementSystemEntities1()
            : base("name=StudentManagementSystemEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<StudentManagementSystem> StudentManagementSystems { get; set; }
        public virtual DbSet<Attendance> Attendances { get; set; }
    }
}