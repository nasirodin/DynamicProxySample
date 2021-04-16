using System;
using DynamicProxySample.Entities;
using DynamicProxySample.Repository;

namespace DynamicProxySample.Services
{
    class AccountServices : IAccountServices
    {
        private readonly IAccountRepository _accountRepository;

        public AccountServices(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public void Deposit(Account account, long amount)
        {
            _accountRepository.SetTransaction(account.Id, amount);
        }

        public void Withdrawal(Account account, long amount)
        {
            var currentBalance = _accountRepository.GetAccountBalance(account.Id);
            if (currentBalance < amount) throw new Exception("Insufficient balance");

            _accountRepository.SetTransaction(account.Id, amount * -1);
        }
    }
}
