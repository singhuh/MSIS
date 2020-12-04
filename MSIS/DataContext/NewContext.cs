using Microsoft.EntityFrameworkCore;
using MSIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSIS.DataContext
{
    public class NewContext:DbContext
    {
        public NewContext(DbContextOptions<NewContext> options):base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
