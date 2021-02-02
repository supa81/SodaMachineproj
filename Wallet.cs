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
            
        }
        //Member Methods (Can Do)
        //Fills wallet with starting money

        private void FillWallet()
        {
            for (int coin = 0; coin < 40; coin++)
            {

                Coins.Add(quarter);

            }
            for (int coin = 0; coin < 30; coin++)
            {

                Coins.Add(dime);

            }

            for (int coin = 0; coin < 40; coin++)
            {

                Coins.Add(nickel);

            }

            for (int coin = 0; coin < 10; coin++)
            {
                Coins.Add(penny);


            }

        }
    }
}
