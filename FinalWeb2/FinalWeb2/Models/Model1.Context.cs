﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalWeb2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FinalWebEntities2 : DbContext
    {
        public FinalWebEntities2()
            : base("name=FinalWebEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Afiliados> Afiliados { get; set; }
        public virtual DbSet<Estados> Estados { get; set; }
        public virtual DbSet<MemberShip> MemberShip { get; set; }
        public virtual DbSet<Socios> Socios { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
    }
}
