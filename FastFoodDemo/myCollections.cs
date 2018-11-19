using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
    
    public partial class myCollections : UserControl
    {
        public static Dictionary<string, double> dict = new Dictionary<string, double> {
    //{ "eggburger",7 },
    //{ "chickenburger",5.99 },
    //{ "cheeseballs",2 },
    //{ "pineapplepizza",8.99 },
    //{ "icecream",3.49 },
    //{ "oreotruffle",10 },
    //{ "cheesepizza",15.99 },
    //{ "ratatioulle",8 },
    //{ "pie",2.99 },
    //{ "baconburger",4.59 },
    //{ "margaritapizza",9.99 },
    //{ "panpizza",10.99 },
    //{ "fries",3 },
    //{ "cakeroll",8.99 },
    //{ "pepperonipizza",11.99 },
    //{ "onionrings",10 },
    //{ "steakburger",5.99 },
    //{ "nuggets",5 },
    //{ "cake",7.99 },
    //{ "sausagepizza",9.99 },
    //{ "cheeseburger",7.99 },
    //{ "frenchbackery",7.69 },
    //{ "chickenfries",7.2 },
    //{ "triplecheeseburger",5.99 }

};
        double total = 0;
        List<string> l = new List<string>();
        public myCollections()
        {
            InitializeComponent();
           
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
          
        }

        private void myCollections_Load(object sender, EventArgs e)
        {
            

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Egg_Burger.Visible = true;
            Triple_Cheese_Burger.Visible = true;
            Bacon_Burger.Visible = true;
            CheeseBurger.Visible = true;
            SteakBurger.Visible = true;
            ChickenBurger.Visible = true;
            CheesePizza.Visible = false;
            PepperoniPizza.Visible = false;
            MargaritaPizza.Visible = false;
            Sausage_Pizza.Visible = false;
            Pineapple_Pizza.Visible = false;
            Pan_Pizza.Visible = false;
            Cake.Visible = false;
            French_Bakery.Visible = false;
            Icecream.Visible = false;
            Pie.Visible = false;
            Cake_Roll.Visible = false;
            Oreo_Truffle.Visible = false;
            Fries.Visible = false;
            Nuggets.Visible = false;
            ChickenFries.Visible = false;
            Ratatioulle.Visible = false;
            Onion_Rings.Visible = false;
            CheeseBalls.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Egg_Burger.Visible = false;
            Triple_Cheese_Burger.Visible = false;
            Bacon_Burger.Visible = false;
            CheeseBurger.Visible = false;
            SteakBurger.Visible = false;
            ChickenBurger.Visible = false;
            CheesePizza.Visible = true;
            PepperoniPizza.Visible = true;
            MargaritaPizza.Visible = true;
            Sausage_Pizza.Visible = true;
            Pineapple_Pizza.Visible = true;
            Pan_Pizza.Visible = true;
            Cake.Visible = false;
            French_Bakery.Visible = false;
            Icecream.Visible = false;
            Pie.Visible = false;
            Cake_Roll.Visible = false;
            Oreo_Truffle.Visible = false;
            Fries.Visible = false;
            Nuggets.Visible = false;
            ChickenFries.Visible = false;
            Ratatioulle.Visible = false;
            Onion_Rings.Visible = false;
            CheeseBalls.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Egg_Burger.Visible = false;
            Triple_Cheese_Burger.Visible = false;
            Bacon_Burger.Visible = false;
            CheeseBurger.Visible = false;
            SteakBurger.Visible = false;
            ChickenBurger.Visible = false;
            CheesePizza.Visible = false;
            PepperoniPizza.Visible = false;
            MargaritaPizza.Visible = false;
            Sausage_Pizza.Visible = false;
            Pineapple_Pizza.Visible = false;
            Pan_Pizza.Visible = false;
            Cake.Visible = true;
            French_Bakery.Visible = true;
            Icecream.Visible = true;
            Pie.Visible = true;
            Cake_Roll.Visible = true;
            Oreo_Truffle.Visible = true;
            Fries.Visible = false;
            Nuggets.Visible = false;
            ChickenFries.Visible = false;
            Ratatioulle.Visible = false;
            Onion_Rings.Visible = false;
            CheeseBalls.Visible = false;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Egg_Burger.Visible = false;
            Triple_Cheese_Burger.Visible = false;
            Bacon_Burger.Visible = false;
            CheeseBurger.Visible = false;
            SteakBurger.Visible = false;
            ChickenBurger.Visible = false;
            CheesePizza.Visible = false;
            PepperoniPizza.Visible = false;
            MargaritaPizza.Visible = false;
            Sausage_Pizza.Visible = false;
            Pineapple_Pizza.Visible = false;
            Pan_Pizza.Visible = false;
            Cake.Visible = false;
            French_Bakery.Visible = false;
            Icecream.Visible = false;
            Pie.Visible = false;
            Cake_Roll.Visible = false;
            Oreo_Truffle.Visible = false;
            Fries.Visible = true;
            Nuggets.Visible = true;
            ChickenFries.Visible = true;
            Ratatioulle.Visible = true;
            Onion_Rings.Visible = true;
            CheeseBalls.Visible = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dict["Chicken Burger"] = 5.99;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            dict["Cheese Burger"] = 7.99;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            dict["Fries"] = 3.00f;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            dict["Cake"] = 7.99;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            dict["Chicken Fries"] = 7.20;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            dict["Sausage Pizza"] = 9.99;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            dict["French Bakery"] = 7.69;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dict["Triple Cheese Burger"] = 5.99;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            dict["Cheese Balls"] = 2.00;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            dict["Icecream"] = 3.49;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            dict["Oreo Truffle"] = 10.00;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            dict["Pineapple Pizza"] = 8.99;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dict["Egg Burger"] = 7.00;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dict["Cheese Pizza"] = 15.99;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            dict["Pie"] = 2.99;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            dict["Margarita Pizza"] = 9.99;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            dict["Ratatioulle"] = 8.00;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dict["Bacon Burger"] = 4.59;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            dict["Pan Pizza"] = 10.99;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            dict["Pepperoni Pizza"] = 11.99;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dict["Steak Burger"] = 5.99;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            dict["Cake Roll"] = 8.99;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            dict["Onion Rings"] = 10.00;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            dict["Nuggets"] = 5.00;

            //total = 0;
            //l.RemoveRange(0, l.Count);
            //foreach (var item in dict.Values)
            //{
            //    total += item;
            //}
            //foreach (var item in dict.Keys)
            //{
            //    l.Add(item);
            //}

            //StringBuilder b = new StringBuilder();


            //foreach (string str in l)
            //{
            //    b.Append(str.ToString()).AppendLine();
            //}

            ////MessageBox.Show(b.ToString());
            //string s = b.ToString() + total.ToString();
            //MessageBox.Show(s, "Your total is");
        }

        private void Egg_Burger_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void button29_Click(object sender, EventArgs e)
        //{
        //    total = 0;
        //    l.RemoveRange(0, l.Count);
        //    foreach (var item in dict.Values)
        //    {
        //        total += item;
        //    }
        //    foreach (var item in dict.Keys)
        //    {
        //        l.Add(item);
        //    }

        //    StringBuilder b = new StringBuilder();


        //    foreach (string str in l)
        //    {
        //        b.Append(str.ToString()).AppendLine();
        //    }

        //    //MessageBox.Show(b.ToString());
        //    string s = b.ToString() + total.ToString();
        //    MessageBox.Show(s,"Your total is");
        //}
    }
}
