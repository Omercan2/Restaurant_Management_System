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
    public partial class WaiterForm : Form
    {
        int[] counter=new int[12];
        int waiterID;
        List<Button> Buttonlist = new List<Button>();
        public void getInfo(int id)
        {
            waiterID= id;
            
        }

        public WaiterForm()
        {
            InitializeComponent();
        }
        SqlConnection waiterconnection = new SqlConnection("Data Source=DESKTOP-DNNRNQO\\MSSQLSERVER01;Initial Catalog=Restaurant;Integrated Security=True");

        private void WaiterForm_Load(object sender, EventArgs e)
        {
            

            foreach(var item in counter)
            {
                counter[item]=0;
            }
            
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

            waiterconnection.Open();
            SqlCommand cmd1 = new SqlCommand("Select OrderTable,OrderStatus from Orders where TableStatus=@p1",waiterconnection);//buraya where ekle
            cmd1.Parameters.AddWithValue("@p1", true);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            
            while (dr1.Read())
            {
                 foreach(var button in Buttonlist)
                 {
                   
                    if (dr1[0].ToString() == button.Text && dr1[1].ToString() == "False")
                    {
                        button.BackColor = Color.Red; 
                        button.Enabled= false;
                        
                    }
                    if(dr1[0].ToString() == button.Text && dr1[1].ToString() == "True")
                    {
                        button.BackColor = Color.Yellow;
                        button.Enabled = false;
                        
                    }
                    

                }
                



            }

            waiterconnection.Close();


        }
        private void tableButtonClick(string buttonText)
        {
            LblChoosedTable.Text = buttonText;
            groupBox5.Visible = true;
        }

        private void BtnTable1_Click(object sender, EventArgs e)
        {
           tableButtonClick(BtnTable1.Text);

        }

        private void BtnTable2_Click(object sender, EventArgs e)
        {
            tableButtonClick(BtnTable2.Text);
        }

        private void BtnTable3_Click(object sender, EventArgs e)
        {
            tableButtonClick(BtnTable3.Text);
        }

        private void BtnTable4_Click(object sender, EventArgs e)
        {
            tableButtonClick(BtnTable4.Text);
        }

        private void BtnTable5_Click(object sender, EventArgs e)
        {
            tableButtonClick(BtnTable5.Text);
        }

        private void BtnTable6_Click(object sender, EventArgs e)
        {
            tableButtonClick(BtnTable6.Text);
        }

        private void BtnTable7_Click(object sender, EventArgs e)
        {
            tableButtonClick(BtnTable7.Text);
        }

        private void BtnTable8_Click(object sender, EventArgs e)
        {
            tableButtonClick(BtnTable8.Text);
        }

        private void BtnTable9_Click(object sender, EventArgs e)
        {
            tableButtonClick(BtnTable9.Text);
        }

        private void BtnTable10_Click(object sender, EventArgs e)
        {
            tableButtonClick(BtnTable10.Text);
        }

        private void BtnCola_Click(object sender, EventArgs e)//cola button
        {
            counter[0]++;
            LblColaCart.Text = "x" + counter[0];
            LblCartTotalValue.Text=(Convert.ToInt32(LblCartTotalValue.Text)+10).ToString();
        }

        private void button1_Click(object sender, EventArgs e)//cart cola button
        {
            
            if (counter[0] > 0)//for not showing the negative numbers on number
            {
                counter[0]--;
                LblColaCart.Text = "x" + counter[0];
                LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) - 10).ToString();
            }
           
            
        }

        private void BtnAyran_Click(object sender, EventArgs e)//ayran
        {
            counter[1]++;
            LblAyranCart.Text = "x" + counter[1];
            LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) + 5).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (counter[1] > 0)//for not showing the negative numbers on number
            {
                counter[1]--;
                LblAyranCart.Text = "x" + counter[1];
                LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) - 5).ToString();
            }
           
        }

        private void BtnGazoz_Click(object sender, EventArgs e)//gazoz
        {
            counter[2]++;
            LblGazozCart.Text = "x" + counter[2];
            LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) + 10).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (counter[2] > 0)//for not showing the negative numbers on number
            {
                counter[2]--;
                LblGazozCart.Text = "x" + counter[2];
                LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) - 10).ToString();
            }
            
        }

        private void BtnFanta_Click(object sender, EventArgs e)//fanta
        {
            counter[3]++;
            LblFantaCart.Text = "x" + counter[3];
            LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) + 10).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (counter[3] > 0)//for not showing the negative numbers on number
            {
                counter[3]--;
                LblFantaCart.Text = "x" + counter[3];
                LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) - 10).ToString();
            }
            
        }

        private void BtnDoner_Click(object sender, EventArgs e)//doner
        {
            counter[4]++;
            LblDonerCart.Text = "x" + counter[4];
            LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) + 40).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (counter[4] > 0)//for not showing the negative numbers on number
            {
                counter[4]--;
                LblDonerCart.Text = "x" + counter[4];
                LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) - 40).ToString();
            }
            
        }

        private void BtnLahmacun_Click(object sender, EventArgs e)//lahmacun
        {
            counter[5]++;
            LblLahmacunCart.Text = "x" + counter[5];
            LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) + 20).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (counter[5] > 0)//for not showing the negative numbers on number
            {
                counter[5]--;
                LblLahmacunCart.Text = "x" + counter[5];
                LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) - 20).ToString();
            }
            
        }

        private void BtnHamburger_Click(object sender, EventArgs e)//hamburger
        {
            counter[6]++;
            LblHamburgerCart.Text = "x" + counter[6];
            LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) + 60).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (counter[6] > 0)//for not showing the negative numbers on number
            {
                counter[6]--;
                LblHamburgerCart.Text = "x" + counter[6];
                LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) - 60).ToString();
            }
            
        }


        private void BtnPizza_Click(object sender, EventArgs e)//pizza
        {
            counter[7]++;
            LblPizzaCart.Text = "x" + counter[7];
            LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) + 80).ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (counter[7] > 0)//for not showing the negative numbers on number
            {
                counter[7]--;
                LblPizzaCart.Text = "x" + counter[7];
                LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) - 80).ToString();
            }
            
        }

        private void BtnBaklava_Click(object sender, EventArgs e)//baklava
        {
            counter[8]++;
            LblBaklavaCart.Text = "x" + counter[8];
            LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) + 30).ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (counter[8] > 0)//for not showing the negative numbers on number
            {
                counter[8]--;
                LblBaklavaCart.Text = "x" + counter[8];
                LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) - 30).ToString();
            }
            
        }

        private void BtnTulumba_Click(object sender, EventArgs e)//tulumba
        {
            counter[9]++;
            LblTulumbaCart.Text = "x" + counter[9];
            LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) + 25).ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (counter[9] > 0)//for not showing the negative numbers on number
            {
                counter[9]--;
                LblTulumbaCart.Text = "x" + counter[9];
                LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) - 25).ToString();
            }
            
        }

        private void BtnKunefe_Click(object sender, EventArgs e)//kunefe
        {
            counter[10]++;
            LblKunefeCart.Text = "x" + counter[10];
            LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) + 45).ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (counter[10] > 0)//for not showing the negative numbers on number
            {
                counter[10]--;
                LblKunefeCart.Text = "x" + counter[10];
                LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) - 45).ToString();
            }
            
        }

        private void BtnCheesecake_Click(object sender, EventArgs e)//cheesecake
        {
            counter[11]++;
            LblCheesecakeCart.Text = "x" + counter[11];
            LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) + 50).ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (counter[11] > 0)//for not showing the negative numbers on number
            {
                counter[11]--;
                LblCheesecakeCart.Text = "x" + counter[11];
                LblCartTotalValue.Text = (Convert.ToInt32(LblCartTotalValue.Text) - 50).ToString();
            }
            
        }
        //button
       



        private void BtnConfirmCart_Click(object sender, EventArgs e)//confirmcart
        {
            string orderContents=LblColaMenu.Text+LblColaCart.Text+"\n"+LblAyranMenu.Text+LblAyranCart.Text + "\n" +
                LblGazozMenu.Text+LblGazozCart.Text + "\n" + LblFantaMenu.Text+LblFantaCart.Text + "\n"+LblDonerMenu.Text+LblDonerCart.Text + "\n"+LblLahmacunMenu.Text+LblLahmacunCart.Text + "\n"+
                LblHamburgerMenu.Text+LblHamburgerCart.Text + "\n"+LblPizzaMenu.Text+LblPizzaCart.Text + "\n"+LblBaklavaMenu.Text+LblBaklavaCart.Text + "\n"+
                LblTulumbaMenu.Text+LblTulumbaCart.Text + "\n"+LblKunefeMenu.Text+LblKunefeCart.Text + "\n"+LblCheesecakeMenu.Text+LblCheesecakeCart.Text;
           
            DateTime currentDateTime = DateTime.Now;
            waiterconnection.Open();
                SqlCommand cmd2 = new SqlCommand("insert into Orders (WaiterID,OrderAmount,OrderStatus,OrderTable,TableStatus,OrderContents,OrderDate) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)",waiterconnection);
                cmd2.Parameters.AddWithValue("@p1", waiterID);
                cmd2.Parameters.AddWithValue("@p2", LblCartTotalValue.Text);
                cmd2.Parameters.AddWithValue("@p3", false);
                cmd2.Parameters.AddWithValue("@p4", LblChoosedTable.Text);
                cmd2.Parameters.AddWithValue("@p5", true);
                cmd2.Parameters.AddWithValue("@p6", orderContents);
                cmd2.Parameters.AddWithValue("@p7", currentDateTime);
                cmd2.ExecuteNonQuery();
                waiterconnection.Close();
            MessageBox.Show("Order Summary \n"+orderContents);//printing the bill
            foreach(var item in Buttonlist)
            {
                if (item.Text == LblChoosedTable.Text)
                {
                    item.BackColor= Color.Red;
                    item.Enabled= false;
                }
            }


            
        }
    }


}
