using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WordsBweb.Models;

namespace WordsBweb.Data
{
    public class WordsContext : DbContext
    {
        public WordsContext(DbContextOptions<WordsContext> options)
           : base(options)
        {
        }
        public DbSet<Words> WordsA { get; set; }
    }
}
