using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        private July julyRoster;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            julyRoster = new July();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int age = int.Parse(txtAge.Text);
            int height = int.Parse(txtHeight.Text);
            double[] times = {
            double.Parse(txtTime1.Text),
            double.Parse(txtTime2.Text),
            double.Parse(txtTime3.Text)
        };

            Horse horse = new Horse(name, age, height, times);
            julyRoster.AddHorse(horse);
            Display();
        }
        // Display roster button click event handler
        private void predict_Click(object sender, EventArgs e)
        {
            Horse favourHorse = julyRoster.Favourite();
          
             MessageBox.Show($"Favourite\n\n\nThe predicted winner is:\n{favourHorse.HorseDetails()}");

        }
        // Display the roster 
        private void Display()
        {
            
            julyRoster.DisplayRoster(nextRosterBox); ;
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void nextRosterBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
