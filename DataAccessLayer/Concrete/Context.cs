using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-UGJ662E\\SQL2022; database=DbCore8App; integrated security=true; TrustServerCertificate=True");
        }
    }
}
/*
public DbSet<Class>? Class's { get; set; }

// Migration Commands *Packet Manager*
->add-migration migname
->remove-migration for Re-Do
->update-database

*/