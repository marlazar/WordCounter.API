using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCounter.Core.Models;

namespace WordCounter.Core.DataContext
{
    public class WordCounterDataContext : DbContext
    {
        public WordCounterDataContext(DbContextOptions<WordCounterDataContext> options) : base(options) { }
        public DbSet<ReadingInstance> ReadingInstance { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=WordCounterDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReadingInstance>(r =>
            {
                r.HasKey(r => r.InstanceId);
            });
        }
    }
}
