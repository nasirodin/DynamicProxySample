using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;
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
            accountService = new ProxyGenerator()
                .CreateInterfaceProxyWithTargetInterface(accountService, new LogInterceptor());

            var myAccount = new Account() {AccountNumber = "123AB"};
            accountService.Deposit(myAccount, 2300);
            accountService.Deposit(myAccount, 4500);
            accountService.Withdrawal(myAccount, 800);
        }
    }

    [Serializable]
    public class LogInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            invocation.Proceed();
            var amount = invocation.Arguments.FirstOrDefault(a => a.GetType().IsAssignableFrom(typeof(long)));
            var account = invocation.Arguments.FirstOrDefault(a => a.GetType().IsAssignableFrom(typeof(Account)));
            Console.WriteLine($"{invocation.Method.Name} {amount}$ from {((Account) account).AccountNumber}");
        }
    }
}
