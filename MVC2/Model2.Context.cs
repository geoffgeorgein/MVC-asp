﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MVCEntities2 : DbContext
    {
        public MVCEntities2()
            : base("name=MVCEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tab1> Tab1 { get; set; }
    
        public virtual int sp_DBinsert(string na, Nullable<int> ag, string addr, string una, string em, string gen, string state, string qual, string pw, string ph, ObjectParameter status)
        {
            var naParameter = na != null ?
                new ObjectParameter("na", na) :
                new ObjectParameter("na", typeof(string));
    
            var agParameter = ag.HasValue ?
                new ObjectParameter("ag", ag) :
                new ObjectParameter("ag", typeof(int));
    
            var addrParameter = addr != null ?
                new ObjectParameter("addr", addr) :
                new ObjectParameter("addr", typeof(string));
    
            var unaParameter = una != null ?
                new ObjectParameter("una", una) :
                new ObjectParameter("una", typeof(string));
    
            var emParameter = em != null ?
                new ObjectParameter("em", em) :
                new ObjectParameter("em", typeof(string));
    
            var genParameter = gen != null ?
                new ObjectParameter("gen", gen) :
                new ObjectParameter("gen", typeof(string));
    
            var stateParameter = state != null ?
                new ObjectParameter("state", state) :
                new ObjectParameter("state", typeof(string));
    
            var qualParameter = qual != null ?
                new ObjectParameter("qual", qual) :
                new ObjectParameter("qual", typeof(string));
    
            var pwParameter = pw != null ?
                new ObjectParameter("pw", pw) :
                new ObjectParameter("pw", typeof(string));
    
            var phParameter = ph != null ?
                new ObjectParameter("ph", ph) :
                new ObjectParameter("ph", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_DBinsert", naParameter, agParameter, addrParameter, unaParameter, emParameter, genParameter, stateParameter, qualParameter, pwParameter, phParameter, status);
        }
    }
}
