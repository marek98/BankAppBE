//using BankApp.Model;
using BankApp.DatabaseModel;

namespace BankApp.Repository;

public interface ITransactionRepository
{
    List<Transaction> GetAllTransactions();

    Transaction GetTransaction(int id);
}