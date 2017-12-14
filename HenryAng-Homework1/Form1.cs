using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HenryAng_Homework1
{
    public partial class FrmRestaurant : Form
    {
        public FrmRestaurant()
        {
            InitializeComponent();
        }

        private void btnSpecial_Click(object sender, EventArgs e)
        {
            picBoxChefSpecial.Visible = true;    // display chef's special image
            picBoxDailyFish.Visible = false;     // hide daily fish image
            picBoxTodaySoup.Visible = false;     // hide today's soup image

            lblFoodPrice.Text = "Grilled Cheese with Bacon  $8.99"; // set text of food and price
            lblFoodPrice.Visible = true;             // displays food item and price 
        }

        private void btnDailyDish_Click(object sender, EventArgs e)
        {
            picBoxDailyFish.Visible = true;     // display daily fish image
            picBoxChefSpecial.Visible = false;  // hide chef's special image
            picBoxTodaySoup.Visible = false;    // hide today's soup image

            lblFoodPrice.Text = "Wild Sockeye Salmon  $12.99"; // set text of food and price
            lblFoodPrice.Visible = true;           // displays food item and price 
        }

        private void btnTodaySoup_Click(object sender, EventArgs e)
        {
            picBoxTodaySoup.Visible = true;     // display today's soup image
            picBoxChefSpecial.Visible = false;  // hide chef's special image
            picBoxDailyFish.Visible = false;    // hide daily fish image

            lblFoodPrice.Text = "Chicken Noodle Soup  $5.99"; // set text of food and price 
            lblFoodPrice.Visible = true;            // displays food item and price 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
             this.Close();       // closes the form
        }
    }
}
