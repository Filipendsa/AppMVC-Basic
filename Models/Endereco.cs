using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspMvcBasic.Models
{
    public class Endereco : Entity
    {
        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [StringLength(200, ErrorMessage = "O Campo {0} Precisa ter Entre {2} e {1} Caracteres.", MinimumLength = 2)]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [StringLength(50, ErrorMessage = "O Campo {0} Precisa ter Entre {2} e {1} Caracteres.", MinimumLength = 1)]
        public string Numero { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [StringLength(8, ErrorMessage = "O Campo {0} Precisa {1} Caracteres.", MinimumLength = 8)]
        public string Cep { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [StringLength(100, ErrorMessage = "O Campo {0} Precisa ter Entre {2} e {1} Caracteres.", MinimumLength = 2)]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [StringLength(100, ErrorMessage = "O Campo {0} Precisa ter Entre {2} e {1} Caracteres.", MinimumLength = 2)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [StringLength(50, ErrorMessage = "O Campo {0} Precisa ter Entre {2} e {1} Caracteres.", MinimumLength = 2)]
        public string Estado { get; set; }

        /* EF Relation */
        public Fornecedor Fornecedor { get; set; }
    }
}
