using CRUDWithInterface.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWithInterface.Iservices
{
    class ICustomerService:customerService
    {
        DBEntities db = new DBEntities();
        public void  add(Customer data)
        {
            db.Customers.Add(data);
            db.SaveChanges();
        }
        public void deletebyId(int dltdata)
        {
            var dtd = db.Customers.Where(x => x.CustomerId == dltdata).FirstOrDefault();
            db.Customers.Remove(dtd);
            db.SaveChanges();

        }
    }
}
