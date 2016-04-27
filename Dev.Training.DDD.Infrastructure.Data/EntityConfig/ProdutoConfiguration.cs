using System.Data.Entity.ModelConfiguration;
using Dev.Training.DDD.Domain.Entities;

namespace Dev.Training.DDD.Infrastructure.Data.EntityConfig
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(p => p.ProdutoId);

            //Define que o campo nome e sobrenome será obrigatório e demais restrições
            Property(p => p.Nome).IsRequired().HasMaxLength(250);
            Property(p => p.Valor).IsRequired();

            //Define a relação do produto com cliente -> [Cliente (p.Cliente) tem vários (.WithMany) produtos (na foreign key p.ClienteId)]
            HasRequired(p => p.Cliente).WithMany().HasForeignKey(p => p.ClienteId);
        }
    }
}
