using System.ComponentModel.DataAnnotations;

namespace ProductApi.Models.Data
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public int Price { get; set; }
        public string Author { get; set; } = null!;
    }
}
