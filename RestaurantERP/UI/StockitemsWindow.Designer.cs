namespace RestaurantERP.UI
{
    partial class StockitemsWindow
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
            stockitemWindowLabel = new Label();
            stockitemsListLabel = new Label();
            allStockitemsList = new ListBox();
            button1 = new Button();
            addStockitemButton = new Button();
            textBoxSku = new TextBox();
            textBoxTitle = new TextBox();
            textBoxDescription = new TextBox();
            textBoxOrigin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxBuyprice = new TextBox();
            textBoxVolume = new TextBox();
            textBoxSize = new TextBox();
            textBoxPlacement = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            dateBoxOrigin = new DateTimePicker();
            dateBoxExpire = new DateTimePicker();
            comboBoxStockpile = new ComboBox();
            label11 = new Label();
            SuspendLayout();
            // 
            // stockitemWindowLabel
            // 
            stockitemWindowLabel.AutoSize = true;
            stockitemWindowLabel.Font = new Font("Century", 18F, FontStyle.Regular, GraphicsUnit.Point);
            stockitemWindowLabel.Location = new Point(30, 26);
            stockitemWindowLabel.Name = "stockitemWindowLabel";
            stockitemWindowLabel.Size = new Size(143, 28);
            stockitemWindowLabel.TabIndex = 1;
            stockitemWindowLabel.Text = "Stock Items";
            // 
            // stockitemsListLabel
            // 
            stockitemsListLabel.AutoSize = true;
            stockitemsListLabel.Location = new Point(30, 72);
            stockitemsListLabel.Name = "stockitemsListLabel";
            stockitemsListLabel.Size = new Size(89, 17);
            stockitemsListLabel.TabIndex = 2;
            stockitemsListLabel.Text = "All Stockitems";
            // 
            // allStockitemsList
            // 
            allStockitemsList.FormattingEnabled = true;
            allStockitemsList.ItemHeight = 17;
            allStockitemsList.Location = new Point(30, 92);
            allStockitemsList.Name = "allStockitemsList";
            allStockitemsList.Size = new Size(165, 310);
            allStockitemsList.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(30, 418);
            button1.Name = "button1";
            button1.Size = new Size(165, 23);
            button1.TabIndex = 4;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            // 
            // addStockitemButton
            // 
            addStockitemButton.Location = new Point(222, 418);
            addStockitemButton.Name = "addStockitemButton";
            addStockitemButton.Size = new Size(205, 23);
            addStockitemButton.TabIndex = 5;
            addStockitemButton.Text = "Add Stockitem";
            addStockitemButton.UseVisualStyleBackColor = true;
            addStockitemButton.Click += addStockItemButton_Click;
            // 
            // textBoxSku
            // 
            textBoxSku.Location = new Point(293, 92);
            textBoxSku.Name = "textBoxSku";
            textBoxSku.Size = new Size(134, 23);
            textBoxSku.TabIndex = 6;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(293, 121);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(134, 23);
            textBoxTitle.TabIndex = 7;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(293, 150);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(134, 23);
            textBoxDescription.TabIndex = 8;
            // 
            // textBoxOrigin
            // 
            textBoxOrigin.Location = new Point(293, 179);
            textBoxOrigin.Name = "textBoxOrigin";
            textBoxOrigin.Size = new Size(134, 23);
            textBoxOrigin.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 121);
            label1.Name = "label1";
            label1.Size = new Size(32, 17);
            label1.TabIndex = 10;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 153);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 11;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(212, 92);
            label3.Name = "label3";
            label3.Size = new Size(32, 17);
            label3.TabIndex = 12;
            label3.Text = "SKU";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(212, 179);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 13;
            label4.Text = "Origin";
            // 
            // textBoxBuyprice
            // 
            textBoxBuyprice.Location = new Point(293, 208);
            textBoxBuyprice.Name = "textBoxBuyprice";
            textBoxBuyprice.Size = new Size(134, 23);
            textBoxBuyprice.TabIndex = 14;
            // 
            // textBoxVolume
            // 
            textBoxVolume.Location = new Point(293, 237);
            textBoxVolume.Name = "textBoxVolume";
            textBoxVolume.Size = new Size(134, 23);
            textBoxVolume.TabIndex = 15;
            // 
            // textBoxSize
            // 
            textBoxSize.Location = new Point(293, 266);
            textBoxSize.Name = "textBoxSize";
            textBoxSize.Size = new Size(134, 23);
            textBoxSize.TabIndex = 16;
            // 
            // textBoxPlacement
            // 
            textBoxPlacement.Location = new Point(293, 295);
            textBoxPlacement.Name = "textBoxPlacement";
            textBoxPlacement.Size = new Size(134, 23);
            textBoxPlacement.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(212, 208);
            label5.Name = "label5";
            label5.Size = new Size(61, 17);
            label5.TabIndex = 20;
            label5.Text = "Buy Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(212, 237);
            label6.Name = "label6";
            label6.Size = new Size(52, 17);
            label6.TabIndex = 21;
            label6.Text = "Volume";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(212, 266);
            label7.Name = "label7";
            label7.Size = new Size(75, 17);
            label7.TabIndex = 22;
            label7.Text = "Size (Gram)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(212, 295);
            label8.Name = "label8";
            label8.Size = new Size(67, 17);
            label8.TabIndex = 23;
            label8.Text = "Placement";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(212, 324);
            label9.Name = "label9";
            label9.Size = new Size(75, 17);
            label9.TabIndex = 24;
            label9.Text = "Origin Date";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(212, 353);
            label10.Name = "label10";
            label10.Size = new Size(63, 17);
            label10.TabIndex = 25;
            label10.Text = "Exp. Date";
            // 
            // dateBoxOrigin
            // 
            dateBoxOrigin.Location = new Point(293, 324);
            dateBoxOrigin.Name = "dateBoxOrigin";
            dateBoxOrigin.Size = new Size(134, 23);
            dateBoxOrigin.TabIndex = 26;
            // 
            // dateBoxExpire
            // 
            dateBoxExpire.Location = new Point(293, 353);
            dateBoxExpire.Name = "dateBoxExpire";
            dateBoxExpire.Size = new Size(134, 23);
            dateBoxExpire.TabIndex = 27;
            // 
            // comboBoxStockpile
            // 
            comboBoxStockpile.FormattingEnabled = true;
            comboBoxStockpile.Location = new Point(293, 382);
            comboBoxStockpile.Name = "comboBoxStockpile";
            comboBoxStockpile.Size = new Size(134, 25);
            comboBoxStockpile.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(212, 385);
            label11.Name = "label11";
            label11.Size = new Size(61, 17);
            label11.TabIndex = 29;
            label11.Text = "Stockpile";
            // 
            // StockitemsWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 453);
            Controls.Add(label11);
            Controls.Add(comboBoxStockpile);
            Controls.Add(dateBoxExpire);
            Controls.Add(dateBoxOrigin);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBoxPlacement);
            Controls.Add(textBoxSize);
            Controls.Add(textBoxVolume);
            Controls.Add(textBoxBuyprice);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxOrigin);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxTitle);
            Controls.Add(textBoxSku);
            Controls.Add(addStockitemButton);
            Controls.Add(button1);
            Controls.Add(allStockitemsList);
            Controls.Add(stockitemsListLabel);
            Controls.Add(stockitemWindowLabel);
            Name = "StockitemsWindow";
            Text = "StockitemsWindow";
            Load += StockitemsWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label stockitemWindowLabel;
        private Label stockitemsListLabel;
        private ListBox allStockitemsList;
        private Button button1;
        private Button addStockitemButton;
        private TextBox textBoxSku;
        private TextBox textBoxTitle;
        private TextBox textBoxDescription;
        private TextBox textBoxOrigin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxBuyprice;
        private TextBox textBoxVolume;
        private TextBox textBoxSize;
        private TextBox textBoxPlacement;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private DateTimePicker dateBoxOrigin;
        private DateTimePicker dateBoxExpire;
        private ComboBox comboBoxStockpile;
        private Label label11;
    }
}