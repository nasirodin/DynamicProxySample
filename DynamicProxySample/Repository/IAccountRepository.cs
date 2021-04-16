using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicProxySample.Entities;

namespace DynamicProxySample.Repository
{
    interface IAccountRepository : IRepository<Account>
    {
        long GetAccountBalance(Guid Id);
        void SetTransaction(Guid accountId, long amount);
    }
}
