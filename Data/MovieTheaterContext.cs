using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieTheater.Models;

namespace MovieTheater.Data
{
    public class MovieTheaterContext : DbContext
    {
        public MovieTheaterContext (DbContextOptions<MovieTheaterContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
