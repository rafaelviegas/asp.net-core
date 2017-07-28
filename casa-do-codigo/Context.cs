using casa_do_codigo.Models;
using Microsoft.EntityFrameworkCore;

namespace casa_do_codigo
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            :base(options)
        {

        }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ItemPedido> ItemPedido { get; set; }

    }
}
