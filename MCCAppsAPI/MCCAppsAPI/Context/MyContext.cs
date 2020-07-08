using MCCAppsAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MCCAppsAPI.Context
{
    public class MyContext : DbContext
    {
        // parameterless
        public MyContext() : base("entityFramework") { }

        ////parameter
        //public MyContext(int a)
        //{

        //}

        public DbSet<Supplier> Suppliers { get; set; }
    }
}