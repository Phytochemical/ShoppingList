using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList
{
    //TODO one default constructor
    //TODO one constructo with one parameter initialize (description)
    //TODO should call three parameters with this keyword
    //TODO one constructo with three parameter (description, amount, unit)
    //TODO override ToString method -> returns string format with values saved in object ShoppingItem ShoppingItem(string description)
    //TODO ShoppingItem(string name, double amount, UnitTypes unit)
    //TODO ToString(): string
    class ShoppingItem
    {
        private string description;
        private double amount;
        private UnitTypes unit;

        /// <summary>
        /// deafult constructor, sets default values by itself
        /// ShoppingItem myItem = new ShoppingItem();
        /// </summary>
        public ShoppingItem() : this("Unknown", 1.0, UnitTypes.piece)
        {

        }

        /// <summary>
        /// ShoppingItem myItem = new ShoppingItem("Apple");
        /// </summary>
        /// <param name="description"></param>
        public ShoppingItem(string description) : this(description, 1.0, UnitTypes.piece)
        {

        }

        /// <summary>
        /// initiate the ofject
        /// </summary>
        /// <param name="name">Input, item description</param>
        /// <param name="amount">Input, item amount or quanitity</param>
        /// <param name="unit">Input, unit type</param>
        public ShoppingItem(string name, double amount, UnitTypes unit)
        {
            this.description = name;
            this.amount = amount;
            this.unit = unit;
        }

        /// <summary>
        /// copy constructor, creates an object with values from different object by making a complete copy of the internal reference
        /// </summary>
        /// <param name="theOtherShoppingItem"></param>
        public ShoppingItem(ShoppingItem theOtherShoppingItem)
        {
            description = theOtherShoppingItem.description;
            amount = theOtherShoppingItem.amount;
            unit = theOtherShoppingItem.unit;
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrEmpty (value) )
                {
                    description = value;
                }
            }
        }

        public double Amount
        {
            get { return amount; }

            set
            {
                if (value >= 0)
                {
                    amount = value;
                }
            }
        }

        public UnitTypes Unit
        {
            get { return unit; }

            set
            {
                if (Enum.IsDefined ( typeof(UnitTypes), value) )
                {
                    unit = value;
                }
            }
        }

        public override string ToString()
        {
            string textOut = string.Empty;

            textOut = $"{description, -45} {amount, 6:f2} {unit, -6}";

            return textOut;
        }
    }
}
