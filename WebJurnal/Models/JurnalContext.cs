using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Globalization;

namespace WebJurnal.Models
{
    public class JurnalContext : DbContext
    {
        static JurnalContext()
        {
            Database.SetInitializer<JurnalContext>(new JurnalContextInitializer());
        }
       public DbSet<Student> Students { get; set; }
       public DbSet<Teacher> Teachers { get; set; }
       public DbSet<Subject> Subjects { get; set; }
       public DbSet<Class> Classes { get; set; }
       public JurnalContext() : base ("JurnalDb")
            {}
     
    }
}