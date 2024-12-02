namespace ShoppingListApp
{
    partial class frmAddItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPrice = new System.Windows.Forms.TextBox();
            txtQuantity = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnCancel = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(76, 91);
            txtPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(77, 23);
            txtPrice.TabIndex = 15;
            txtPrice.Tag = "Price";
            txtPrice.Text = "0.00";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new System.Drawing.Point(76, 54);
            txtQuantity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new System.Drawing.Size(52, 23);
            txtQuantity.TabIndex = 14;
            txtQuantity.Tag = "Last Name";
            txtQuantity.Text = "1";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(76, 17);
            txtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(177, 23);
            txtName.TabIndex = 13;
            txtName.Tag = "First Name";
            // 
            // label4
            // 
            label4.Location = new System.Drawing.Point(4, 89);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(72, 27);
            label4.TabIndex = 20;
            label4.Text = "Price:   $";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(4, 52);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(72, 27);
            label3.TabIndex = 19;
            label3.Text = "Quantity:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(4, 15);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(72, 27);
            label2.TabIndex = 18;
            label2.Text = "Item Name:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(121, 131);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(88, 27);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "&Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(27, 131);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(88, 27);
            btnSave.TabIndex = 16;
            btnSave.Text = "&Save";
            btnSave.Click += btnSave_Click;
            // 
            // frmAddItem
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(264, 170);
            ControlBox = false;
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "frmAddItem";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Add Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}