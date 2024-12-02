using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingListApp
{
    /// <summary>
    /// Provides methods to save and retrieve shopping list data from a file.
    /// </summary>
    public static class ShoppingListDB
    {
        /// <summary>
        /// The directory where the shopping list file is stored.
        /// </summary>
        private const string dir = @"..\..\..\";

        /// <summary>
        /// The path to the shopping list file.
        /// </summary>
        private const string path = dir + "ShoppingList.txt";

        /// <summary>
        /// Saves a list of shopping list items to the file.
        /// </summary>
        /// <param name="items">
        /// A list of <see cref="ShoppingList"/> items to be saved.
        /// </param>
        public static void SaveShoppingList(List<ShoppingList> items)
        {
            // Create the output stream for a text file that exists
            StreamWriter textOut =
                new StreamWriter(
                new FileStream(path, FileMode.Create, FileAccess.Write));

            // Write each item
            foreach (ShoppingList item in items)
            {
                textOut.Write(item.Name + "|");
                textOut.Write(item.Quantity + "|");
                textOut.WriteLine(item.Price);
            }

            // Write the end of the document
            textOut.Close();
        }

        /// <summary>
        /// Reads the shopping list items from the file.
        /// </summary>
        /// <returns>
        /// A list of <see cref="ShoppingList"/> objects read from the file.
        /// </returns>
        public static List<ShoppingList> GetItems()
        {
            // If the directory doesn't exist, create it
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            // Create the object for the input stream for a text file
            StreamReader textIn =
                new StreamReader(
                    new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

            // Create the list for items
            List<ShoppingList> items = new List<ShoppingList>();

            // Read the data from the file and store it in the list
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split('|');
                ShoppingList item = new ShoppingList
                {
                    Name = columns[0],
                    Quantity = columns[1],
                    Price = columns[2]
                };
                items.Add(item);
            }

            textIn.Close();

            return items;
        }
    }
}