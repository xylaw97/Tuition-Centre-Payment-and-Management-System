﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AceTuitionEntities : DbContext
    {
        public AceTuitionEntities()
            : base("name=AceTuitionEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_addon> tb_addon { get; set; }
        public virtual DbSet<tb_admin> tb_admin { get; set; }
        public virtual DbSet<tb_balance> tb_balance { get; set; }
        public virtual DbSet<tb_child> tb_child { get; set; }
        public virtual DbSet<tb_child_package> tb_child_package { get; set; }
        public virtual DbSet<tb_child_subject> tb_child_subject { get; set; }
        public virtual DbSet<tb_discount> tb_discount { get; set; }
        public virtual DbSet<tb_early_payment> tb_early_payment { get; set; }
        public virtual DbSet<tb_notice> tb_notice { get; set; }
        public virtual DbSet<tb_package> tb_package { get; set; }
        public virtual DbSet<tb_parent> tb_parent { get; set; }
        public virtual DbSet<tb_payment> tb_payment { get; set; }
        public virtual DbSet<tb_payment_file> tb_payment_file { get; set; }
        public virtual DbSet<tb_receipt> tb_receipt { get; set; }
        public virtual DbSet<tb_receipt_addon> tb_receipt_addon { get; set; }
        public virtual DbSet<tb_receipt_discount> tb_receipt_discount { get; set; }
        public virtual DbSet<tb_receipt_package> tb_receipt_package { get; set; }
        public virtual DbSet<tb_subject> tb_subject { get; set; }
    }
}