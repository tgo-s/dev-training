using System.Data.Entity.ModelConfiguration;
using Dev.Training.DDD.Domain.Entities;

namespace Dev.Training.DDD.Infrastructure.Data.EntityConfig
{
    /*
     * Classe de configuração da entidade onde pode-se setar as particularidades em relação 
     * a configuração global.
     */
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(c => c.ClienteId);

            //Define que o campo nome e sobrenome será obrigatório e terá length de 100 (padrão 500)
            Property(c => c.Nome).IsRequired().HasMaxLength(150);
            Property(c => c.Sobrenome).IsRequired().HasMaxLength(150);

            Property(c => c.Email).IsRequired().HasMaxLength(100);
        }

    }
}
