using WebApplication1.Models.DTO;
namespace WebApplication1.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetAllAsync();
        Task<ProductDTO?> GetByIdAsync(int id);
        Task<ProductDTO> CreateAsync(CreateProductDTO input);
    }

}