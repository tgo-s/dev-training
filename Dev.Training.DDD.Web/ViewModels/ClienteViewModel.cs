using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dev.Training.DDD.Web.ViewModels
{
    public class ClienteViewModel
    {
        #region Properties
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "O campo {0} é necessário")]
        [MaxLength(150, ErrorMessage = "O campo {0} deve ter no maximo {1} caracteres")]
        [MinLength(3, ErrorMessage = "O campo {0} deve ter no mínimo {1} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é necessário")]
        [MaxLength(150, ErrorMessage = "O campo {0} deve ter no maximo {1} caracteres")]
        [MinLength(3, ErrorMessage = "O campo {0} deve ter no mínimo {1} caracteres")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "O campo {0} é necessário")]
        [MaxLength(100, ErrorMessage = "O campo {0} deve ter no maximo {1} caracteres")]
        [EmailAddress(ErrorMessage = "O campo {0} deve ser do tipo e-mail")]
        [DisplayName("E-Mail")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataAlteracao { get; set; }

        public bool Ativo { get; private set; }

        public virtual IEnumerable<ProdutoViewModel> Produtos { get; set; }
        #endregion
    }
}