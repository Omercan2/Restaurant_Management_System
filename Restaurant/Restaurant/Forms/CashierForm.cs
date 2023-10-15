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
    public partial class CashierForm : Form
    {
        List<Button> Buttonlist = new List<Button>();
        public CashierForm()
        {
            InitializeComponent();
        }
        SqlConnection cashierConnection = new SqlConnection("Data Source=OMER;Initial Catalog=Restaurant;Integrated Security=True");

        private void CashierForm_Load(object sender, EventArgs e)
        {
            Buttonlist.Add(BtnTable1);
            Buttonlist.Add(BtnTable2);
            Buttonlist.Add(BtnTable3);
            Buttonlist.Add(BtnTable4);
            Buttonlist.Add(BtnTable5);
            Buttonlist.Add(BtnTable6);
            Buttonlist.Add(BtnTable7);
            Buttonlist.Add(BtnTable8);
            Buttonlist.Add(BtnTable9);
            Buttonlist.Add(BtnTable10);

            cashierConnection.Open();
            SqlCommand cmd1 = new SqlCommand("Select OrderTable,OrderStatus from Orders where TableStatus=@p1", cashierConnection);
            cmd1.Parameters.AddWithValue("@p1", true);
            SqlDataReader dr1 = cmd1.ExecuteReader();

            while (dr1.Read())
            {
                foreach (var button in Buttonlist)
                {

                    if (dr1[0].ToString() == button.Text && dr1[1].ToString() == "False")
                    {
                        button.BackColor = Color.Red;
                        button.Enabled = false;

                    }
                    if (dr1[0].ToString() == button.Text && dr1[1].ToString() == "True")
                    {
                        button.BackColor = Color.Yellow;
                        button.Enabled = true;

                    }


                }




            }
            foreach (var button in Buttonlist)
            {
                if (button.BackColor == Color.LawnGreen)
                {
                    button.Enabled = false;
                }
            }


            cashierConnection.Close();

        }
        private void buttonFunction(string buttonText)
        {
            LblTable.Text = buttonText;
            cashierConnection.Open();
            SqlCommand cmd2 = new SqlCommand("Select OrderContents,OrderAmount from Orders where OrderTable=@p1",cashierConnection);
            cmd2.Parameters.AddWithValue("@p1", buttonText);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                LblCart.Text = dr2[0].ToString();
                LblTotal.Text= dr2[1].ToString();
            }
            cashierConnection.Close();
            GrpBoxCartItems.Visible= true;
        }

        private void BtnTable1_Click(object sender, EventArgs e)
        {
            buttonFunction(BtnTable1.Text);
        }

        private void BtnTable2_Click(object sender, EventArgs e)
        {
            buttonFunction(BtnTable2.Text);

        }

        private void BtnTable3_Click(object sender, EventArgs e)
        {
            buttonFunction(BtnTable3.Text);

        }

        private void BtnTable4_Click(object sender, EventArgs e)
        {
            buttonFunction(BtnTable4.Text);

        }

        private void BtnTable5_Click(object sender, EventArgs e)
        {
            buttonFunction(BtnTable5.Text);

        }

        private void BtnTable6_Click(object sender, EventArgs e)
        {
            buttonFunction(BtnTable6.Text);

        }

        private void BtnTable7_Click(object sender, EventArgs e)
        {
            buttonFunction(BtnTable7.Text);

        }

        private void BtnTable8_Click(object sender, EventArgs e)
        {
            buttonFunction(BtnTable8.Text);

        }

        private void BtnTable9_Click(object sender, EventArgs e)
        {
            buttonFunction(BtnTable9.Text);

        }

        private void BtnTable10_Click(object sender, EventArgs e)
        {
            buttonFunction(BtnTable10.Text);

        }

        private void BtnOrderPaid_Click(object sender, EventArgs e)
        {

            cashierConnection.Open();
            SqlCommand cmd3= new SqlCommand("Update Orders set TableStatus=@p1 where OrderTable=@p2",cashierConnection);
            cmd3.Parameters.AddWithValue("@p1", false);
            cmd3.Parameters.AddWithValue("@p2", LblTable.Text);
            cmd3.ExecuteNonQuery();
            cashierConnection.Close();

            foreach (var item in Buttonlist)
            {
                if (item.Text == LblTable.Text)
                {
                    item.BackColor = Color.LawnGreen;
                    item.Enabled = false;
                }
            }


        }
    }
}
