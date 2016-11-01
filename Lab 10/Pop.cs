using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_10 // If Pop button is selected this application would display
{
    public partial class Pop : Form
    {
        public Pop()
        {
            InitializeComponent();
        }

        private void Pop_Load(object sender, EventArgs e)
        {

        }
        private string Pprice = "";

        public string PopPrice
        {   //Returns the price of the album selected
            get { return Pprice; }
            set { Pprice = value; }
        }

        private string[] Pop80s = // Displays the album, artist and the price
            { "Doolittle \r\t Pixies \r\t $ 10.00","Synchronicity \r\t The Police \r\t $15.00",
            "Thriller \r\t Michael Jackson \r\t $35.00", "True Blue \r\t Madonna \r\t $7.00" };

        private string[] Pop90s =
            { "Jagged Little Pill \r\t Alanis Morissette \r\t $10.00", "Millennium \r\t Backstreet Boys \r\t $15.00",
            "No Strings Attached \r\t N’Sync \r\t $8.00", "Spice \r\t Spice Girl \r\t $5.00" };

        private string[] PopTodays =
            {"21 \r\t Adele \r\t $5.00","Bon Iver \r\t Bon Iver \r\t $7.00",
            "Contra \r\t Vampire Weekend \r\t $10.00","Hot fuss \r\t The Killers \r\t $6.00" };

        private void rdP80_CheckedChanged(object sender, EventArgs e)
        {
            iflers.Displayer(lstPSummary,Pop80s);
        }

        private void rdP90_CheckedChanged(object sender, EventArgs e)
        {
            iflers.Displayer(lstPSummary, Pop90s);
        }

        private void rdPToday_CheckedChanged(object sender, EventArgs e)
        {
            iflers.Displayer(lstPSummary, PopTodays);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {   
            if (rdP80.Checked)  // Displays the 1980's list of pop music if '80s' is checked
            {
                iflers.selection(lstPSummary, Pop80s, lstPBought);
            }

            if (rdP90.Checked)  // Displays the 1990's list of pop music if '90s' is checked
            {
                iflers.selection(lstPSummary, Pop90s, lstPBought);
            }

            if (rdPToday.Checked)   // Displays the today's list of pop music if 'Today' is checked
            {
                iflers.selection(lstPSummary, PopTodays, lstPBought);
            }

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {   // Displays totals of what the user selected
            iflers.PriceCheck(lstPBought, txtPPrice);
            PopPrice = txtPPrice.Text;
        }

        private void btnBackTo_Click(object sender, EventArgs e)
        {   // Brings user back to Form1
            if (iflers.IsEmpty(txtPPrice, "Total"))     //See if the total is empty
                this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {   // Clears totals and inputs
            iflers.ClearAll(lstPBought);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {   // Deletes totals and inputs
            iflers.delete(lstPBought);
        }
    }
}
