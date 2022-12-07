using Microsoft.AspNetCore.Mvc;
using BankApp.Service;
//using BankApp.Model;
using BankApp.DatabaseModel;

namespace BankApp.Controllers;

[ApiController]
[Route("api/transaction")]
public class TransactionController : ControllerBase
{

    private readonly ITransactionService transactionService;

    public TransactionController(ITransactionService service)
    {
        this.transactionService = service;
    }

    [HttpGet(Name = "GetTransactions")]
    public List<TransactionViewModel> GetAllTransactions()
    {
        var transactions = this.transactionService.GetAllTransactions();

        return transactions;
    }

    [HttpGet("{id}", Name = "GetTransaction")]
    public TransactionViewModel GetTransaction(int id)
    {
        var transaction = this.transactionService.GetTransaction(id);

        return transaction;
    }
}
