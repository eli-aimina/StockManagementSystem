namespace SMS
{
    partial class StockInUi
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
            this.siCompanyLebel = new System.Windows.Forms.Label();
            this.siCategoryLebel = new System.Windows.Forms.Label();
            this.siItemLebel = new System.Windows.Forms.Label();
            this.siReorderLebel = new System.Windows.Forms.Label();
            this.siAvailableQuantityLebel = new System.Windows.Forms.Label();
            this.siQuantityLebel = new System.Windows.Forms.Label();
            this.siCompanyComboBox = new System.Windows.Forms.ComboBox();
            this.siCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.siItemComboBox = new System.Windows.Forms.ComboBox();
            this.siReorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.siAvailableQuantityTextBox = new System.Windows.Forms.TextBox();
            this.siQuantityTextBox = new System.Windows.Forms.TextBox();
            this.StockInSaveButton = new System.Windows.Forms.Button();
            this.siDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.siDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // siCompanyLebel
            // 
            this.siCompanyLebel.AutoSize = true;
            this.siCompanyLebel.Location = new System.Drawing.Point(53, 13);
            this.siCompanyLebel.Name = "siCompanyLebel";
            this.siCompanyLebel.Size = new System.Drawing.Size(51, 13);
            this.siCompanyLebel.TabIndex = 0;
            this.siCompanyLebel.Text = "Company";
            this.siCompanyLebel.Click += new System.EventHandler(this.label1_Click);
            // 
            // siCategoryLebel
            // 
            this.siCategoryLebel.AutoSize = true;
            this.siCategoryLebel.Location = new System.Drawing.Point(55, 43);
            this.siCategoryLebel.Name = "siCategoryLebel";
            this.siCategoryLebel.Size = new System.Drawing.Size(49, 13);
            this.siCategoryLebel.TabIndex = 0;
            this.siCategoryLebel.Text = "Category";
            this.siCategoryLebel.Click += new System.EventHandler(this.label2_Click);
            // 
            // siItemLebel
            // 
            this.siItemLebel.AutoSize = true;
            this.siItemLebel.Location = new System.Drawing.Point(77, 73);
            this.siItemLebel.Name = "siItemLebel";
            this.siItemLebel.Size = new System.Drawing.Size(27, 13);
            this.siItemLebel.TabIndex = 0;
            this.siItemLebel.Text = "Item";
            // 
            // siReorderLebel
            // 
            this.siReorderLebel.AutoSize = true;
            this.siReorderLebel.Location = new System.Drawing.Point(27, 106);
            this.siReorderLebel.Name = "siReorderLebel";
            this.siReorderLebel.Size = new System.Drawing.Size(74, 13);
            this.siReorderLebel.TabIndex = 0;
            this.siReorderLebel.Text = "Reorder Level";
            // 
            // siAvailableQuantityLebel
            // 
            this.siAvailableQuantityLebel.AutoSize = true;
            this.siAvailableQuantityLebel.Location = new System.Drawing.Point(12, 137);
            this.siAvailableQuantityLebel.Name = "siAvailableQuantityLebel";
            this.siAvailableQuantityLebel.Size = new System.Drawing.Size(92, 13);
            this.siAvailableQuantityLebel.TabIndex = 0;
            this.siAvailableQuantityLebel.Text = "Available Quantity";
            this.siAvailableQuantityLebel.Click += new System.EventHandler(this.label5_Click);
            // 
            // siQuantityLebel
            // 
            this.siQuantityLebel.AutoSize = true;
            this.siQuantityLebel.Location = new System.Drawing.Point(12, 168);
            this.siQuantityLebel.Name = "siQuantityLebel";
            this.siQuantityLebel.Size = new System.Drawing.Size(89, 13);
            this.siQuantityLebel.TabIndex = 0;
            this.siQuantityLebel.Text = "Stock In Quantity";
            this.siQuantityLebel.Click += new System.EventHandler(this.label6_Click);
            // 
            // siCompanyComboBox
            // 
            this.siCompanyComboBox.FormattingEnabled = true;
            this.siCompanyComboBox.Location = new System.Drawing.Point(110, 10);
            this.siCompanyComboBox.Name = "siCompanyComboBox";
            this.siCompanyComboBox.Size = new System.Drawing.Size(146, 21);
            this.siCompanyComboBox.TabIndex = 1;
            // 
            // siCategoryComboBox
            // 
            this.siCategoryComboBox.FormattingEnabled = true;
            this.siCategoryComboBox.Location = new System.Drawing.Point(110, 43);
            this.siCategoryComboBox.Name = "siCategoryComboBox";
            this.siCategoryComboBox.Size = new System.Drawing.Size(146, 21);
            this.siCategoryComboBox.TabIndex = 1;
            this.siCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // siItemComboBox
            // 
            this.siItemComboBox.FormattingEnabled = true;
            this.siItemComboBox.Location = new System.Drawing.Point(110, 76);
            this.siItemComboBox.Name = "siItemComboBox";
            this.siItemComboBox.Size = new System.Drawing.Size(146, 21);
            this.siItemComboBox.TabIndex = 1;
            this.siItemComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // siReorderLevelTextBox
            // 
            this.siReorderLevelTextBox.Location = new System.Drawing.Point(110, 108);
            this.siReorderLevelTextBox.Name = "siReorderLevelTextBox";
            this.siReorderLevelTextBox.Size = new System.Drawing.Size(146, 20);
            this.siReorderLevelTextBox.TabIndex = 2;
            // 
            // siAvailableQuantityTextBox
            // 
            this.siAvailableQuantityTextBox.Location = new System.Drawing.Point(110, 137);
            this.siAvailableQuantityTextBox.Name = "siAvailableQuantityTextBox";
            this.siAvailableQuantityTextBox.Size = new System.Drawing.Size(146, 20);
            this.siAvailableQuantityTextBox.TabIndex = 2;
            // 
            // siQuantityTextBox
            // 
            this.siQuantityTextBox.Location = new System.Drawing.Point(110, 165);
            this.siQuantityTextBox.Name = "siQuantityTextBox";
            this.siQuantityTextBox.Size = new System.Drawing.Size(146, 20);
            this.siQuantityTextBox.TabIndex = 2;
            // 
            // StockInSaveButton
            // 
            this.StockInSaveButton.Location = new System.Drawing.Point(181, 198);
            this.StockInSaveButton.Name = "StockInSaveButton";
            this.StockInSaveButton.Size = new System.Drawing.Size(75, 23);
            this.StockInSaveButton.TabIndex = 3;
            this.StockInSaveButton.Text = "Save";
            this.StockInSaveButton.UseVisualStyleBackColor = true;
            // 
            // siDataGridView
            // 
            this.siDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.siDataGridView.Location = new System.Drawing.Point(299, 10);
            this.siDataGridView.Name = "siDataGridView";
            this.siDataGridView.Size = new System.Drawing.Size(358, 175);
            this.siDataGridView.TabIndex = 4;
            // 
            // StockInUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.siDataGridView);
            this.Controls.Add(this.StockInSaveButton);
            this.Controls.Add(this.siQuantityTextBox);
            this.Controls.Add(this.siAvailableQuantityTextBox);
            this.Controls.Add(this.siReorderLevelTextBox);
            this.Controls.Add(this.siItemComboBox);
            this.Controls.Add(this.siCategoryComboBox);
            this.Controls.Add(this.siCompanyComboBox);
            this.Controls.Add(this.siQuantityLebel);
            this.Controls.Add(this.siAvailableQuantityLebel);
            this.Controls.Add(this.siReorderLebel);
            this.Controls.Add(this.siItemLebel);
            this.Controls.Add(this.siCategoryLebel);
            this.Controls.Add(this.siCompanyLebel);
            this.Name = "StockInUi";
            this.Text = "StockInUi";
            ((System.ComponentModel.ISupportInitialize)(this.siDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label siCompanyLebel;
        private System.Windows.Forms.Label siCategoryLebel;
        private System.Windows.Forms.Label siItemLebel;
        private System.Windows.Forms.Label siReorderLebel;
        private System.Windows.Forms.Label siAvailableQuantityLebel;
        private System.Windows.Forms.Label siQuantityLebel;
        private System.Windows.Forms.ComboBox siCompanyComboBox;
        private System.Windows.Forms.ComboBox siCategoryComboBox;
        private System.Windows.Forms.ComboBox siItemComboBox;
        private System.Windows.Forms.TextBox siReorderLevelTextBox;
        private System.Windows.Forms.TextBox siAvailableQuantityTextBox;
        private System.Windows.Forms.TextBox siQuantityTextBox;
        private System.Windows.Forms.Button StockInSaveButton;
        private System.Windows.Forms.DataGridView siDataGridView;
    }
}