using MData.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MRepo
{
    public class MDbContext:DbContext
    {
        public MDbContext(DbContextOptions<MDbContext> options) : base(options) { }
        public DbSet<Film> Films { get; set; }
    }
}
