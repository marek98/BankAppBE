//using BankApp.Model;
using BankApp.DatabaseModel;
using Microsoft.EntityFrameworkCore;

namespace BankApp.Repository;

public class TransactionRepository : ITransactionRepository
{
    private readonly whiyes5oContext context;

    public TransactionRepository(whiyes5oContext context) {
        this.context = context;
    }


    public List<Transaction> GetAllTransactions() 
    {
        return this.context.Transactions.Include(p => p.User).Include(p => p.TransactionType).ToList();
    }

    public Transaction GetTransaction(int id)
    {
        return this.context.Transactions.Include(p => p.User).Include(p => p.TransactionType).FirstOrDefault(p => p.Id == id);
    }
}