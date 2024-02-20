using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp_mvc.Models;

namespace Asp_mvc.Data
{
    public class AspContext : DbContext
    {
        public AspContext (DbContextOptions<AspContext> options)
            : base(options)
        {
        }

        public DbSet<Asp_mvc.Models.Filme> Filme { get; set; } = default!;
    }
}
