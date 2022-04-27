using AulaPesquisar.Entidades;
using Microsoft.EntityFrameworkCore;

namespace AulaPesquisar
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opt) : base(opt) { }
        public DbSet<Pessoa> PESSOAS { get; set; }

        public DbSet<Usuarios> usuarios { get; set; }
        public DbSet<Permisão> permissao { get; set; }
        public DbSet<Permisão_Usuario> permissao_usuarios { get; set; }



    }
}
