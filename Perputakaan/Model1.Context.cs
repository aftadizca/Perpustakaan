﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Perputakaan
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class perpustakaanEntities : DbContext
    {
        public perpustakaanEntities()
            : base("name=perpustakaanEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<buku> bukus { get; set; }
        public virtual DbSet<pinjam> pinjams { get; set; }
        public virtual DbSet<transaksi> transaksis { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<login> logins { get; set; }
    }
}
