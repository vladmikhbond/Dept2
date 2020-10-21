using Dept2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dept2.Data
{
   public class ApplicationDbContext : IdentityDbContext
   {
      public DbSet<News> News { set; get; }
      public DbSet<Person> Persons { set; get; }

      public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
      {
      }
   }
}
