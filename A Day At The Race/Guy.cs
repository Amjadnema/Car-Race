﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Day_At_The_Race
{
    public class Guy
    {
        public string Name; 
        public Bet MyBet; 
        public int Cash; 

        public RadioButton MyRadioButton; 
        public Label MyLabel; 

        public void UpdateLabels()
        {
            MyRadioButton.Text = Name + " has " + Cash + " bucks";
            MyLabel.Text = MyBet.GetDescription(); 
        }


        public void ClearBet()
        {
            PlaceBet(0, 0);
        }


        public bool PlaceBet(int BetAmount, int CarToWin)
        {
            if (BetAmount <= Cash)
            {
                MyBet = new Bet() { Amount = BetAmount, Car = CarToWin, Bettor = this };
                UpdateLabels();
                return true;
            }
            else
            {
                return false;
            }
        }

        
        public void Collect(int Winner)
        {
            Cash += MyBet.PayOut(Winner);
            UpdateLabels();
        }
    }
}
