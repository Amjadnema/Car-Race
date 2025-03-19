using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Day_At_The_Race
{
    public partial class Form1 : Form
    {
        Greyhound[] greyhound = new Greyhound[4];
        Guy[] guy = new Guy[3];
        Random MyRandomizer = new Random(); 

        public Form1()
        {
            InitializeComponent();

            greyhound[0] = new Greyhound()
            {
                MyPictureBox = car1, 
                StartingPosition = racetrackPictureBox.Left,
                RacetrackLenght = racetrackPictureBox.Width - car1.Width,
                Randomizer = MyRandomizer
            };

            greyhound[1] = new Greyhound()
            {
                MyPictureBox = car2,
                StartingPosition = racetrackPictureBox.Left,
                RacetrackLenght = racetrackPictureBox.Width - car2.Width,
                Randomizer = MyRandomizer
            };

            greyhound[2] = new Greyhound()
            {
                MyPictureBox = car3,
                StartingPosition = racetrackPictureBox.Left,
                RacetrackLenght = racetrackPictureBox.Width - car3.Width,
                Randomizer = MyRandomizer
            };

            greyhound[3] = new Greyhound()
            {
                MyPictureBox = car4,
                StartingPosition = racetrackPictureBox.Left,
                RacetrackLenght = racetrackPictureBox.Width - car4.Width,
                Randomizer = MyRandomizer
            };

            guy[0] = new Guy() { Name = "Ahmed", Cash = 50,MyRadioButton = AhmedRadioButton,MyLabel = AhmedBetLabel };
            guy[1] = new Guy() { Name = "Ali", Cash = 75, MyRadioButton = AliRadioButton, MyLabel = bobBetLabel };
            guy[2] = new Guy() { Name = "Mhmd", Cash = 45, MyRadioButton = MhmdRadioButton, MyLabel = alBetLabel };

            
            minimumBetLabel.Text = "Minimum bet: " + cashBet.Minimum + " bucks";

            refreshGuyState();
        }

        
        public void refreshGuyState()
        {
            for (int i = 0; i < guy.Length; i++)
            {
                guy[i].ClearBet();
            }
        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            name.Text = guy[0].Name;
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            name.Text = guy[1].Name;
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            name.Text = guy[2].Name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (AhmedRadioButton.Checked)
                guy[0].PlaceBet((int)cashBet.Value, (int)dogBet.Value);
            if (AliRadioButton.Checked)
                guy[1].PlaceBet((int)cashBet.Value, (int)dogBet.Value);
            if (MhmdRadioButton.Checked)
                guy[2].PlaceBet((int)cashBet.Value, (int)dogBet.Value);
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            int winningCar = 0;

            for (int i = 0; i < greyhound.Length; i++)
            {
                if (greyhound[i].Run())
                {

                    timer1.Stop();
                    winningCar = i + 1;
                    MessageBox.Show("Car #" + winningCar + " won the race!");
                   

                    for (int b = 0; b < guy.Length; b++)
                    {
                        guy[b].Collect(winningCar);
                    }

                    refreshGuyState();
                    bettingGroup.Enabled = true;
                    break;
                }
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int c = 0; c < greyhound.Length; c++)
            {
                greyhound[c].TakeStartingPosition();
            }

            bettingGroup.Enabled = false;
            timer1.Start();
        }

        private void bettingGroup_Enter(object sender, EventArgs e)
        {

        }
    }
}
