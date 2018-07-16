using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.CursoMvc.Application.ViewModels
{
    public class ClienteEnderecoViewModel
    {
        public ClienteEnderecoViewModel()
        {
            ClienteId = Guid.NewGuid();
            EnderecoId = Guid.NewGuid();            
        }

        //Cliente

        [Key]
        public Guid ClienteId { get; set; }

        [Required(ErrorMessage = "Campo nome é obrigatório!")]
        [MaxLength(150, ErrorMessage = "Tamanho máximo {0} caracteres.")]
        [MinLength(2, ErrorMessage = "Tamanho mínimo {0} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo E-mail é obrigatório!")]
        [MaxLength(100, ErrorMessage = "Tamanho máximo {0} caracteres.")]
        [EmailAddress(ErrorMessage = "O E-mail Informado não é válido!")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo CPF é obrigatório!")]
        [MaxLength(11, ErrorMessage = "Tamanho máximo {0} caracteres.")]
        [DisplayName("CPF")]
        public string CPF { get; set; }

        [ScaffoldColumn(false)]
        public bool Ativo { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime DataNascimento { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }


        //Endereco

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
