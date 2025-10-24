using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstoqueAPI.Models
{
    public class Product
    {
        
        public int Id { get; set; }

        
        [Required(ErrorMessage = "O nome do produto é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome não pode exceder 100 caracteres.")]
        public string Name { get; set; } = string.Empty;

        
        [Required(ErrorMessage = "O preço é obrigatório.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O preço deve ser maior que zero.")]
        [Column(TypeName = "decimal(18, 2)")]         public decimal Price { get; set; }

        
        [StringLength(50, ErrorMessage = "A categoria não pode exceder 50 caracteres.")]
        public string? Category { get; set; }

        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
