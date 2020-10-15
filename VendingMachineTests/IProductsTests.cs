using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using VendingMachineInterface;
using Xunit;
using System.Collections.Generic; 

namespace VendingMachineTests
{
    public class IProductsTests
    {
       
        [Fact]
        public void PurchaseComplete()
        {
        //Arrange            
         IProduct iProduct = new Candy(); 
         int moneyPoolPot = 5;
         int price = 4;

         //Act
         bool result = iProduct.PurchaseComplete(moneyPoolPot, price);

         //Assert
         Assert.True(result);
         }

        [Fact]
        public void PurchaseNotComplete()
        {
            //Arrange            
            IProduct iProduct = new Candy();
            int moneyPoolPot = 5;
            int price = 20;

            //Act
            bool result = iProduct.PurchaseComplete(moneyPoolPot, price);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void DepositAnAmountToPot()
        {
            //Arrange
            Vending_Machine vM = new Vending_Machine();
            int expected = 5;

            //Act

            vM.DepositACoin(5);

            //Assert
            Assert.Equal(expected, vM.MoneyPoolPot);
        }


        [Fact]

        public void DepositCoinTest()
        {
            //Arrange            
            Vending_Machine vM = new Vending_Machine(); //instance of the class              
            int coin = 5;

            //Act
            bool result = vM.DepositCoin(coin);
            vM.DepositCoin(5); //Add 5 to pot

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void DepositWrongCoinTest()
        {
            //Arrange
            Vending_Machine vM = new Vending_Machine(); //instance of the class              
            int coin = 6;

            //Act
            bool result = vM.DepositCoin(coin);

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void PurchaseItemTest()
        {
            //Arrange
            Vending_Machine vM = new Vending_Machine(); //instance of the class
            string productCode = "A1";
            string enteredCode = "A1";
            bool expected = true;

            //Act
            var result = vM.PurchaseItem(productCode, enteredCode);

            //Assert
            Assert.Equal(expected, result);
        }


    }

}


