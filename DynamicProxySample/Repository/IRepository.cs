using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicProxySample.Entities;

namespace DynamicProxySample.Repository
{
    interface IRepository<T> where T : IEntity
    {
    }
}
