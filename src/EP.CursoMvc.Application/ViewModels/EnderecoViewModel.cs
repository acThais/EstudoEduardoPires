using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.CursoMvc.Application.ViewModels
{
    public class EnderecoViewModel
    {
        public EnderecoViewModel()
        {
            EnderecoId = Guid.NewGuid();
        }

        [Key]
        public Guid EnderecoId { get; set; }

        [Required(ErrorMessage = "Campo Logradouro é obrigatório!")]
        [MaxLength(150, ErrorMessage = "Tamanho máximo {0} caracteres.")]
        [MinLength(2, ErrorMessage = "Tamanho mínimo {0} caracteres.")]
        public string Logradouro { get; set; }


        [Required(ErrorMessage = "Campo numero é obrigatório!")]
        [MaxLength(100, ErrorMessage = "Tamanho máximo {0} caracteres.")]
        [MinLength(2, ErrorMessage = "Tamanho mínimo {0} caracteres.")]
        public string Numero { get; set; }

        [MaxLength(100, ErrorMessage = "Tamanho máximo {0} caracteres.")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "Campo bairro é obrigatório!")]
        [MaxLength(100, ErrorMessage = "Tamanho máximo {0} caracteres.")]
        [MinLength(2, ErrorMessage = "Tamanho mínimo {0} caracteres.")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Campo CEP é obrigatório!")]
        [MaxLength(8, ErrorMessage = "Tamanho máximo {0} caracteres.")]
        [DisplayName("CEP")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "Campo Cidade é obrigatório!")]
        [MaxLength(100, ErrorMessage = "Tamanho máximo {0} caracteres.")]
        [MinLength(2, ErrorMessage = "Tamanho mínimo {0} caracteres.")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Campo Estado é obrigatório!")]
        [MaxLength(100, ErrorMessage = "Tamanho máximo {0} caracteres.")]
        [MinLength(2, ErrorMessage = "Tamanho mínimo {0} caracteres.")]
        public string Estado { get; set; }
     }
}
