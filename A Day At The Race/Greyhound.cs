using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace A_Day_At_The_Race
{
    public class Greyhound
    {
        public int StartingPosition; 
        public int RacetrackLenght; 
        public PictureBox MyPictureBox = null; 
        public int Location = 0; 
        public Random Randomizer; 


        public bool Run()
        {
            Location += Randomizer.Next(4);
            MyPictureBox.Left = StartingPosition + Location;
            MyPictureBox.Refresh();

            if (MyPictureBox.Left >= RacetrackLenght - MyPictureBox.Width+20)
                return true;
            else
                return false;
        }


        public void TakeStartingPosition()
        {

            Location = 0;
            MyPictureBox.Left = StartingPosition;
        }
    }
}
