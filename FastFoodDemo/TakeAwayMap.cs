using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class TakeAwayMap : Form
    {
        public TakeAwayMap()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {  
            
        }

        private void TakeAwayMap_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {

            

            //         string city = textBoxCity.Text;
            //    string state = textBoxState.Text;
            //    try
            //    {
            //        StringBuilder queryAddress = new StringBuilder();
            //        //queryAddress.Append("http://maps.google.com/maps?q=UNCC");
            //        //queryAddress.Append("http://maps.google.com/maps?q=UniversityTerraceDrive");
            //        //queryAddress.Append("http://maps.google.com/maps?q=5guysboardwalk");


            //        if (state.Equals("nc"))
            //        {
            //            if (city.Equals("charlotte"))
            //            {
            //                queryAddress.Append("http://maps.google.com/maps?q=UniversityTerraceDrive");
            //            }
            //        }

            //        if (city != string.Empty)
            //        {
            //            queryAddress.Append(city + "," + "+");
            //        }
            //        if (state != string.Empty)
            //        {
            //            queryAddress.Append(state + "," + "+");
            //        }
            //        webBrowser1.Navigate(queryAddress.ToString());

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message.ToString(), "Error");
            //    }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void btnSearch_Click_2(object sender, EventArgs e)
        {
            string city1 = comboBox1.Text;
            string state1 = comboBox2.Text;

            //string city = textBoxCity.Text;
            //string state = textBoxState.Text;
            try
            {
                StringBuilder queryAddress = new StringBuilder();
                //queryAddress.Append("http://maps.google.com/maps?q=UNCC");
                //queryAddress.Append("http://maps.google.com/maps?q=UniversityTerraceDrive");
                //queryAddress.Append("http://maps.google.com/maps?q=5guysboardwalk");
                

                if (state1.Equals("North Carolina"))
                {
                    if (city1.Equals("Charlotte"))
                    {
                        queryAddress.Append("http://www.bing.com/maps/default.aspx?rtp=~pos.35.307155_-80.723890_Fastfood%20Inn");
                    }
                }
                if (state1.Equals("Florida"))
                {
                    if (city1.Equals("Miami"))
                    {
                        queryAddress.Append("http://www.bing.com/maps/default.aspx?rtp=~pos.25.778379_-80.205963_Fastfood%20Inn");
                    }
                }
                if (state1.Equals("New York"))
                {
                    if (city1.Equals("New York"))
                    {
                        queryAddress.Append("http://www.bing.com/maps/default.aspx?rtp=~pos.40.722660_-73.998375_Fastfood%20Inn");
                    }
                }

                //if (city1 != string.Empty)
                //{
                //    queryAddress.Append(city1 + "," + "+");
                //}
                //if (state1 != string.Empty)
                //{
                //    queryAddress.Append(state1 + "," + "+");
                //}
                webBrowser1.Navigate(queryAddress.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
