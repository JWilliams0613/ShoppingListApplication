namespace ShoppingListApp
{
    partial class frmShoppingListApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDelete = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            lstItems = new System.Windows.Forms.ListBox();
            btnExit = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            btnEdit = new System.Windows.Forms.Button();
            lblTotalItems = new System.Windows.Forms.Label();
            lblSubtotal = new System.Windows.Forms.Label();
            txtTotalItems = new System.Windows.Forms.TextBox();
            txtSubtotal = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(360, 131);
            btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(75, 23);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "&Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(360, 35);
            btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(75, 23);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "&Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // lstItems
            // 
            lstItems.ItemHeight = 15;
            lstItems.Location = new System.Drawing.Point(14, 35);
            lstItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            lstItems.Name = "lstItems";
            lstItems.Size = new System.Drawing.Size(326, 169);
            lstItems.TabIndex = 5;
            // 
            // btnExit
            // 
            btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnExit.Location = new System.Drawing.Point(360, 179);
            btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(75, 23);
            btnExit.TabIndex = 9;
            btnExit.Text = "&Exit";
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(14, 10);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(112, 21);
            label1.TabIndex = 6;
            label1.Text = "Items:";
            label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(360, 83);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(75, 23);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "E&dit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // lblTotalItems
            // 
            lblTotalItems.AutoSize = true;
            lblTotalItems.Location = new System.Drawing.Point(79, 221);
            lblTotalItems.Name = "lblTotalItems";
            lblTotalItems.Size = new System.Drawing.Size(67, 15);
            lblTotalItems.TabIndex = 11;
            lblTotalItems.Text = "Total Items:";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new System.Drawing.Point(79, 250);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new System.Drawing.Size(69, 15);
            lblSubtotal.TabIndex = 12;
            lblSubtotal.Text = "Subtotal:   $";
            // 
            // txtTotalItems
            // 
            txtTotalItems.Location = new System.Drawing.Point(154, 217);
            txtTotalItems.Name = "txtTotalItems";
            txtTotalItems.ReadOnly = true;
            txtTotalItems.Size = new System.Drawing.Size(100, 23);
            txtTotalItems.TabIndex = 13;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new System.Drawing.Point(154, 247);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new System.Drawing.Size(100, 23);
            txtSubtotal.TabIndex = 14;
            // 
            // frmShoppingListApp
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new System.Drawing.Size(470, 274);
            Controls.Add(txtSubtotal);
            Controls.Add(txtTotalItems);
            Controls.Add(lblSubtotal);
            Controls.Add(lblTotalItems);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(lstItems);
            Controls.Add(btnExit);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmShoppingListApp";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Shopping List App";
            Load += frmShoppingListApp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtTotalItems;
        private System.Windows.Forms.TextBox txtSubtotal;
    }
}

