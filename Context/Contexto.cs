using Microsoft.EntityFrameworkCore;
using ControleDeGastos.Models;

namespace ControleDeGastos.Context
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Gasto> Gastos { get; set; }
    }
}
