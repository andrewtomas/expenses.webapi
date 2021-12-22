using Expenses.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Expenses.Core.Interfaces
{
    public interface IExpensesServices 
    {
        List<Expense> GetExpenses();
        Expense GetExpense(int id);
        Expense CrateExpense(DB.Expense expense);
        void DeleteExpense(Expense expense);
        Expense EditExpense(Expense expense);
    }
}
