using Microsoft.AspNetCore.Mvc;
using BudgetBuddy.Models;

namespace BudgetBuddy.Controllers
{
    public class BudgetController : Controller
    {
        private static List<Transaction> transactions = new();

        public IActionResult Index()
        {
            return View(transactions);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Transaction transaction)
        {
            transaction.Id = transactions.Count + 1;
            transaction.Date = DateTime.Now;

            transactions.Add(transaction);

            return RedirectToAction("Index");
        }
    }
}