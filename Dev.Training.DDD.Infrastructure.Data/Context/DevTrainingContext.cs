using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using Dev.Training.DDD.Domain.Entities;
using Dev.Training.DDD.Infrastructure.Data.EntityConfig;

namespace Dev.Training.DDD.Infrastructure.Data.Context
{
    public class DevTrainingContext : DbContext
    {
        public DevTrainingContext() : base("DevTrainingConnStr") { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configura a criação do banco para não utilizar determinadas convenções como pluralização ou delete em cascade
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Configura na criação do banco que Nomes de entidades terminados em "Id" serão PK
            modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "Id").Configure(p => p.IsKey());
            //Configura que campos strings serão varchar com tamanho de 500 por padrão
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(500));

            //Adiciona a configuração personalizada para cada situação
            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new ProdutoConfiguration());
        }

        public override int SaveChanges()
        {
            foreach (var item in ChangeTracker.Entries().Where(e => e.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (item.State == EntityState.Added)
                {
                    item.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (item.State == EntityState.Modified)
                {
                    item.Property("DataCadastro").IsModified = false;
                }
            }

            foreach (var item in ChangeTracker.Entries().Where(e => e.Entity.GetType().GetProperty("DataAlteracao") != null))
            {
                item.Property("DataAlteracao").CurrentValue = DateTime.Now;
                //item.Property("DataAlteracao").IsModified = true;
            }
            return base.SaveChanges();
        }
    }
}
