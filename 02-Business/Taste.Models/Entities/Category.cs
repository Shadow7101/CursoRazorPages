using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taste.Models.Entities
{
    public class Category
    {
        [Key]
        [Column("CategoryId")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Categoria é de preenchimento obrigatório")]
        [Display(Name = "Categoria")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O tamanho deste campo deve ser entre 2 e 100 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo Ordem é de preenchimento obrigatório")]
        [Display(Name = "Ordem")]
        public byte DisplayOrder { get; set; }
    }
}
