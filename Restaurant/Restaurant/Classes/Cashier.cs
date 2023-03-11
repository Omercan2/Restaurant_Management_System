using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class Cashier : Staff
    {
        public Cashier(int ıd, string name, string surname, string password, string job, string email) : base(ıd, name, surname, password, job, email)
        {
        }
        public void GetCashierForm()
        {
            CashierForm cashierForm=new CashierForm();
            cashierForm.Show();
        }
    }
}
