using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace learn_006_dto_model_entity_poco.Entities
{
    internal class ProductEntity
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string? ArticleNumber { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string? Title { get; set; } = null!;

        [Column(TypeName = "nvarchar(max)")]
        public string Description { get; set; } = null!;

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Column(TypeName = "int")]
        // This was never added, so It's a problem for another day.
        //[ForeignKey(nameof(CategoryEntity))]
        public int CategoryId { get; set; }

    }
}
