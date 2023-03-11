using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class Waiter : Staff
    {
        public int ıd2;
        public Waiter(int ıd, string name, string surname, string password, string job, string email) : base(ıd, name, surname, password, job, email)
        {
            ıd2 = ıd;
        }

        public void GetWaiterForm()
        {
            WaiterForm waiterForm = new WaiterForm();
            waiterForm.getInfo(ıd2);
            waiterForm.Show();
        }

    }
}
