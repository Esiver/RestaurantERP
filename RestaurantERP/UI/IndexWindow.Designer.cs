namespace RestaurantERP
{
    partial class IndexWindow
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
            OpenSalesButton = new Button();
            OpenStockpileButton = new Button();
            storeTitleLabel = new Label();
            storeProductsListBox = new ListBox();
            storeProductListLabel = new Label();
            storeRequiredStockItemsLabel = new Label();
            storeRequiredStockitemsListBox = new ListBox();
            addStoreProductButton = new Button();
            deleteStoreProductButton = new Button();
            editProductButton = new Button();
            SuspendLayout();
            // 
            // OpenSalesButton
            // 
            OpenSalesButton.Location = new Point(517, 74);
            OpenSalesButton.Name = "OpenSalesButton";
            OpenSalesButton.Size = new Size(178, 58);
            OpenSalesButton.TabIndex = 0;
            OpenSalesButton.Text = "Sales Page";
            OpenSalesButton.UseVisualStyleBackColor = true;
            OpenSalesButton.Click += OpenSalesButton_Click;
            // 
            // OpenStockpileButton
            // 
            OpenStockpileButton.Location = new Point(265, 423);
            OpenStockpileButton.Name = "OpenStockpileButton";
            OpenStockpileButton.Size = new Size(163, 64);
            OpenStockpileButton.TabIndex = 1;
            OpenStockpileButton.Text = "Stockpiles Page";
            OpenStockpileButton.UseVisualStyleBackColor = true;
            OpenStockpileButton.Click += OpenStockpilesButton_Click;
            // 
            // storeTitleLabel
            // 
            storeTitleLabel.AutoSize = true;
            storeTitleLabel.ImageAlign = ContentAlignment.TopCenter;
            storeTitleLabel.Location = new Point(53, 33);
            storeTitleLabel.Name = "storeTitleLabel";
            storeTitleLabel.Size = new Size(67, 17);
            storeTitleLabel.TabIndex = 2;
            storeTitleLabel.Text = "Store Title";
            // 
            // storeProductsListBox
            // 
            storeProductsListBox.BorderStyle = BorderStyle.None;
            storeProductsListBox.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            storeProductsListBox.FormattingEnabled = true;
            storeProductsListBox.ItemHeight = 14;
            storeProductsListBox.Location = new Point(53, 90);
            storeProductsListBox.Name = "storeProductsListBox";
            storeProductsListBox.Size = new Size(196, 322);
            storeProductsListBox.TabIndex = 3;
            storeProductsListBox.SelectedIndexChanged += storeProductsListBox_SelectedIndexChanged;
            // 
            // storeProductListLabel
            // 
            storeProductListLabel.AutoSize = true;
            storeProductListLabel.Location = new Point(53, 70);
            storeProductListLabel.Name = "storeProductListLabel";
            storeProductListLabel.Size = new Size(94, 17);
            storeProductListLabel.TabIndex = 4;
            storeProductListLabel.Text = "Store Products";
            storeProductListLabel.Click += label1_Click;
            // 
            // storeRequiredStockItemsLabel
            // 
            storeRequiredStockItemsLabel.AutoSize = true;
            storeRequiredStockItemsLabel.Location = new Point(265, 70);
            storeRequiredStockItemsLabel.Name = "storeRequiredStockItemsLabel";
            storeRequiredStockItemsLabel.Size = new Size(163, 17);
            storeRequiredStockItemsLabel.TabIndex = 5;
            storeRequiredStockItemsLabel.Text = "Store Required Stockitems";
            // 
            // storeRequiredStockitemsListBox
            // 
            storeRequiredStockitemsListBox.BorderStyle = BorderStyle.None;
            storeRequiredStockitemsListBox.Font = new Font("SimSun-ExtB", 9F, FontStyle.Regular, GraphicsUnit.Point);
            storeRequiredStockitemsListBox.FormattingEnabled = true;
            storeRequiredStockitemsListBox.ItemHeight = 12;
            storeRequiredStockitemsListBox.Location = new Point(265, 90);
            storeRequiredStockitemsListBox.Name = "storeRequiredStockitemsListBox";
            storeRequiredStockitemsListBox.Size = new Size(163, 324);
            storeRequiredStockitemsListBox.TabIndex = 6;
            // 
            // addStoreProductButton
            // 
            addStoreProductButton.Location = new Point(53, 423);
            addStoreProductButton.Name = "addStoreProductButton";
            addStoreProductButton.Size = new Size(196, 29);
            addStoreProductButton.TabIndex = 7;
            addStoreProductButton.Text = "Add Product";
            addStoreProductButton.UseVisualStyleBackColor = true;
            // 
            // deleteStoreProductButton
            // 
            deleteStoreProductButton.Location = new Point(53, 493);
            deleteStoreProductButton.Name = "deleteStoreProductButton";
            deleteStoreProductButton.Size = new Size(196, 29);
            deleteStoreProductButton.TabIndex = 8;
            deleteStoreProductButton.Text = "Delete Product";
            deleteStoreProductButton.UseVisualStyleBackColor = true;
            // 
            // editProductButton
            // 
            editProductButton.Location = new Point(53, 458);
            editProductButton.Name = "editProductButton";
            editProductButton.Size = new Size(196, 29);
            editProductButton.TabIndex = 9;
            editProductButton.Text = "Edit Product";
            editProductButton.UseVisualStyleBackColor = true;
            // 
            // IndexWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 573);
            Controls.Add(editProductButton);
            Controls.Add(deleteStoreProductButton);
            Controls.Add(addStoreProductButton);
            Controls.Add(storeRequiredStockitemsListBox);
            Controls.Add(storeRequiredStockItemsLabel);
            Controls.Add(storeProductListLabel);
            Controls.Add(storeProductsListBox);
            Controls.Add(storeTitleLabel);
            Controls.Add(OpenStockpileButton);
            Controls.Add(OpenSalesButton);
            Name = "IndexWindow";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OpenSalesButton;
        private Button OpenStockpileButton;
        private Label storeTitleLabel;
        private ListBox storeProductsListBox;
        private Label storeProductListLabel;
        private Label storeRequiredStockItemsLabel;
        private ListBox storeRequiredStockitemsListBox;
        private Button addStoreProductButton;
        private Button deleteStoreProductButton;
        private Button editProductButton;
    }
}