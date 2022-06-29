using SBP.Domain.Validator;
using System.ComponentModel.DataAnnotations;

namespace SBP.Domain.DTO.Student
{
    public class StudentDTO
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório", AllowEmptyStrings = false)]
        [MaxLength(120, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres")]
        [MinLength(10, ErrorMessage = "O campo {0} deve ter no mínimo {1} caracteres")]
        public string Name { get; set; }

        [Range(1,140)]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int Age { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateBirth { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório", AllowEmptyStrings = false)]
        [MaxLength(14, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres")]
        [MinLength(14, ErrorMessage = "O campo {0} deve ter no mínimo {1} caracteres")]
        [CPFValidator(ErrorMessage = "CPF inválido")]
        public string CPF { get; set; }
    }
}
