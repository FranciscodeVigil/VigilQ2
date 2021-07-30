using System;
//TShirtOrder.cs
//Programmer: Rob Garner (rgarner7@cnm.edu)
//Date: 10 Mar 2020
//Purpose: Model a TShirt order.
namespace TShirtOrders
{
    /// <summary>
    /// TShirtOrder
    /// Provides a model of a shirt order.
    /// </summary>
    
    //Debugger:Francisco Vigil
    //File Name:VigilQ2
    public class TShirtOrder
    {
        private decimal printAreaInSqIn;
        private int numColors;
        private int numShirts;

        //FV had to give the parameter printAreaInSqIn a default value
        public TShirtOrder(decimal printAreaInSqIn = 1, string firstName = "", string lastName = "", string address = "", bool isLocalPickup = true, int numberOfColors = 1, int numberOfShirts = 1)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            IsLocalPickup = isLocalPickup;
            this.printAreaInSqIn = printAreaInSqIn;
            // FV changed the names of the variables to the correct parameters
            this.numColors = numberOfColors;
            this.numShirts = numberOfShirts ;
            Calc();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public bool IsLocalPickup { get; set; }

        public decimal PrintAreaInSqIn
        {
            get { return printAreaInSqIn; }
            set { printAreaInSqIn = value; Calc(); }
        }


        public int NumColors
        {
            get { return NumColors; }
            // FV Had to change set variable from NumColors to numColors 
            set { numColors = value; Calc(); }
        }

        public int NumShirts
        {
            get { return numShirts; }
            set { numShirts = value; Calc(); }
        }
        // Removed the private from the get method in price.
        public decimal Price { get; set; }

        private void Calc()
        {
            Price = numShirts * (numColors * 2.25M + printAreaInSqIn * .05M);
        }

        public override string ToString()
        {
            return FirstName + " "
                + LastName + " "
                + " Price: " + Price.ToString("c");
        }
    }
}
