using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicProxySample.Entities;

namespace DynamicProxySample.Services
{
    class AccountLogProxy : IAccountServices
    {
        private readonly IAccountServices _accountService;

        public AccountLogProxy(IAccountServices accountService)
        {
            _accountService = accountService;
        }

        public void Deposit(Account account, long amount)
        {
            _accountService.Deposit(account, amount);
            Console.Write($"Deposit {amount}$ from account #{account.AccountNumber}");
        }

        public void Withdrawal(Account account, long amount)
        {
            _accountService.Withdrawal(account, amount);
            Console.Write($"Deposit {amount}$ from account #{account.AccountNumber}");
        }
    }
}
