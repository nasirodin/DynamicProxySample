using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProxySample.Entities
{
    public class Account : IEntity
    {
        public Guid Id { get; set; }
        public string AccountNumber { get; set; }
    }
}
