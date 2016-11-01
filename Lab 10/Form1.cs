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
        public Form1()
        {
            InitializeComponent();
            
        }

        double Total = 0.0;             //Initialyzing  The total
        private void btnHipop_Click(object sender, EventArgs e)         // Hip Hop music type selection 
        {                                   
            Hip_Hop f1 = new Hip_Hop();     //Opening hip hop form
            f1.ShowDialog();

            txtHPrice.Text = f1.Price;                                  // Converts price to a non-integer number 
            double HPrice = Convert.ToDouble(this.txtHPrice.Text);      // Converts the price of hip hop album total to double data type
            Total += HPrice;                                            // Adds the price of hip hop album and assigns the results to the total 
            txtPrice.Text = Convert.ToString(Total);                    // Converts total price to string

        }

        private void btnPop_Click(object sender, EventArgs e)           // Pop music type selection 
        {
            Pop f2 = new Pop();             //Opening Pop form
            f2.ShowDialog();

            txtPopPrice.Text = f2.PopPrice;                             // Converts price to a non-integer number 
            double PPrice = Convert.ToDouble(this.txtPopPrice.Text);    // Converts the price of pop album total to double data type        
            Total += PPrice;                                            // Adds the price of pop album and assigns the results to the total
            txtPrice.Text = Convert.ToString(Total);                    // Converts total price to string
        }

        private void btnCounrty_Click(object sender, EventArgs e)       // Country music type selection 
        {
            Country f3 = new Country();     //Opening country form
            f3.ShowDialog();

            txtCPrice.Text = f3.CountryPrice;                           // Converts price to a non-integer number 
            double CPrice = Convert.ToDouble(this.txtCPrice.Text);      // Converts the price of country album total to double data type
            Total += CPrice;                                            // Adds the price of pop album and assigns the results to the total
            txtPrice.Text = Convert.ToString(Total);                    // Converts total price to string
        }

        private void btnRock_Click(object sender, EventArgs e)          // Rock music type selection 
        {
            Rock f4 = new Rock();           //Opening Rock form
            f4.ShowDialog();

            txtRockPrice.Text = f4.RockPrice;                           // Converts price to a non-integer number 
            double RPrice = Convert.ToDouble(this.txtRockPrice.Text);   // Converts the price of Rock album total to double data type
            Total += RPrice;                                            // Adds the price of pop album and assigns the results to the total
            txtPrice.Text = Convert.ToString(Total);                    // Converts total price to string
        }

        private void btnCheck_Click(object sender, EventArgs e)         // Collection of user input
        {
            if(iflers.IsEmpty(txtPrice, "Total"))       //Check if the total is empty before getting the customer info
            {
                Customer_Info f5 = new Customer_Info(); //Opening the customer info form
                f5.ShowDialog();

                lblFirst.Text = f5.FirstName;       //Getting back the value set in the customer info form
                lblLast.Text = f5.LastName;         //Getting back the value set in the customer info form
                lblAdd1.Text = f5.Address1;         //Getting back the value set in the customer info form
                lblAdd2.Text = f5.Address2;         //Getting back the value set in the customer info form
                lblCardType.Text = f5.CardType;     //Getting back the value set in the customer info form
                lblCardNum.Text = f5.CardNum;       //Getting back the value set in the customer info form
                lblCSC.Text = f5.CSC;               //Getting back the value set in the customer info form
                lblDate.Text = f5.Date;             //Getting back the value set in the customer info form
                lblEmail.Text = f5.Email;           //Getting back the value set in the customer info form
            }
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
