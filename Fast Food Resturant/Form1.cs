using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fast_Food_Resturant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Initialize total amount
            decimal total = 0;

            //Check selected item and calculate based on quantity
            if (rbSandwich.Checked)
            {
                total += 300 * numericSandwich.Value;
            }

            if (rbBurger.Checked)
            {
                total += 600 * numericBurger.Value;
            }

            if (rbFriedchicken.Checked)
            {
                total += 500 * numericFriedchicken.Value;
            }

            if (rbPizza.Checked)
            {
                total += 650 * numericPizza.Value;
            }

            if (rbHotdog.Checked)
            {
                total += 450 * numericHotdog.Value;
            }

            //Add beverage code
            if (clbBeverages.GetItemChecked(0))
                total += 100; // Soft Drinks

            if (clbBeverages.GetItemChecked(1))
                total += 200; //Milkshake

            if (clbBeverages.GetItemChecked(2))
                total += 150; //Juices

            if (clbBeverages.GetItemChecked(3))
                total += 50; //Tea

            if (clbBeverages.GetItemChecked(4))
                total += 80; // Coffee

            //Add Side Dishes code
            if (cbFrenchfries.Checked)
                total += 120; // French fries
            if (cbOnionrings.Checked)
                total += 150; // Onion rings
            if (cbPotatowedges.Checked)
                total += 100; //Salads
            if (cbSalad.Checked)
                total += 130; // Potato wedges

            txtBillvalue.Text = Convert.ToString(total);
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            int Pay_Amount = Convert.ToInt32(txtPayamount.Text);
            int Total_Bill = Convert.ToInt32(txtBillvalue.Text);
            int Balance = Pay_Amount - Total_Bill;
            txtBalance.Text = Convert.ToString(Balance);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
