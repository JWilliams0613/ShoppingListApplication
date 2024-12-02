using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ShoppingListApp
{
    /// <summary>
    /// Represents the main form for managing the shopping list, including adding, editing, deleting, and viewing items.
    /// </summary>
    public partial class frmShoppingListApp : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="frmShoppingListApp"/> class.
        /// </summary>
        public frmShoppingListApp()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The collection of shopping list items.
        /// </summary>
        private List<ShoppingList> shoppingList = null;

        /// <summary>
        /// Handles the form's Load event. Loads the shopping list from the database and updates the list view.
        /// </summary>
        private void frmShoppingListApp_Load(object sender, EventArgs e)
        {
            shoppingList = ShoppingListDB.GetItems();
            updateList();
        }

        /// <summary>
        /// Updates the ListBox to display the current shopping list and calculates the total quantity and subtotal.
        /// </summary>
        private void updateList()
        {
            lstItems.Items.Clear();
            foreach (ShoppingList item in shoppingList)
            {
                lstItems.Items.Add(item.GetDisplayText());
            }
            GetTotalQuantity();
            GetSubtotal();
        }

        /// <summary>
        /// Calculates the total quantity of all items in the shopping list and displays it in the Total Items textbox.
        /// </summary>
        private void GetTotalQuantity()
        {
            int totalQuantity = 0;

            foreach (var item in shoppingList)
            {
                if (int.TryParse(item.Quantity, out int quantity))
                {
                    totalQuantity += quantity;
                }
            }

            txtTotalItems.Text = Convert.ToString(totalQuantity);
        }

        /// <summary>
        /// Calculates the subtotal (Quantity * Price) of all items in the shopping list and displays it in the Subtotal textbox.
        /// </summary>
        private void GetSubtotal()
        {
            decimal subtotal = 0;

            foreach (var item in shoppingList)
            {
                if (int.TryParse(item.Quantity, out int quantity) && decimal.TryParse(item.Price, out decimal price))
                {
                    subtotal += quantity * price;
                }
            }

            txtSubtotal.Text = Convert.ToString(subtotal);
        }

        /// <summary>
        /// Handles the Add button click event. Opens the Add Item form and adds a new item to the shopping list if saved.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var addItemForm = new frmAddItem())
            {
                if (addItemForm.ShowDialog() == DialogResult.OK)
                {
                    ShoppingList newItem = addItemForm.GetNewItem();
                    if (newItem != null)
                    {
                        shoppingList.Add(newItem);
                        ShoppingListDB.SaveShoppingList(shoppingList);
                        updateList();
                    }
                }
            }
        }

        /// <summary>
        /// Handles the Delete button click event. Removes the selected item from the shopping list after confirmation.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedItemIndex = lstItems.SelectedIndex;

            if (selectedItemIndex == -1)
            {
                return;
            }

            ShoppingList chosenItem = shoppingList[selectedItemIndex];
            string confirmMessage = $"Are you sure you want to delete {chosenItem.Name} {chosenItem.Quantity}?";
            DialogResult chosenButton = MessageBox.Show(
                confirmMessage, "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (chosenButton == DialogResult.No)
            {
                return;
            }

            shoppingList.Remove(chosenItem);
            ShoppingListDB.SaveShoppingList(shoppingList);
            updateList();
        }

        /// <summary>
        /// Handles the Exit button click event. Closes the form.
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Edit button click event. Opens the Edit Item form, allowing the user to update the selected item.
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstItems.SelectedIndex >= 0)
            {
                var selectedItem = shoppingList[lstItems.SelectedIndex];
                using (var editItemForm = new frmAddItem())
                {
                    editItemForm.InitializeItem(selectedItem);

                    if (editItemForm.ShowDialog() == DialogResult.OK)
                    {
                        shoppingList[lstItems.SelectedIndex] = editItemForm.NewItem;
                        ShoppingListDB.SaveShoppingList(shoppingList);
                        updateList();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an item to edit.", "Edit Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}