using System.ComponentModel.DataAnnotations;

namespace Asp_mvc.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Título é orbigatório.")]
        public string Titulo { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data está no formato incorreto."), Required(ErrorMessage = "A Data de lançamento é obrigatório.")]
        [Display(Name = "Data de lançamento")]
        public DateTime DataLancamento { get; set; }

        [StringLength(20, ErrorMessage = "Máximo de 20 caracteres."), Required(ErrorMessage = "O Gênero é obrigatório.")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "O Valor é orbigatório.")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "A Avaliação é obrigatório."), Display(Name = "Avaliação")]
        [RegularExpression(@"^[0-5]*$", ErrorMessage = "Somente de 0 a 5")]
        public int Avaliacao { get; set; }
    }
}
