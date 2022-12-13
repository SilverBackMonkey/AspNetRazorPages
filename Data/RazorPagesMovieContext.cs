using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASPNETRAZORPAGES.Models;

namespace ASPNETRAZORPAGES.Data
{
    public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext (DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<ASPNETRAZORPAGES.Models.Movie> Movie { get; set; } = default!;
    }
}
