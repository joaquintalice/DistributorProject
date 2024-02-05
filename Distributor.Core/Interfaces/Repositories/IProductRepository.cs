namespace Distributor.Core.Interfaces.Repositories
{
    public interface IProductRepository
    {
        bool SaveChanges();
        Task<Product> GetProductByIdAsync(int id);
        Task<IReadOnlyList<Product>> GetProductsAsync();
        Task<int> CreateProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(int id);
    }
}
