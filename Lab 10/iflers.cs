using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_10
{
    // All the methods that are being used along in the app in the same class
    class iflers
    {

        //Method used to display array as items in a listbox, so that it is easier to change based on what is selected.
        public static void Displayer(ListBox text, string[] Displays)
        {
            text.Items.Clear();             //Clear the the listbox if there is something already in it.
            text.Items.AddRange(Displays); //Display the array as items.
        }

        //Method used to add items to the cart
        public static void selection(ListBox selectZiK, string[] ZikInfo,
            ListBox Summary)
        {
            for (int n = 0; n < ZikInfo.Length; n++)    //Looping over the array
            {
                if (selectZiK.SelectedIndex == n)       //getting the selected items
                {
                    Summary.Items.Add(Convert.ToString(ZikInfo[n])); //Adding it to the items bought listbox
                }
            }
        }

        //Method used to get the total of the items selected to be bought
        public static void PriceCheck(ListBox lstPrice, TextBox txtPrice)
        {
            string[] PriceArray = new string[lstPrice.Items.Count];//Creating an array based on the length of the listbox
            List<double> PriceNum = new List<double>(); //Creating a list collection
            Double sum = 0.0;

            //looping over the listbox and puting its items into an array
            for (int m = 0; m < lstPrice.Items.Count; m++)
            {
                PriceArray[m] = lstPrice.Items[m].ToString();   //Adding the items to the array
            }

            //Looping over the array created early to the get the price of every items
            for (int n = 0; n < PriceArray.Length; n++)
            {
                int PriceIndex = PriceArray[n].IndexOf("$") + 1; //Getting the index of the last element after the $ sign

                //Getting that last element convert it to double and trow it in a list of array.
                PriceNum.Add(Convert.ToDouble(PriceArray[n].Substring(PriceIndex)));
            }
            foreach (double num in PriceNum)     //Looping the array list of price and adding them up.
            {
                sum += num;
            }
            txtPrice.Text = Convert.ToString(sum);      //Converting it and puting it in it textbox
        }

        //Method used to delete the one item at a time in a listbox
        public static void delete(ListBox lstSelected)
        {
            if (lstSelected.SelectedIndex != -1)     //deleting the item
            {
                lstSelected.Items.RemoveAt(lstSelected.SelectedIndex);
            }
            else                                    //if nothing is selected it will then ask to select something
            {
                MessageBox.Show("please select Item to be delected");
            }
        }

        //Method to clear all the listbox
        public static void ClearAll(ListBox lstClear)
        {

            lstClear.Items.Clear();
        }

        //Method used to add string to a combo box
        public static void MyBox(ComboBox ItemContain, string[] ArrayContain)
        {
            foreach (string Item in ArrayContain)
                ItemContain.Items.Add(Item);
            ItemContain.SelectedIndex = 0;
        }

        //Check if the total text box is empty
        public static bool IsEmpty(TextBox textbox, String name)
        {
            if (textbox.Text == "")
            {
                MessageBox.Show(name + " is a empty. Please select something and click on total." +
                    " Or click on Total to make it 0");
                return false;
            }
            return true;
        }
    }
}