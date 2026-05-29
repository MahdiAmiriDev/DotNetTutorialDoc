namespace DesingPatternSamples.Structural.DataMapper
{
    public class ProductMapper
    {
        public ProductDto MapToDto(Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price
            };
        }

        public Product MapToEntity(ProductDto dto)
        {
            return new Product
            {
                Id = dto.Id,
                Name = dto.Name,
                Price = dto.Price
            };
        }
    }
}
