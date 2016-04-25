using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Training.DDD.Domain.Entities
{
    public class Produto
    {
        #region Properties
        public int ProdutoId { get; private set; }
        public string Nome { get; private set; }
        public decimal Valor { get; private set; }
        public int Estoque { get; private set; }
        public bool Disponivel { get; private set; }
        public int ClienteId { get; private set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }

        public virtual Cliente Cliente { get; set; }

        #endregion

        #region Constructor
        protected Produto()
        {

        }

        public static Produto NewProduto(string name, decimal value, int stock, bool available, int clientId)
        {
            var prod = new Produto
            {
                Nome = name,
                Valor = value,
                Estoque = stock,
                Disponivel = available,
                ClienteId = clientId
            };
            return prod;
        }
        #endregion 

        #region Behavior

        #endregion
    }
}
