using Restaurant.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    internal class Admin : Staff
    {
        public Admin(int ıd, string name, string surname, string password, string job, string email) : base(ıd, name, surname, password, job, email)
        {
        }
        public void GetAdminForm()
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }
       
        

    }
}
