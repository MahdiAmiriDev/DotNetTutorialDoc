namespace CleanArch.Domain.Order.Services;

public interface IOrderDomainService
{
    bool IsProductExists(int productId);
}