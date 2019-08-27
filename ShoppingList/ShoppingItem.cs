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
        private double amountQuantity;
        private UnitTypes unit;

        /// <summary>
        /// deafult constructor, sets default values by itself
        /// ShoppingItem myItem = new ShoppingItem();
        /// </summary>
        public ShoppingItem() : this("Unknown", 1.0, UnitTypes.piece)
        {

        }

        /// <summary>
        /// initiate the ofject
        /// </summary>
        /// <param name="name">Input, item description</param>
        /// <param name="amountQuantity">Input, item amount or quanitity</param>
        /// <param name="unit">Input, unit type</param>
        public ShoppingItem(string name, double amountQuantity, UnitTypes unit)
        {
            this.description = name;
            this.amountQuantity = this.amountQuantity;
            this.unit = unit;
        }


        /// <summary>
        /// ShoppingItem myItem = new ShoppingItem("Apple");
        /// </summary>
        /// <param name="description"></param>
        public ShoppingItem(string description): this(description, 1.0, UnitTypes.piece)
        {

        }

        /// <summary>
        /// copy constructor, creates an object with values from different object by making a complete copy of the internal reference
        /// </summary>
        /// <param name="theOtherShoppingItem"></param>
        public ShoppingItem(ShoppingItem theOtherShoppingItem)
        {
            description = theOtherShoppingItem.description;
            amountQuantity = theOtherShoppingItem.amountQuantity;
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

        public double AmountQuantity
        {
            get { return amountQuantity; }

            set
            {
                if (value >= 0)
                {
                    amountQuantity = value;
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
            textOut = $"{description,-45} {amountQuantity,6:f2} {unit,-6}";

            return textOut;
        }
    }
}
