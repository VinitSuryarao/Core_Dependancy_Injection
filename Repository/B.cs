using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Dependancy_Injection.Repository
{
    // Each Class called through Interface
    public class B : IB
    {
        public Task<int> GetDataB()
        {
            return Task.FromResult<int>(222);
        }
    }
}
