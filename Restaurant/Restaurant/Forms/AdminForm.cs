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

namespace Restaurant.Classes
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        SqlConnection adminconnection = new SqlConnection("Data Source=OMER;Initial Catalog=Restaurant;Integrated Security=True");


        private void AdminForm_Load(object sender, EventArgs e)
        {
            

        }

        private void BtnAdd_Click(object sender, EventArgs e)//for adding data
        {
            adminconnection.Open();

            SqlCommand cmdAdd = new SqlCommand("insert into Staff (Name,Surname,Password,Job,Status,Email) values(@p2,@p3,@p4,@p5,@p6,@p7)",adminconnection);
            
            cmdAdd.Parameters.AddWithValue("@p2",TbxAdminName.Text);
            cmdAdd.Parameters.AddWithValue("@p3",TbxAdminSurname.Text);
            cmdAdd.Parameters.AddWithValue("@p4",TbxAdminPassword.Text);
            cmdAdd.Parameters.AddWithValue("@p5",TbxAdminJob.Text);
            cmdAdd.Parameters.AddWithValue("@p6",TbxAdminStatus.Text);
            cmdAdd.Parameters.AddWithValue("@p7",TbxAdminEmail.Text);

            cmdAdd.ExecuteNonQuery();

            adminconnection.Close();
            MessageBox.Show("Staff Added");
        }

        private void BtnList_Click(object sender, EventArgs e)//for listing datas
        {
            // TODO: This line of code loads data into the 'restaurantDataSet.Staff' table. You can move, or remove it, as needed.
            //this.staffTableAdapter.Fill(this.restaurantDataSet.Staff);

            //
            adminconnection.Open();

       
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Staff",adminconnection);

            DataTable dt = new DataTable(); 
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;


            adminconnection.Close();
            

        }

        private void BtnRemove_Click(object sender, EventArgs e)// for removing data
        {
            adminconnection.Open();
            SqlCommand cmdDelete = new SqlCommand("delete from Staff where ID=@p1",adminconnection);
            cmdDelete.Parameters.AddWithValue("@p1",TbxAdminID.Text);
            cmdDelete.ExecuteNonQuery();
            adminconnection.Close();
            MessageBox.Show("Staff Removed");
        }
        // datagrid double click fills the textboxes 
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int choosed = dataGridView1.SelectedCells[0].RowIndex;

            TbxAdminID.Text = dataGridView1.Rows[choosed].Cells[0].Value.ToString();
            TbxAdminName.Text = dataGridView1.Rows[choosed].Cells[1].Value.ToString();
            TbxAdminSurname.Text = dataGridView1.Rows[choosed].Cells[2].Value.ToString();
            TbxAdminPassword.Text = dataGridView1.Rows[choosed].Cells[3].Value.ToString();
            TbxAdminJob.Text = dataGridView1.Rows[choosed].Cells[4].Value.ToString();
            TbxAdminStatus.Text = dataGridView1.Rows[choosed].Cells[5].Value.ToString();
            TbxAdminEmail.Text = dataGridView1.Rows[choosed].Cells[6].Value.ToString();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)//for updating data
        {
            adminconnection.Open();
            SqlCommand cmdUpdate = new SqlCommand("Update Staff Set Name=@p2,Surname=@p3,Password=@p4,Job=@p5,Status=@p6,Email=@p7 where ID=@p1", adminconnection);
            cmdUpdate.Parameters.AddWithValue("@p1", TbxAdminID.Text);
            cmdUpdate.Parameters.AddWithValue("@p2", TbxAdminName.Text);
            cmdUpdate.Parameters.AddWithValue("@p3", TbxAdminSurname.Text);
            cmdUpdate.Parameters.AddWithValue("@p4", TbxAdminPassword.Text);
            cmdUpdate.Parameters.AddWithValue("@p5", TbxAdminJob.Text);
            cmdUpdate.Parameters.AddWithValue("@p6", TbxAdminStatus.Text);
            cmdUpdate.Parameters.AddWithValue("@p7", TbxAdminEmail.Text);
            cmdUpdate.ExecuteNonQuery();
            adminconnection.Close();
            MessageBox.Show("Staff Updated");
        }

        private void BtnReports_Click(object sender, EventArgs e)//gets the reports form
        {
            
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.Show();
            
        }
    }
}
