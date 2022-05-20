using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerFormAppLinq
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Console.WriteLine("------------ list --------------");
            List<Customer> people = CustomerListManager.LoadDemoData();

            foreach (var customer in people)
            {
                Console.WriteLine($"{customer.FirstName} {customer.LastName} {customer.Country} ({customer.Age}): YearsOld {customer.Age} {customer.CustId}");
            }

            Console.ReadLine();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
