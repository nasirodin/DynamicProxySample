using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicProxySample.Entities;
using DynamicProxySample.Repository;
using DynamicProxySample.Services;

namespace DynamicProxySample
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new AccountRepository();
            IAccountServices accountService = new AccountServices(repository);
            accountService = new AccountLogProxy(accountService);

            var myAccount = new Account() {AccountNumber = "123AB"};
            accountService.Deposit(myAccount, 2300);
            accountService.Deposit(myAccount, 4500);
            accountService.Withdrawal(myAccount, 800);
        }
    }
}
