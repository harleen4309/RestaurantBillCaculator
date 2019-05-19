using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1HarleenKaur
{
    public partial class RestaurantBillForm : Form
    {
        string strprice;
        string selection;
        double price;
        double tax;
        double total;
        public RestaurantBillForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] beverages = { "Soda - $1.95", "Tea - $1.50", "Coffee - $1.25", "Mineral Water - $2.95", "Juice - $2.50", "Milk - $1.50" };
            String[] appetizers = { "Buffalo Wings - $5.95", "Buffalo Fingers - $6.95", "Potato Skins - $8.95", "Nachos - $8.95", "Mushroom Caps - $10.95", "Shrimp Cocktail - $12.95", "Chips and Salsa - $6.95" };
            String[] mainCourse = { "Seafood Alfredo - $15.95", "Chicken Alfredo - $13.95", "Chicken Picatta - $13.95", "Turkey Club - $11.95", "Lobster Pie - $19.95", "Prime Rib - $20.95", "Shrimp Scampi - $18.95", "Turkey Dinner - $13.95", "Stuffed Chicken - $14.95" };
            String[] desserts = { "Apple Pie - $5.95", "Sundae - $3.95", "Carrot Cake - $5.95", "Mud Pie - $4.95", "Apple Crisp - $5.95" };

            cmbBeverages.Items.AddRange(beverages);
            cmbAppetizers.Items.AddRange(appetizers);
            cmbMainCourses.Items.AddRange(mainCourse);
            cmbDesserts.Items.AddRange(desserts);

            cmbBeverages.Items.Insert(0,"Select Beverage");
            cmbAppetizers.Items.Insert(0,"Select Appetizer");
            cmbMainCourses.Items.Insert(0,"Select Main Course");
            cmbDesserts.Items.Insert(0,"Select Dessert");

            this.cmbBeverages.SelectedIndexChanged -= new System.EventHandler(this.CmbBeverages_SelectedIndexChanged);
            cmbBeverages.SelectedIndex = 0;
            this.cmbBeverages.SelectedIndexChanged += new System.EventHandler(this.CmbBeverages_SelectedIndexChanged);

            this.cmbAppetizers.SelectedIndexChanged -= new System.EventHandler(this.CmbAppetizers_SelectedIndexChanged);
            cmbAppetizers.SelectedIndex = 0;
            this.cmbAppetizers.SelectedIndexChanged += new System.EventHandler(this.CmbAppetizers_SelectedIndexChanged);

            this.cmbMainCourses.SelectedIndexChanged -= new System.EventHandler(this.CmbMainCourses_SelectedIndexChanged);
            cmbMainCourses.SelectedIndex = 0;
            this.cmbMainCourses.SelectedIndexChanged += new System.EventHandler(this.CmbMainCourses_SelectedIndexChanged);

            this.cmbDesserts.SelectedIndexChanged -= new System.EventHandler(this.CmbDesserts_SelectedIndexChanged);
            cmbDesserts.SelectedIndex = 0;
            this.cmbDesserts.SelectedIndexChanged += new System.EventHandler(this.CmbDesserts_SelectedIndexChanged);

            lblStdInfo.Text = "Name:  Harleen Kaur \nStudent ID:  991498957";

            txtBoxSubTotal.Text = price.ToString("C2");
            txtBoxTax.Text = tax.ToString("C2");
            txtBoxTotal.Text = total.ToString("C2");

        }

        private void CmbBeverages_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SelectItems();
            //if (cmbBeverages.SelectedIndex == 0)
            //    listBoxSelection.Items.Clear();
            //else
            //{
            //    listBoxSelection.Items.Add(cmbBeverages.SelectedItem.ToString());

            //    selection = cmbBeverages.SelectedItem.ToString();

            //    strprice = selection.Split('$').Last();
            //    Calculate(strprice);

            //}
            if (cmbBeverages.SelectedIndex != 0)
            {
                listBoxSelection.Items.Add(cmbBeverages.SelectedItem.ToString());

                selection = cmbBeverages.SelectedItem.ToString();

                strprice = selection.Split('$').Last();
                Calculate(strprice);

            }
        }

        private void CmbAppetizers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SelectItems();
            if (cmbAppetizers.SelectedIndex != 0) { 
                //listBoxSelection.Items.Clear();
            //    listBoxSelection.Items.Remove(cmbAppetizers.Items);
            //else
            //{
                listBoxSelection.Items.Add(cmbAppetizers.SelectedItem.ToString());

                selection = cmbAppetizers.SelectedItem.ToString();

                strprice = selection.Split('$').Last();

                Calculate(strprice);

            }
        }

        private void CmbMainCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SelectItems();
            //if (cmbMainCourses.SelectedIndex == 0)
            //    listBoxSelection.Items.Clear();
            //else
            //{
            //    listBoxSelection.Items.Add(cmbMainCourses.SelectedItem.ToString());

            //    selection = cmbMainCourses.SelectedItem.ToString();

            //    strprice = selection.Split('$').Last();

            //    Calculate(strprice);
            //}

            if (cmbMainCourses.SelectedIndex != 0)
               
            {
                listBoxSelection.Items.Add(cmbMainCourses.SelectedItem.ToString());

                selection = cmbMainCourses.SelectedItem.ToString();

                strprice = selection.Split('$').Last();

                Calculate(strprice);
            }
        }

        private void CmbDesserts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SelectItems();
            //if (cmbDesserts.SelectedIndex == 0)
            //    listBoxSelection.Items.Clear();
            //else
            //{
            //    listBoxSelection.Items.Add(cmbDesserts.SelectedItem.ToString());

            //    selection = cmbDesserts.SelectedItem.ToString();

            //    strprice = selection.Split('$').Last();

            //    Calculate(strprice);
            //}

            if (cmbDesserts.SelectedIndex != 0)
             
            {
                listBoxSelection.Items.Add(cmbDesserts.SelectedItem.ToString());

                selection = cmbDesserts.SelectedItem.ToString();

                strprice = selection.Split('$').Last();

                Calculate(strprice);
            }
        }

        public  void Calculate(string strprice)
        {
            price += double.Parse(strprice);
            tax = price * 0.13;
            total = price * 1.13;

            txtBoxSubTotal.Text = price.ToString("C2");
            txtBoxTax.Text = tax.ToString("C2");
            txtBoxTotal.Text = total.ToString("C2");
        }

        private void BtnClearBill_Click(object sender, EventArgs e)
        {
            listBoxSelection.Items.Clear();
            cmbAppetizers.SelectedIndex = 0;
            cmbBeverages.SelectedIndex = 0;
            cmbMainCourses.SelectedIndex = 0;
            cmbDesserts.SelectedIndex = 0;
            price = 0.0;
            tax = 0.0;
            total = 0.0;
            txtBoxSubTotal.Text = price.ToString("C2");
            txtBoxTax.Text = tax.ToString("C2");
            txtBoxTotal.Text = total.ToString("C2");

        }

        private void BtnDeleteItem_Click(object sender, EventArgs e)
        {
            if (listBoxSelection.SelectedIndex >= 0)
            {
                selection = listBoxSelection.SelectedItem.ToString();

                strprice = selection.Split('$').Last();

                price -= double.Parse(strprice);
                tax = price * 0.13;
                total = price * 1.13;

                txtBoxSubTotal.Text = price.ToString("C2");
                txtBoxTax.Text = tax.ToString("C2");
                txtBoxTotal.Text = total.ToString("C2");

                listBoxSelection.Items.Remove(listBoxSelection.SelectedItem);
            }
        }



        //public void SelectItems()
        //{
        //    foreach (Control c in groupBox1.Controls)
        //    {
        //        if (c is ComboBox) { 
        //            if ((c as ComboBox).SelectedIndex == 0)
        //                listBoxSelection.Items.Clear();
        //            else
        //            {
        //                listBoxSelection.Items.Add((c as ComboBox).SelectedItem.ToString());

        //                selection = (c as ComboBox).SelectedItem.ToString();

        //                strprice = selection.Split('$').Last();

        //                Calculate(strprice);
        //            }
        //        }

        //    }
        //}
    }
}
