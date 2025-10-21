using Yummy.Api.Entity;

namespace Yummy.Api.DTO.ProductDTO
{
    public class ResultProductWithCategoryDTO
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
        public int? CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
