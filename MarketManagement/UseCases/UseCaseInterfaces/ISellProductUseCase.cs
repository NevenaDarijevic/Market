namespace UseCases
{
    public interface ISellProductUseCase
    {
        void Execute(string cashier,int productId, int quantity);
    }
}