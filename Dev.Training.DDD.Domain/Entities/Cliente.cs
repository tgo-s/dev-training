using System;
using System.Collections.Generic;

namespace Dev.Training.DDD.Domain.Entities
{
    public class Cliente
    {
        #region Properties
        public int ClienteId { get; private set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Email { get; private set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public bool Ativo { get; private set; }

        public virtual IEnumerable<Produto> Produtos { get; set; }
        #endregion

        #region Constructor
        protected Cliente()
        {

        }
        //Inicializador da classe
        public static Cliente NewCliente(string firstname, string lastname, string email, bool isActive) {
            var cli = new Cliente {
                Nome = firstname,
                Sobrenome = lastname,
                Email = email,
                Ativo = isActive
            };
            return cli;
        }
        #endregion

        #region Behavior
        public bool IsSpecialClient() {
            return this.Ativo && (DateTime.Now.Year - this.DataCadastro.Year >= 5);
        }
        #endregion
    }
}
