﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class SodaMachine
    {
        //Member Variables (Has A)
        private List<Coin> _register;
        private List<Can> _inventory;
        Penny penny;
        Nickel nickel;
        Dime dime;
        Quarter quarter;
        OrangeSoda orangeSoda;
        Cola cola;
        RootBeer rootBeer;
        double changeValue;




        //Constructor (Spawner)
        public SodaMachine()
        {

            _register = new List<Coin>();
            _inventory = new List<Can>();
            FillInventory();
            FillRegister();
        }

        //Member Methods (Can Do)

        //A method to fill the sodamachines register with coin objects.
        public void FillRegister()
        {
            for (int coin = 0; coin < 20; coin++)
            {

                _register.Add(quarter);

            }
            for (int coin = 0; coin < 10; coin++)
            {

                _register.Add(dime);

            }

            for (int coin = 0; coin < 20; coin++)
            {

                _register.Add(nickel);

            }

            for (int coin = 0; coin < 50; coin++)
            {
                _register.Add(penny);

            }




            //.add 
            //for loop to add how many instances
        }
        //A method to fill the sodamachines inventory with soda can objects.
        public void FillInventory()
        {
            for (int i = 0; i < 20; i++)
            {
                // add cans here !!!

                _inventory.Add(orangeSoda);
                _inventory.Add(cola);
                _inventory.Add(rootBeer);
            }

        }
        //Method to be called to start a transaction.
        //Takes in a customer which can be passed freely to which ever method needs it.
        public void BeginTransaction(Customer customer)
        {
            bool willProceed = UserInterface.DisplayWelcomeInstructions(_inventory);
            if (willProceed)
            {
                Transaction(customer);
            }
        }

        //This is the main transaction logic think of it like "runGame".  This is where the user will be prompted for the desired soda.
        //grab the desired soda from the inventory.
        //get payment from the user.
        //pass payment to the calculate transaction method to finish up the transaction based on the results.
        private void Transaction(Customer customer)
        {
            Can can;

            if (cola.Name == UserInterface.SodaSelection(_inventory))
            {
                _inventory.Add(cola);
            }
            if  (rootBeer.Name == UserInterface.SodaSelection(_inventory))
            {
                _inventory.Add(rootBeer);
            }
            if (orangeSoda.Name == UserInterface.SodaSelection(_inventory))
            {
                _inventory.Add(orangeSoda);
            }
        }

            //Gets a soda from the inventory based on the name of the soda.
            private Can GetSodaFromInventory(string nameOfSoda)
            {
                bool hasSoda = CheckSodaInventory(nameOfSoda);
                if (hasSoda)
                {
                    for (int i = 0; i < _inventory.Count(); i++)
                    {
                        if (_inventory[i].Name == nameOfSoda)

                        {
                            return _inventory[i];
                        }

                    }
                }
                return null;
            }
        

            //use for loop till we reach first can name ""
            //LIST!!!
            //make helper methods for below 
            //have to check and see if the soda is there by cycling through list with a count???
            //remove from list if there 
            //referense list of cans loop through and see if name of soda name = "string name"

            private bool CheckSodaInventory(string nameOfSoda) //new helper method 
            {

                for (int i = 0; i < _inventory.Count(); i++)
                {
                    if (_inventory[i].Name == nameOfSoda)

                    {
                        return true;
                    }

                }
                return false;
            }

            //This is the main method for calculating the result of the transaction.
            //It takes in the payment from the customer, the soda object they selected, and the customer who is purchasing the soda.
            //This is the method that will determine the following: custmer pays for the sodaa they want
            //If the payment is greater than the price of the soda, and if the sodamachine has enough change to return: Dispense soda, and change to the customer.
            //If the payment is greater than the cost of the soda, but the machine does not have ample change: Dispense payment back to the customer.
            //If the payment is exact to the cost of the soda:  Dispense soda.
            //If the payment does not meet the cost of the soda: dispense payment back to the customer.
            private void CalculateTransaction(List<Coin> payment, Can chosenSoda, Customer customer)
            {
                //customer.Wallet.Coins - chosenSoda.Price
                if (customer.Wallet.Coins.Count() > chosenSoda.Price)
                {
                    //buy soda method??!!!!


                    //there is a list in a wallet 
                    //need helper method to count money in wallet 
                    //use loop to add up total coins in wallet 
                }
            }
            //Takes in the value of the amount of change needed.
            //Attempts to gather all the required coins from the sodamachine's register to make change.
            //Returns the list of coins as change to despense.
            //If the change cannot be made, return null.
            private List<Coin> GatherChange(double changeValue)
            {// totalchange value - coins from soda machin register = change despensed 
                if (changeValue >= TotalCoinValue(_register))
                {

                    this.changeValue = _register.Count - changeValue;
                    return _register;

                }
                else
                {
                    return null;
                }

            }
            //Reusable method to check if the register has a coin of that name.
            //If it does have one, return true.  Else, false.
            private bool RegisterHasCoin(string name)
            {

                if (_register.Contains(penny))
                {
                    return true;
                }
                else if (_register.Contains(nickel))
                {
                    return true;
                }
                else if (_register.Contains(dime))
                {
                    return true;
                }
                else if (_register.Contains(quarter))
                {
                    return true;
                }
                return false;

            }
            //Reusable method to return a coin from the register.
            //Returns null if no coin can be found of that name.
            private Coin GetCoinFromRegister(string name)
            {// check to see if register has money in it if it dont return null
                if (_register.Count <= 0)
                {
                    return null;
                }
                else
                {
                    return null;
                }
            }
            //Takes in the total payment amount and the price of can to return the change amount.
            private double DetermineChange(double totalPayment, double canPrice)
            {// total payment amount - price of item 
                if (canPrice > totalPayment)
                {
                    return changeValue = totalPayment - canPrice;
                }
                else
                {
                    return canPrice;

                }
            }
            //Takes in a list of coins to return the total value of the coins as a double.
            private double TotalCoinValue(List<Coin> payment)
            {// takes in coins to return the totalcoinvalue 
                return TotalCoinValue(payment);
            }
            //Puts a list of coins into the soda machines register.
            private void DepositCoinsIntoRegister(List<Coin> coins)
            {
                _register.Add(penny);
                _register.Add(nickel);
                _register.Add(dime);
                _register.Add(quarter);

            }
        }
    } 
