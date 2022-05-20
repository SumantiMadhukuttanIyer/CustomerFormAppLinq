using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerFormAppLinq
{
    public class CustomerListManager
    {
        public static List<Customer> LoadDemoData()
        {
            var output = new List<Customer>();

            output.Add(new Customer { FirstName = "Sagar", LastName = "Singh", Country = "USA", Age = 25, CustId = 22617 });
            output.Add(new Customer { FirstName = "Lily", LastName = "Sharma", Country = "Germany", Age = 20, CustId = 98423 });
            output.Add(new Customer { FirstName = "Fernandez", LastName = "Anthony", Country = "France", Age = 30, CustId = 28783 });
            output.Add(new Customer { FirstName = "Kevin", LastName = "Denis", Country = "Canada",  Age = 40, CustId = 38739 });
            output.Add(new Customer { FirstName = "Sofia", LastName = "Khan", Country = "Denmark", Age = 35, CustId = 2984 });
            output.Add(new Customer { FirstName = "Ikra", LastName = "yusuf", Country = "Bangladesh", Age = 22, CustId = 82328 });

            return output;
        }
    }
}
