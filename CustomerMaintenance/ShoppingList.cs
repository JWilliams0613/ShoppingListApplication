using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingListApp
{
    /// <summary>
    /// Represents an item in the shopping list with its name, quantity, and price.
    /// </summary>
    public class ShoppingList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShoppingList"/> class with default values.
        /// </summary>
        public ShoppingList() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShoppingList"/> class with specified values.
        /// </summary>
        /// <param name="name">The name of the item.</param>
        /// <param name="quantity">The quantity of the item.</param>
        /// <param name="price">The price of the item.</param>
        public ShoppingList(string name, string quantity, string price) =>
            (this.Name, this.Quantity, this.Price) = (name, quantity, price);

        /// <summary>
        /// Gets or sets the name of the shopping list item.
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// Gets or sets the quantity of the shopping list item.
        /// </summary>
        public string Quantity { get; set; } = "";

        /// <summary>
        /// Gets or sets the price of the shopping list item.
        /// </summary>
        public string Price { get; set; } = "";

        /// <summary>
        /// Returns a string representation of the shopping list item, 
        /// including its name, quantity, and price.
        /// </summary>
        /// <returns>
        /// A formatted string in the format "Name x Quantity @ $Price".
        /// </returns>
        public string GetDisplayText()
        {
            return Name + " x " + Quantity + " @ $" + Price;
        }
    }
}