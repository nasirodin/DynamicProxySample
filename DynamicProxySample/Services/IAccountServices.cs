using DynamicProxySample.Entities;

namespace DynamicProxySample.Services
{
    public interface IAccountServices
    {
        void Deposit(Account account,long amount);
        void Withdrawal(Account account, long amount);
    }
}
