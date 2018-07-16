using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.CursoMvc.Application.ViewModels
{
    public class ClienteViewModel
    {
        public ClienteViewModel()
        {
            ClienteId = Guid.NewGuid();
        }

        [Key]
        public Guid ClienteId { get; set; }

        [Required(ErrorMessage="Campo nome é obrigatório!")]
        [MaxLength(150, ErrorMessage = "Tamanho máximo {0} caracteres.")]
        [MinLength(2, ErrorMessage = "Tamanho mínimo {0} caracteres.")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "Campo E-mail é obrigatório!")]
        [MaxLength(100, ErrorMessage ="Tamanho máximo {0} caracteres.")]
        [EmailAddress(ErrorMessage="O E-mail Informado não é válido!")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo CPF é obrigatório!")]
        [MaxLength(11, ErrorMessage = "Tamanho máximo {0} caracteres.")]
        [DisplayName("CPF")]
        public string CPF { get; set; }

        [ScaffoldColumn(false)]
        public bool Ativo { get; set; }

        [Display(Name= "Data de Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode=true, DataFormatString="{0:yyyy-MM-dd}")]
        [DataType(DataType.Date,ErrorMessage="Data em formato inválido")]
        public DateTime DataNascimento { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

     
    }
}
