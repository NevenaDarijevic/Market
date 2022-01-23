using CoreBusiness;

namespace UseCases.ProductsUseCases
{
    public interface IGetProductByIdUseCase
    {
        Product Execute(int productId);
    }
}