using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Customer
    {
        //Member Variables (Has A)
        public Wallet Wallet;  
        public Backpack Backpack;
        double change;
        Penny penny;
        Nickel nickel;
        Dime dime;
        Quarter quarter; 

        //Constructor (Spawner)
        public Customer()
        {
            Wallet = new Wallet();
            Backpack = new Backpack();
        }
        //Member Methods (Can Do)

        //This method will be the main logic for a customer to retrieve coins form their wallet.
        //Takes in the selected can for price reference
        //Will need to get user input for coins they would like to add.
        //When all is said and done this method will return a list of coin objects that the customer will use a payment for their soda.
        public List<Coin> GatherCoinsFromWallet(Can selectedCan)
        {// get coins from wallet based on price of soda 
            if (selectedCan.Price > Wallet.Coins.Count)
            {
                Wallet.Coins.Count();
            }
                return null;
        }
        //Returns a coin object from the wallet based on the name passed into it.
        //Returns null if no coin can be found
        public Coin GetCoinFromWallet(string coinName)
        {//if my wallet has the coin name i want to return the coin name if not return null
         //if (coinName = Wallet.Coins.Count(coinName)) 
         //{
         //    return penny;
         //}
         //return null;
            for (int i = 0; i < Wallet.Coins.Count(); i++)
            {
                if (coinName == Wallet.Coins[i].Name )
                {
                    return Wallet.Coins[i];
                }
            }
            return null;
        }        
        public Coin AddCoinsIntoWallet(List<Coin> coinsToAdd)
        {// list of coins added to wallet 
            //Takes in a list of coin objects to add into the customers wallet.
            {
                if (Wallet.Coins.Count > 0 )
                {
                    coinsToAdd.Add(penny);
                    coinsToAdd.Add(nickel);
                    coinsToAdd.Add(dime);
                    coinsToAdd.Add(quarter);
                }
                return null;
                
                
            }
           
        }
        //Takes in a can object to add to the customers backpack.
        public void AddCanToBackpack(Can purchasedCan)
        {// takes can and puts in bag

            Backpack.cans.Add(purchasedCan);
        }
    }
}
