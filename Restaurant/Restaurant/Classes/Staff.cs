using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    internal class Staff
    {

         int ID;
         string Name, Surname, Password, Job, Email;

        public Staff(int ıd, string name, string surname, string password, string job, string email)
        {
            ID = ıd;
            Name = name;
            Surname = surname;
            Password = password;
            Job = job;
            Email = email;


        }
        public void Info(){
            MessageBox.Show(ID+" "+ Name+" "+ Surname+" "+ Password+" "+ Job+" "+ Email);
        }
    }
}
