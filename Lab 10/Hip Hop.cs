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
    public partial class Hip_Hop : Form
    {
        public Hip_Hop()
        {
            InitializeComponent();
        }
       
        private void Hip_Hop_Load(object sender, EventArgs e)   // If Country button is selected this application displays
        {

        }

        private string price = "";  // Starts the price of country music at $0

    public string Price
        {// Returns the price of the album selected
            get { return price; }
            set { price = value; }
        }
        // Displays the album, artist and the price
        private string[] hipHop80s =    
            { "Paid in Full \r\t Eric B. & Rakim \r\t $10.00","Paul’s Boutique \r\t Beastie Boys \r\t $8.00",
            "Raising Hell \r\t Beastie Boys \r\t $15.00", "Three Feet High \r\n and Rising \r\t De La Soul \r\t $7.00" };

        private string[] hipHop90s =
            { "Illmatic \r\t Nas \r\t $20.00", "Ready to Die \r\t The Notorious \r\t $10.00",
            "The Chronic \r\t Dr. Dre \r\t $15.00" };

        private string[] hipHopTodays =
            {"1992 \r\t The Game \r\t $20.00","A Seat at the Table \r\t Solange \r\t $10.00",
            "Lemonade \r\t Beyonce \r\t $25.00","Views \r\t Drake \r\t $15.00" };

        private void button2_Click(object sender, EventArgs e)
        {   // Delete totals and user input
            iflers.delete(lstBought);
        }

        private void rdH80_CheckedChanged(object sender, EventArgs e)
        {   // Displays the 1980's list of hip hop music if '80s' is checked
            iflers.Displayer(lstSummary, hipHop80s);
        }

        private void rdH90_CheckedChanged(object sender, EventArgs e)
        {   // Displays the 1990's list of hip hop music if '90s' is checked
            iflers.Displayer(lstSummary, hipHop90s);
        }

        private void rdHToday_CheckedChanged(object sender, EventArgs e)
        {   // Displays the today's list of hip hop music if 'Today' is checked
            iflers.Displayer(lstSummary, hipHopTodays);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {       // Added seleceted item to lstBrought
            if (rdH80.Checked)
            {
                iflers.selection(lstSummary, hipHop80s, lstBought);
            }

            if (rdH90.Checked)
            {
                iflers.selection(lstSummary, hipHop90s, lstBought);
            }

            if (rdHToday.Checked)
            {
                iflers.selection(lstSummary, hipHopTodays, lstBought);
            }
            
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {       // Calucates total of items seleted 
            iflers.PriceCheck(lstBought, txtTotal);
            Price = txtTotal.Text;
        }

        private void btnBackTo_Click(object sender, EventArgs e)
        {       // Brings user back to the previous application 
            if (iflers.IsEmpty(txtTotal, "Total"))      //see if the total is empty
                this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {       // Clears all inputs and totals 
            iflers.ClearAll(lstBought);
        }

        private void lstBought_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
