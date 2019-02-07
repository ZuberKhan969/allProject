using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWithInterface.services
{
    interface customerService
    {
        void add(Customer data);
        void deletebyId(int id);
    }
}
