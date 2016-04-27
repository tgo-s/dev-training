using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dev.Training.DDD.Web.ViewModels
{
    public class ProdutoViewModel
    {
        #region Properties
        [Key]
        public int ProdutoId { get; private set; }

        [Required(ErrorMessage = "O campo {0} é necessário")]
        [MaxLength(250, ErrorMessage = "O campo {0} deve ter no maximo {1} caracteres")]
        [MinLength(3, ErrorMessage = "O campo {0} deve ter no mínimo {1} caracteres")]
        public string Nome { get; private set; }

        [Required(ErrorMessage = "O campo {0} é necessário")]
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999999999")]
        public decimal Valor { get; private set; }

        [Required(ErrorMessage = "O campo {0} é necessário")]
        [Range(typeof(int), "0", "9999999", ErrorMessage = "O campo {0} ultrapassa o valor maximo permitido")]
        public int Estoque { get; private set; }

        [DisplayName("Disponível?")]
        public bool Disponivel { get; private set; }

        public int ClienteId { get; private set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataAlteracao { get; set; }

        public virtual ClienteViewModel Cliente { get; set; }

        #endregion
    }
}