using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_10        // If user selected Rock button this application would display
{
    public partial class Rock : Form
    {
        public Rock()
        {
            InitializeComponent();
        }

        private void Rock_Load(object sender, EventArgs e)
        {

        }

        private string Rprice = "";

        public string RockPrice
        {
            get { return Rprice; }
            set { Rprice = value; }
        }

        private string[] Rock80s =          // Displays the album, artist and the price
            { "Moving Pictures \r\t Rush \r\t $5.00","Murmur \r\t R.E.M. \r\t $12.00",
            "Nothing’s Shocking \r\t Jane’s Addiction \r\t $3.00", "Scary Monsters \r\t David Bowie \r\t $8.00" };

        private string[] Rock90s =
            { "Dookie \r\t Green Day \r\t $5.00", "Nevermind \r\t Nirvana \r\t $10.00",
            "OK Computer \r\t Radiohead \r\t $6.00", "Ten \r\t Pearl Jam \r\t $14.00" };

        private string[] RockTodays =
            {"Absolution \r\t Muse \r\t $5.00","Meteora \r\t Linkin Park \r\t $3.00",
            "Neon Bible \r\t Arcade Fire \r\t $10.00","The Black Parade \r\t My Chemical Romance \r\t $5.00" };

        private void rdR80_CheckedChanged(object sender, EventArgs e)
        {
            iflers.Displayer(lstRSummary, Rock80s);
        }

        private void rdR90_CheckedChanged(object sender, EventArgs e)
        {
            iflers.Displayer(lstRSummary, Rock90s);
        }

        private void rdRToday_CheckedChanged(object sender, EventArgs e)
        {
            iflers.Displayer(lstRSummary, RockTodays);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rdR80.Checked)
            {           // Displays the 1980's list of rock music if '80s' is checked
                    iflers.selection(lstRSummary, Rock80s, lstRBought);
            }

            if (rdR90.Checked)
            {           // Displays the 1990's list of rock music if '90s' is checked
                iflers.selection(lstRSummary, Rock90s, lstRBought);
            }

            if (rdRToday.Checked)
            {           // Displays the today's list of rock music if 'Today' is checked
                iflers.selection(lstRSummary, RockTodays, lstRBought);
            }

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {               // Caluclates the total in the lstCBrought 
            iflers.PriceCheck(lstRBought, txtRPrice);
            RockPrice = txtRPrice.Text;
        }

        private void btnBackTo_Click(object sender, EventArgs e)
        {               // Hides this application and goes back to Form1
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {               // Clears all selections and totals
            iflers.ClearAll(lstRBought);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {               // Allows user to delete their selection if needed
            iflers.delete(lstRBought);
        }
    }
}
