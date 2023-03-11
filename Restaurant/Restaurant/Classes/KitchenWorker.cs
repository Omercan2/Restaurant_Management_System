using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class KitchenWorker : Staff
    {
        public KitchenWorker(int ıd, string name, string surname, string password, string job, string email) : base(ıd, name, surname, password, job, email)
        {
        }
        public void GetKitchenWorkerForm()
        {
            KitchenWorkerForm kitchenWorkerForm= new KitchenWorkerForm();
            kitchenWorkerForm.Show();
        }
    }
}
