namespace SMS
{
    partial class StockOutUi
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
            this.soCompanyLebel = new System.Windows.Forms.Label();
            this.soCategoryLebel = new System.Windows.Forms.Label();
            this.soItemLebel = new System.Windows.Forms.Label();
            this.soReorderLebel = new System.Windows.Forms.Label();
            this.soAvailableQuantityLebel = new System.Windows.Forms.Label();
            this.soQuantityLebel = new System.Windows.Forms.Label();
            this.soCompanyComboBox = new System.Windows.Forms.ComboBox();
            this.soCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.soItemComboBox = new System.Windows.Forms.ComboBox();
            this.soReorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.soAvailableQuantityTextBox = new System.Windows.Forms.TextBox();
            this.soQuantityTextBox = new System.Windows.Forms.TextBox();
            this.soDataGridView = new System.Windows.Forms.DataGridView();
            this.StockOutSaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.soDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // soCompanyLebel
            // 
            this.soCompanyLebel.AutoSize = true;
            this.soCompanyLebel.Location = new System.Drawing.Point(64, 9);
            this.soCompanyLebel.Name = "soCompanyLebel";
            this.soCompanyLebel.Size = new System.Drawing.Size(51, 13);
            this.soCompanyLebel.TabIndex = 0;
            this.soCompanyLebel.Text = "Company";
            // 
            // soCategoryLebel
            // 
            this.soCategoryLebel.AutoSize = true;
            this.soCategoryLebel.Location = new System.Drawing.Point(66, 42);
            this.soCategoryLebel.Name = "soCategoryLebel";
            this.soCategoryLebel.Size = new System.Drawing.Size(49, 13);
            this.soCategoryLebel.TabIndex = 0;
            this.soCategoryLebel.Text = "Category";
            this.soCategoryLebel.Click += new System.EventHandler(this.label2_Click);
            // 
            // soItemLebel
            // 
            this.soItemLebel.AutoSize = true;
            this.soItemLebel.Location = new System.Drawing.Point(88, 69);
            this.soItemLebel.Name = "soItemLebel";
            this.soItemLebel.Size = new System.Drawing.Size(27, 13);
            this.soItemLebel.TabIndex = 0;
            this.soItemLebel.Text = "Item";
            // 
            // soReorderLebel
            // 
            this.soReorderLebel.AutoSize = true;
            this.soReorderLebel.Location = new System.Drawing.Point(41, 103);
            this.soReorderLebel.Name = "soReorderLebel";
            this.soReorderLebel.Size = new System.Drawing.Size(74, 13);
            this.soReorderLebel.TabIndex = 0;
            this.soReorderLebel.Text = "Reorder Level";
            // 
            // soAvailableQuantityLebel
            // 
            this.soAvailableQuantityLebel.AutoSize = true;
            this.soAvailableQuantityLebel.Location = new System.Drawing.Point(23, 136);
            this.soAvailableQuantityLebel.Name = "soAvailableQuantityLebel";
            this.soAvailableQuantityLebel.Size = new System.Drawing.Size(92, 13);
            this.soAvailableQuantityLebel.TabIndex = 0;
            this.soAvailableQuantityLebel.Text = "Available Quantity";
            this.soAvailableQuantityLebel.Click += new System.EventHandler(this.label5_Click);
            // 
            // soQuantityLebel
            // 
            this.soQuantityLebel.AutoSize = true;
            this.soQuantityLebel.Location = new System.Drawing.Point(23, 170);
            this.soQuantityLebel.Name = "soQuantityLebel";
            this.soQuantityLebel.Size = new System.Drawing.Size(97, 13);
            this.soQuantityLebel.TabIndex = 0;
            this.soQuantityLebel.Text = "Stock Out Quantity";
            // 
            // soCompanyComboBox
            // 
            this.soCompanyComboBox.FormattingEnabled = true;
            this.soCompanyComboBox.Location = new System.Drawing.Point(132, 12);
            this.soCompanyComboBox.Name = "soCompanyComboBox";
            this.soCompanyComboBox.Size = new System.Drawing.Size(145, 21);
            this.soCompanyComboBox.TabIndex = 1;
            // 
            // soCategoryComboBox
            // 
            this.soCategoryComboBox.FormattingEnabled = true;
            this.soCategoryComboBox.Location = new System.Drawing.Point(132, 42);
            this.soCategoryComboBox.Name = "soCategoryComboBox";
            this.soCategoryComboBox.Size = new System.Drawing.Size(145, 21);
            this.soCategoryComboBox.TabIndex = 1;
            // 
            // soItemComboBox
            // 
            this.soItemComboBox.FormattingEnabled = true;
            this.soItemComboBox.Location = new System.Drawing.Point(132, 69);
            this.soItemComboBox.Name = "soItemComboBox";
            this.soItemComboBox.Size = new System.Drawing.Size(145, 21);
            this.soItemComboBox.TabIndex = 1;
            this.soItemComboBox.Text = "te";
            // 
            // soReorderLevelTextBox
            // 
            this.soReorderLevelTextBox.Location = new System.Drawing.Point(132, 103);
            this.soReorderLevelTextBox.Name = "soReorderLevelTextBox";
            this.soReorderLevelTextBox.Size = new System.Drawing.Size(145, 20);
            this.soReorderLevelTextBox.TabIndex = 2;
            // 
            // soAvailableQuantityTextBox
            // 
            this.soAvailableQuantityTextBox.Location = new System.Drawing.Point(132, 136);
            this.soAvailableQuantityTextBox.Name = "soAvailableQuantityTextBox";
            this.soAvailableQuantityTextBox.Size = new System.Drawing.Size(145, 20);
            this.soAvailableQuantityTextBox.TabIndex = 2;
            // 
            // soQuantityTextBox
            // 
            this.soQuantityTextBox.Location = new System.Drawing.Point(132, 167);
            this.soQuantityTextBox.Name = "soQuantityTextBox";
            this.soQuantityTextBox.Size = new System.Drawing.Size(145, 20);
            this.soQuantityTextBox.TabIndex = 2;
            // 
            // soDataGridView
            // 
            this.soDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.soDataGridView.Location = new System.Drawing.Point(355, 12);
            this.soDataGridView.Name = "soDataGridView";
            this.soDataGridView.Size = new System.Drawing.Size(326, 175);
            this.soDataGridView.TabIndex = 3;
            // 
            // StockOutSaveButton
            // 
            this.StockOutSaveButton.Location = new System.Drawing.Point(202, 204);
            this.StockOutSaveButton.Name = "StockOutSaveButton";
            this.StockOutSaveButton.Size = new System.Drawing.Size(75, 23);
            this.StockOutSaveButton.TabIndex = 4;
            this.StockOutSaveButton.Text = "Save";
            this.StockOutSaveButton.UseVisualStyleBackColor = true;
            // 
            // StockOutUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StockOutSaveButton);
            this.Controls.Add(this.soDataGridView);
            this.Controls.Add(this.soQuantityTextBox);
            this.Controls.Add(this.soAvailableQuantityTextBox);
            this.Controls.Add(this.soReorderLevelTextBox);
            this.Controls.Add(this.soItemComboBox);
            this.Controls.Add(this.soCategoryComboBox);
            this.Controls.Add(this.soCompanyComboBox);
            this.Controls.Add(this.soQuantityLebel);
            this.Controls.Add(this.soAvailableQuantityLebel);
            this.Controls.Add(this.soReorderLebel);
            this.Controls.Add(this.soItemLebel);
            this.Controls.Add(this.soCategoryLebel);
            this.Controls.Add(this.soCompanyLebel);
            this.Name = "StockOutUi";
            this.Text = "Stock Out ";
            ((System.ComponentModel.ISupportInitialize)(this.soDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label soCompanyLebel;
        private System.Windows.Forms.Label soCategoryLebel;
        private System.Windows.Forms.Label soItemLebel;
        private System.Windows.Forms.Label soReorderLebel;
        private System.Windows.Forms.Label soAvailableQuantityLebel;
        private System.Windows.Forms.Label soQuantityLebel;
        private System.Windows.Forms.ComboBox soCompanyComboBox;
        private System.Windows.Forms.ComboBox soCategoryComboBox;
        private System.Windows.Forms.ComboBox soItemComboBox;
        private System.Windows.Forms.TextBox soReorderLevelTextBox;
        private System.Windows.Forms.TextBox soAvailableQuantityTextBox;
        private System.Windows.Forms.TextBox soQuantityTextBox;
        private System.Windows.Forms.DataGridView soDataGridView;
        private System.Windows.Forms.Button StockOutSaveButton;
    }
}