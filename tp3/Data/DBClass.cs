using System;
using Microsoft.EntityFrameworkCore;
using tp3.Models;

namespace tp3.Data
{
    public class DBClass : DbContext
    {
        public DBClass(DbContextOptions<DBClass> options) : base(options) { }
        public DbSet<PessoaModels> Pessoas { get; set; }
    }
}
