using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProxySample.Repository
{
    class AccountRepository : IAccountRepository
    {
        public long GetAccountBalance(Guid Id)
        {
            return Int64.MaxValue; // Yes i'm rich ;)
        }

        public void SetTransaction(Guid accountId, long amount)
        {
            return;
        }
    }
}
