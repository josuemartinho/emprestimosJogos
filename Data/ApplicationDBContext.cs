using emprestimosJogos.Models;
using Microsoft.EntityFrameworkCore;

namespace emprestimosJogos.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        public DbSet<EmprestimoModel> Emprestimos { get; set; }
    }
}
