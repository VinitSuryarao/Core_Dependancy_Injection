using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Dependancy_Injection.Repository
{
    // Call any class through Interface, Cannot directly call child class
    public interface IA
    {
        Task<int> GetDataA();
    }
}
