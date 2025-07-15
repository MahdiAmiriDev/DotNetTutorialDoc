namespace CleanArch.Domain.Product;

public interface IProductRepository
{
    List<Product> GetList();

    Product GetById(int id);

    void Add(Product order);

    void Update(Product order);
}