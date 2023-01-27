using APIFactElect.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIFactElect.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Usuarios> usuarios { get; set; }
        public DbSet<APIFactElect.Models.Personas> Personas { get; set; }
        public DbSet<APIFactElect.Models.Clientes> Clientes { get; set; }
        public DbSet<APIFactElect.Models.Companias> Companias { get; set; }
    }
}
