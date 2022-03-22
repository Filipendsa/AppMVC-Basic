using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspMvcBasic.Models
{
    public class Fornecedor : Entity
    {
        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [StringLength(100, ErrorMessage = "O Campo {0} Precisa ter Entre {2} e {1} Caracteres.", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [StringLength(14, ErrorMessage = "O Campo {0} Precisa ter Entre {2} e {1} Caracteres.", MinimumLength = 11)]
        public string Documento { get; set; }

        public TipoFornecedor TipoFornecedor  { get; set; }

        public Endereco Endereco { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }

        /* EF Relations */
        public IEnumerable<Produto> Produtos { get; set; }

    }
}
