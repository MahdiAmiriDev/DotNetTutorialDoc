using CleanArch.Domain.Order.Services;
using CleanArch.Domain.Product;

namespace CleanArch.Application.Order.Services;

public class OrderDomainService: IOrderDomainService
{
    private readonly IProductRepository _productRepository;

    public OrderDomainService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public bool IsProductExists(int productId)
    {
        return _productRepository.GetById(productId) != null;
    }
}