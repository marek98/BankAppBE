//using BankApp.Model;
using BankApp.DatabaseModel;
using BankApp.Repository;

namespace BankApp.Service;

public class TransactionService : ITransactionService 
{
    private readonly ITransactionRepository transactionRepository;

    public TransactionService(ITransactionRepository repository) {
        this.transactionRepository = repository;
    }

    public List<TransactionViewModel> GetAllTransactions()
    {
        var transactionsViewModel = new List<TransactionViewModel>();
        var transactions = this.transactionRepository.GetAllTransactions();

        foreach(var transaction in transactions) {
            var transactionViewModel = new TransactionViewModel {
                AccountNumber = transaction.AccountNumber,
                Amount = transaction.Amount,
                BankCode = transaction.BankCode,
                FullName = transaction.User.Name,
                IssueDate = transaction.IssueDate,
                TransactionType = transaction.TransactionType.Name
            };

            transactionsViewModel.Add(transactionViewModel);
        }

        return transactionsViewModel;
    }

    public TransactionViewModel GetTransaction(int id)
    {
        var transaction = this.transactionRepository.GetTransaction(id);

        var transactionViewModel = new TransactionViewModel {
            AccountNumber = transaction.AccountNumber,
            Amount = transaction.Amount,
            BankCode = transaction.BankCode,
            FullName = transaction.User.Name,
            IssueDate = transaction.IssueDate,
            TransactionType = transaction.TransactionType.Name
        };

        return transactionViewModel;
    }
}