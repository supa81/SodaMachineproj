using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Wallet
    {
        //Member Variables (Has A)
        public List<Coin> Coins;
        Penny penny;
        Nickel nickel;
        Dime dime;
        Quarter quarter;

        //Constructor (Spawner)
        public Wallet()
        {
            Coins = new List<Coin>();
            FillRegister(penny, nickel, dime, quarter);
        }
        //Member Methods (Can Do)
        //Fills wallet with starting money

        private void FillRegister(Penny penny, Nickel nickel, Dime dime, Quarter quarter)
        {
         
        }
    }
}
