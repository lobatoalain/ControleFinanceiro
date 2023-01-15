using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ControleFinanceiro.Models;

namespace ControleFinanceiro.Data
{
    public class ControleFinanceiroContext : DbContext
    {
        public ControleFinanceiroContext (DbContextOptions<ControleFinanceiroContext> options)
            : base(options)
        {
        }

        public DbSet<ControleFinanceiro.Models.Receita> Receita { get; set; } = default!;

        public DbSet<ControleFinanceiro.Models.Despesa> Despesa { get; set; }
    }
}
