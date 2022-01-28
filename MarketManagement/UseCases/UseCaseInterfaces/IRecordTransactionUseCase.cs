namespace UseCases
{
    public interface IRecordTransactionUseCase
    {
        void Execute(string cashier,int productId, int quantity);
    }
}