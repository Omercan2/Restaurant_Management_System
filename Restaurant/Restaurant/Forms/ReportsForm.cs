using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }
        SqlConnection adminconnection = new SqlConnection("Data Source=DESKTOP-DNNRNQO\\MSSQLSERVER01;Initial Catalog=Restaurant;Integrated Security=True");

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            

        }

        private void BtnDaily_Click(object sender, EventArgs e)
        {
            LblReportsName.Text=BtnDaily.Text;
            DateTime temp = DateTime.Now;
            //for editing date to string
            string currentDateTime=temp.Year.ToString()+"."+temp.Month.ToString()+"."+temp.Day.ToString();


            adminconnection.Open();
            SqlCommand cmd1 = new SqlCommand("Select * from Orders where Orderdate=@p1", adminconnection);
            cmd1.Parameters.AddWithValue("@p1", currentDateTime);
            
            SqlDataReader dr1= cmd1.ExecuteReader();
            DgrReports.Rows.Clear();

            while (dr1.Read())
            {
                string[] row = new string[] {dr1[0].ToString(), dr1[1].ToString(),dr1[2].ToString(),
               dr1[3].ToString(),dr1[4].ToString(),dr1[5].ToString(),dr1[6].ToString(),dr1[7].ToString()};
                
                DgrReports.Rows.Add(row);
            }
 
            adminconnection.Close();


        }

        private void BtnMonthly_Click(object sender, EventArgs e)
        {
            LblReportsName.Text=BtnMonthly.Text;
            DateTime currentDateTime = DateTime.Now;
            DgrReports.Rows.Clear();
            
            adminconnection.Open();
            SqlCommand cmd2 = new SqlCommand("Select * from Orders",adminconnection);
            SqlDataReader dr2=cmd2.ExecuteReader();
            string currentMonth =(Convert.ToInt32(currentDateTime.Month)).ToString();
            string currentYear=currentDateTime.Year.ToString(); 

            while (dr2.Read())
            {
                string[] row = new string[] {dr2[0].ToString(), dr2[1].ToString(),dr2[2].ToString(),
               dr2[3].ToString(),dr2[4].ToString(),dr2[5].ToString(),dr2[6].ToString(),dr2[7].ToString()};
                char[] delimiterChars = { ' ', '.' };
                string date = dr2[5].ToString();
                string[] split = date.Split(delimiterChars);
                
               if ((Convert.ToInt32(split[1])).ToString() == currentMonth && split[2].ToString()==currentYear)
                {
                   
                    DgrReports.Rows.Add(row);
                }

                
            }


            adminconnection.Close();
            


        }

        private void BtnYearly_Click(object sender, EventArgs e)
        {
            LblReportsName.Text = BtnYearly.Text;
             DateTime currentDateTime = DateTime.Now;
            DgrReports.Rows.Clear();

            adminconnection.Open();
            SqlCommand cmd2 = new SqlCommand("Select * from Orders", adminconnection);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            
            string currentYear = currentDateTime.Year.ToString();

            while (dr2.Read())
            {
                string[] row = new string[] {dr2[0].ToString(), dr2[1].ToString(),dr2[2].ToString(),
               dr2[3].ToString(),dr2[4].ToString(),dr2[5].ToString(),dr2[6].ToString(),dr2[7].ToString()};
                char[] delimiterChars = { ' ', '.' };
                string date = dr2[5].ToString();
                string[] split = date.Split(delimiterChars);

                if ( split[2].ToString() == currentYear)
                {

                    DgrReports.Rows.Add(row);
                }


            }


            adminconnection.Close();

        }




    }
}
