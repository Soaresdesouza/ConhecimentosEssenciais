using System.ComponentModel.DataAnnotations;

namespace AppSemTemplate.Models
{
    public class Produto
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome do produto é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome do produto não pode exceder 100 caracteres.")]
        public string Nome { get; set; }

        [StringLength(150, ErrorMessage = "A descrição não pode exceder 150 caracteres.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O preço é obrigatório.")]
        [Range(0.01, 10000.00, ErrorMessage = "O preço deve estar entre 0,01 e 10000,00.")]
        public decimal Preco { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "A quantidade em estoque não pode ser negativa.")]
        public int QuantidadeEstoque { get; set; }
        public DateTime DataCriacao { get; set; }

        [DataType(DataType.ImageUrl)]
        public string Imagem { get; set; }

        [Required(ErrorMessage = "A categoria é obrigatória.")]
        public string Categoria { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O peso não pode ser negativo.")]
        public double Peso { get; set; }

        [StringLength(50)]
        public string Dimensoes { get; set; }
        public Produto()
        {
            DataCriacao = DateTime.Now;
        }
    }
}
