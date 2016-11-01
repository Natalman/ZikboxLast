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
    public partial class Customer_Info : Form
    {
        private string firstName = "";          //initialyzing the value to send back to the form1
        private string lastName = "";           //initialyzing the value to send back to the form1
        private string address1 = "";           //initialyzing the value to send back to the form1
        private string address2 = "";           //initialyzing the value to send back to the form1
        private string cardType = "";           //initialyzing the value to send back to the form1
        private string cardNum = "";            //initialyzing the value to send back to the form1
        private string csc = "";                //initialyzing the value to send back to the form1
        private string date = "";               //initialyzing the value to send back to the form1
        private string email = "";              //initialyzing the value to send back to the form1

        public string FirstName { get { return firstName; } set { firstName = value; } }//creating getter and setter
        public string LastName { get { return lastName; } set { lastName = value; } }//creating getter and setter
        public string Address1 { get { return address1; } set { address1 = value; } }//creating getter and setter
        public string Address2 { get { return address2; } set { address2 = value; } }//creating getter and setter
        public string CardType { get { return cardType; } set { cardType = value; } }//creating getter and setter
        public string CardNum { get { return cardNum; } set { cardNum = value; } }//creating getter and setter
        public string CSC { get { return csc; } set { csc = value; } }//creating getter and setter
        public string Date { get { return date; } set { date = value; } }//creating getter and setter
        public string Email { get { return email; } set { email = value; } }//creating getter and setter


        public Customer_Info()
        {
            InitializeComponent();
        }

        private void Customer_Info_Load(object sender, EventArgs e)
        {
            //Creating array for card type 
            string[] cardType = { "Card Type", "Visa", "American Express", "Master Card" };
            iflers.MyBox(cboCardType, cardType); //calling the iflers's my box method to set the combo box

            //creating array for Month 
            string[] Month = { "Month", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" };
            iflers.MyBox(cboMonth, Month);//calling the iflers's my box method to set the combo box

            int year = DateTime.Today.Year;         // getting the actual year
            int endYear = year + 10;                //Adding some more year to it
            cboYear.Items.Add("Year");              //Adding year to comboBox as index 0
            while (year < endYear)                  //Adding years to the comboBox
            {
                cboYear.Items.Add(year);
                year++;
            }
            cboYear.SelectedIndex = 0;              //Setting year as index 0        
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try       //Doing this we catch all the exception that will occur
            {
                if (IsValid()) //Doing validation on every single entries
                {
                    Form1 f1 = new Form1();
                    FirstName = txtFirst.Text;      //setting up value to be gotten in the form1
                    LastName = txtLast.Text;        //setting up value to be gotten in the form1
                    Address1 = txtAdd1.Text;        //setting up value to be gotten in the form1
                    Address2 = txtAdd2.Text;        //setting up value to be gotten in the form1
                    CardType = cboCardType.Text;    //setting up value to be gotten in the form1
                    CardNum = txtCardNum.Text;      //setting up value to be gotten in the form1
                    CSC = txtCSC.Text;              //setting up value to be gotten in the form1
                    Date = cboMonth.Text + "/" + cboYear.Text;//setting up value to be gotten in the form1
                    Email = txtEmail.Text;          //setting up value to be gotten in the form1
              
                    this.Hide();                    //Hiding the form
                }
            }

            catch (FormatException) //Handling format exceptions
            {
                MessageBox.Show(" Formating exception occurs, Please check your entries");
            }
            catch (OverflowException) //Handling overflow exceptions
            {
                MessageBox.Show(" OverFlow exception occurs, Please enter small value");
            }
            catch (Exception ex) //Handling any other exceptions that have not be created yet
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
            }
        }

        //Method to check if there is an entry
        public bool IsPresent(TextBox text, string name)
        {
            if (text.Text == "")
            {
                MessageBox.Show(name + " Is a required field. Enter a data", "Entry Error");
                text.Focus();
                return false;
            }
            return true;
        }

        //Method to check if the entry is an integer
        public bool IsInt(TextBox text, string name)
        {
            long num = 0;
            if (Int64.TryParse(text.Text, out num))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " has to be an int, Please enter an integer ", "Entry error");
                text.Focus();
                return false;
            }
        }

        //Method to check if the entry is in the range set up
        public bool IsInRange(TextBox text, string name, int Required)
        {
            string contening = Convert.ToString(text.Text);
            if (contening.Count() != Required)
            {
                MessageBox.Show(name + " digit has to be equal to " + Required + ".");
                txtFirst.Focus();
                return false;
            }
            return true;
        }

        //Method to check if the combo box has the correct selection
        public bool IsSelected(ComboBox text, string name)
        {
            if (text.SelectedIndex == -1 || text.SelectedIndex == 0)
            {
                MessageBox.Show(name + " Is a required field. Please select a " + name, "Entry Error");
                text.Focus();
                return false;
            }
            return true;
        }

        public bool IsValid()
        {
            return
                IsPresent(txtFirst, "First Name") &&    //Validation on first name
                IsPresent(txtLast, "Last Name") &&      //Validation on last name
                IsPresent(txtAdd1, "Address") &&        //Validation on address 1

                IsSelected(cboCardType, "Card type")&&  //Validation on card type

                //Validation on Card Number
                IsPresent(txtCardNum, "Card Number") &&
                IsInt(txtCardNum, "Card Number")&&
                IsInRange(txtCardNum, "Card Number", 16)&&

                //Validation on CSC number
                IsPresent(txtCSC, "CSC Number") &&
                IsInt(txtCSC, "CSC Number") &&
                IsInRange(txtCSC, "CSC Number", 3) &&
                
                //Validation on Month
                IsSelected(cboMonth,"Month")&&
                IsSelected(cboYear, "Year")&&

                IsPresent(txtEmail, "Email");           //Validation on Email
        }
    }
}
