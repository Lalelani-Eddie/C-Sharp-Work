using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;

namespace Project1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    class Horse
    {
        // Fields
        public string Name { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public double[] Times { get; set; }

        // Constructors

        // Default constructor
        public Horse()
        {
            
        }

        //Parameter Constructor
        public Horse(string name, int age, int height, double[] times)
        {
            Name = name;
            Age = age;
            Height = height;
            Times = times;
        }

        // Methods
        public double AverageTime()
        {
            int timeArrLen = Times.Length;
            double tempTime = Times[timeArrLen - 1] + Times[timeArrLen - 2] + Times[timeArrLen - 3];
            return Math.Round((tempTime / 3), 2);
        }

        public string HorseDetails()
        {
            return $"Name: {Name}  Age: {Age} years  Height: {Height} hands    Average run: {AverageTime()} seconds\n\n";
        }
    }

    class July
    {
        // Fields
        private List<Horse> horses = new List<Horse>();

        // Constructor


        //Defualt Constructor
        public July()
        {
           
        }

        // Methods
        public void AddHorse(Horse horse)
        {
            horses.Add(horse);
        }

        public void DisplayRoster(TextBox textBox)
        {
            StringBuilder nextRosterText = new StringBuilder();
            foreach (Horse horse in horses)
            {
                nextRosterText.AppendLine(horse.HorseDetails());
            }

            textBox.Text = nextRosterText.ToString();
        }

        public Horse Favourite()
        {
           
            double suitableTime = double.MaxValue; // intialise average time
            Horse favourHorse = null;

            foreach (Horse horse in horses)
            {
                double currentAverageTime = horse.AverageTime();
                if (currentAverageTime < suitableTime)
                {
                    suitableTime = currentAverageTime;
                    favourHorse = horse;
                }
            }

            return favourHorse;
        }
    }

}
