using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_10
{
    public partial class Form1 : Form
    {
        //public string firstName { get; set; }                 // Obtain customer name
        //public string LastName { get; set; }
        //public string Address1 { get; set; }                  // Obtain customer address
        //public string Address2 { get; set; }
        //public string cardType { get; set; }                  // Obtain customer card information
        //public string CardNum { get; set; }
        //public string CSC { get; set; }
        //public string ExprirationDate { get; set; }
        //public string Email { get; set; }                     // Obtain a way to contact customer via email

        public Form1()
        {
            InitializeComponent();
            
        }

        double Total = 0.0;
        private void btnHipop_Click(object sender, EventArgs e)         // Hip Hop music type selection 
        {                                   
            Hip_Hop f1 = new Hip_Hop();
            f1.ShowDialog();

            txtHPrice.Text = f1.Price;                                  // Converts price to a non-integer number 
            double HPrice = Convert.ToDouble(this.txtHPrice.Text);      // Converts the price of hip hop album total to double data type
            Total += HPrice;                                            // Adds the price of hip hop album and assigns the results to the total 
            txtPrice.Text = Convert.ToString(Total);                    // Converts total price to string

        }

        private void btnPop_Click(object sender, EventArgs e)           // Pop music type selection 
        {
            Pop f2 = new Pop();
            f2.ShowDialog();

            txtPopPrice.Text = f2.PopPrice;                             // Converts price to a non-integer number 
            double PPrice = Convert.ToDouble(this.txtPopPrice.Text);    // Converts the price of pop album total to double data type        
            Total += PPrice;                                            // Adds the price of pop album and assigns the results to the total
            txtPrice.Text = Convert.ToString(Total);                    // Converts total price to string
        }

        private void btnCounrty_Click(object sender, EventArgs e)       // Country music type selection 
        {
            Country f3 = new Country();
            f3.ShowDialog();

            txtCPrice.Text = f3.CountryPrice;                           // Converts price to a non-integer number 
            double CPrice = Convert.ToDouble(this.txtCPrice.Text);      // Converts the price of country album total to double data type
            Total += CPrice;                                            // Adds the price of pop album and assigns the results to the total
            txtPrice.Text = Convert.ToString(Total);                    // Converts total price to string
        }

        private void btnRock_Click(object sender, EventArgs e)          // Rock music type selection 
        {
            Rock f4 = new Rock();
            f4.ShowDialog();

            txtRockPrice.Text = f4.RockPrice;                           // Converts price to a non-integer number 
            double RPrice = Convert.ToDouble(this.txtRockPrice.Text);   // Converts the price of Rock album total to double data type
            Total += RPrice;                                            // Adds the price of pop album and assigns the results to the total
            txtPrice.Text = Convert.ToString(Total);                    // Converts total price to string
        }

        private void btnCheck_Click(object sender, EventArgs e)         // Collection of user input
        {
            Customer_Info f5 = new Customer_Info();
            f5.ShowDialog();

            lblFirst.Text = f5.FirstName;
            lblLast.Text = f5.LastName;
            lblAdd1.Text = f5.Address1;
            lblAdd2.Text = f5.Address2;
            lblCardType.Text = f5.CardType;
            lblCardNum.Text = f5.CardNum;
            lblCSC.Text = f5.CSC;
            lblDate.Text = f5.Date;
            lblEmail.Text = f5.Email;
        }

        private void btnExit_Click(object sender, EventArgs e)          // Exits out of the application 
        {
            this.Close();
        }

        private void txtHPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
