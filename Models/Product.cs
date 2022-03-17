using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspMvcBasic.Models
{
    public class Product : Entity
    {
        public Guid ProviderKey { get; set; }

        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [StringLength(200,ErrorMessage ="O Campo {0} Precisa ter Entre {2} e {1} Caracteres.", MinimumLength = 2)]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [StringLength(1000 , ErrorMessage = "O Campo {0} Precisa ter Entre {2} e {1} Caracteres.", MinimumLength = 2)]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [StringLength(200, ErrorMessage = "O Campo {0} Precisa ter Entre {2} e {1} Caracteres.", MinimumLength = 2)]
        public string Imagem { get; set; }
        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        public string Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        /* EF Relation */
        public Provider Providers { get; set; }
    }
}
