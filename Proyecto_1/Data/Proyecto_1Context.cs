using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proyecto_1.Models;

namespace Proyecto_1.Data
{
    public class Proyecto_1Context : DbContext
    {
        public Proyecto_1Context (DbContextOptions<Proyecto_1Context> options)
            : base(options)
        {
        }

        public DbSet<Proyecto_1.Models.Usuario> User { get; set; }
    }
}
