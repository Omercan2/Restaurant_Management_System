using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restaurant
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=OMER;Initial Catalog=Restaurant;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            
            connection.Open();
            SqlCommand command = new SqlCommand("select * from Staff where Email=@p1 and Password=@p2", connection);
            command.Parameters.AddWithValue("@p1", TbxEmail.Text);
            command.Parameters.AddWithValue("@p2", Convert.ToInt32(TbxPassword.Text));
            SqlDataReader dr = command.ExecuteReader();



            if (dr.Read())
            {

                if (dr["job"].ToString() == "Admin")//admin enterance

                {
                    Admin admin = new Admin(Convert.ToInt32(dr[0]), dr[1].ToString(),
                        dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[6].ToString());


                    admin.GetAdminForm();
                    //this.Hide();//for closing login page
                }
                if (dr["job"].ToString() == "Cashier")
                {
                    Cashier cashier = new Cashier(Convert.ToInt32(dr[0]), dr[1].ToString(),
                        dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[6].ToString());


                }
                if (dr["job"].ToString() == "Waiter")
                {
                    Waiter waiter = new Waiter(Convert.ToInt32(dr[0]), dr[1].ToString(),
                        dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[6].ToString());

                    waiter.GetWaiterForm();
                }

                if (dr["job"].ToString() == "KitchenWorker")
                {
                    KitchenWorker kitchenWorker = new KitchenWorker(Convert.ToInt32(dr[0]), dr[1].ToString(),
                        dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[6].ToString());
                    
                    kitchenWorker.GetKitchenWorkerForm();
                }
                if (dr["job"].ToString() == "Cashier")
                {
                    Cashier cashier = new Cashier(Convert.ToInt32(dr[0]), dr[1].ToString(),
                        dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[6].ToString());

                    cashier.GetCashierForm();
                }



            }
            else
            {
                MessageBox.Show("Wrong email or password");
            }







            connection.Close();

        }
    }
}
