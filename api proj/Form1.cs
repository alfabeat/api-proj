using Microsoft.VisualBasic.Logging;
using System.Collections.Generic;

namespace api_proj
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
            string[] city = { "Tokyo","Beijing", "London", "Mumbai", "Paris", "Istanbul", "Sao Paulo", "Moscow", "Cairo", "Mexico City", "Jakarta", "Seoul", "Karachi", "Los Angeles", "Buenos Aires", "Shanghai", "Rio de Janeiro", "Delhi", "Manila", "Lagos", "Dhaka", "Chicago", "Kolkata", "Bangkok" };
            comboBox1.Items.AddRange(city);
        }
        private async Task LoadImage(int imageNumber = 0)
        {
            var comic = await weatherProcessor.LoadComic( comboBox1.Text);
            int a = 0;
            label2.Text = "condition " + (comic.condition.text);
            label3.Text = ("last updated " + comic.last_updated);
            label4.Text = ("temp c "+ comic.temp_c);
            label5.Text = ("day " + comic.is_day);

        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private async void btbcurr_Click(object sender, EventArgs e)
        { 
            await LoadImage(0);
            
        }
    


    }
}