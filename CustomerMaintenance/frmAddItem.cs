using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShoppingListApp
{
    /// <summary>
    /// Represents the form for adding a new item to the shopping list.
    /// </summary>
    public partial class frmAddItem : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="frmAddItem"/> class.
        /// </summary>
        public frmAddItem()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets the new or edited ShoppingList item.
        /// </summary>
        public ShoppingList NewItem
        {
            get { return item; }
            private set { item = value; }
        }

        // Field to store the shopping list item being created.
        private ShoppingList item = null;

        /// <summary>
        /// Displays the form as a dialog and returns the new ShoppingList item.
        /// </summary>
        /// <returns>A new <see cref="ShoppingList"/> object representing the item added.</returns>
        public ShoppingList GetNewItem()
        {
            this.ShowDialog();
            return item;
        }

        /// <summary>
        /// Initializes the form with an existing ShoppingList item's details.
        /// </summary>
        /// <param name="existingItem">The item to populate the form with.</param>
        public void InitializeItem(ShoppingList existingItem)
        {
            item = existingItem;
            txtName.Text = item.Name;
            txtQuantity.Text = item.Quantity;
            txtPrice.Text = item.Price;
        }

        /// <summary>
        /// Event handler for the Save button click event.
        /// Validates user input and creates a new ShoppingList item if the input is valid.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            errorMessage += Validator.IsPresent(txtName.Text.Trim(), "Name");
            errorMessage += Validator.IsInt32(txtQuantity.Text.Trim(), "Quantity");
            errorMessage += Validator.IsDecimal(txtPrice.Text.Trim(), "Price");

            if (errorMessage != "")
            {
                // Input is invalid; show error message.
                MessageBox.Show(errorMessage, "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;


            // Create a new ShoppingList item using the provided input.
            item = new ShoppingList(txtName.Text.Trim(), txtQuantity.Text.Trim(),
                txtPrice.Text.Trim());
            this.Close();
        }

        /// <summary>
        /// Event handler for the Cancel button click event.
        /// Closes the form without saving any data.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
