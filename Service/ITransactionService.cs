//using BankApp.Model;
using BankApp.DatabaseModel;

namespace BankApp.Service;

public interface ITransactionService
{

    List<TransactionViewModel> GetAllTransactions();

    TransactionViewModel GetTransaction(int id);

}