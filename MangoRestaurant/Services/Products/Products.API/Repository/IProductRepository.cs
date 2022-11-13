using Products.API.Models.Dto;

namespace Products.API.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetAll();
        Task<ProductDto> GetById(int productId);
        Task<ProductDto> CreateUpdateProduct(ProductDto productDto);
        Task<bool> DeleteProduct(int productId);
    }
}
