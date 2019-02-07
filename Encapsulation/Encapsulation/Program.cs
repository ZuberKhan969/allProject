using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            deparment dt = new deparment();
            dt.setDepartment("Zuber");
            Console.WriteLine("This is set :-" + dt.setDepartment());
            Console.Read();
        }
    }
    public class deparment
    {
        private string DeparmentName;
            
        public string getDepartment()
        {
            return DeparmentName;
        }
        public void setDepartment(string a)
        {
            DeparmentName = a;
        }
    }
}
