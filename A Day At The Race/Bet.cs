using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Day_At_The_Race
{
    public class Bet
    {
        public int Amount; 
        public int Car; 
        public Guy Bettor; 


        public string GetDescription()
        {
            if (Amount > 0)
            {
                return Bettor.Name + " bets " + Amount + " on CAR #" + Car;
            }
            else
            {
                return Bettor.Name + " hasn't placed a bet";
            }
        }

     
        public int PayOut(int Winner)
        {
            if(Winner == Car)
            {
                return Amount;
            }
            else
            {
                return -Amount;
            }
        }
    }
}
