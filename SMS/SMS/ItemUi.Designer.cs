namespace SMS
{
    partial class ItemUi
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
            this.components = new System.ComponentModel.Container();
            this.categoryLebel = new System.Windows.Forms.Label();
            this.companyLabel = new System.Windows.Forms.Label();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.reorderLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.reorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.ItemSaveButton = new System.Windows.Forms.Button();
            this.itemDataGridView = new System.Windows.Forms.DataGridView();
            this.SL_Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryLebel
            // 
            this.categoryLebel.AutoSize = true;
            this.categoryLebel.Location = new System.Drawing.Point(37, 31);
            this.categoryLebel.Name = "categoryLebel";
            this.categoryLebel.Size = new System.Drawing.Size(49, 13);
            this.categoryLebel.TabIndex = 0;
            this.categoryLebel.Text = "Category";
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Location = new System.Drawing.Point(37, 65);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(51, 13);
            this.companyLabel.TabIndex = 0;
            this.companyLabel.Text = "Company";
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(37, 99);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(58, 13);
            this.itemNameLabel.TabIndex = 0;
            this.itemNameLabel.Text = "Item Name";
            // 
            // reorderLabel
            // 
            this.reorderLabel.AutoSize = true;
            this.reorderLabel.Location = new System.Drawing.Point(37, 129);
            this.reorderLabel.Name = "reorderLabel";
            this.reorderLabel.Size = new System.Drawing.Size(74, 13);
            this.reorderLabel.TabIndex = 0;
            this.reorderLabel.Text = "Reorder Level";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = this.categoryBindingSource;
            this.categoryComboBox.DisplayMember = "Name";
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(122, 31);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(154, 21);
            this.categoryComboBox.TabIndex = 1;
            this.categoryComboBox.ValueMember = "ID";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(SMS.Models.Category);
            // 
            // companyComboBox
            // 
            this.companyComboBox.DataSource = this.companyBindingSource;
            this.companyComboBox.DisplayMember = "Name";
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(122, 65);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(154, 21);
            this.companyComboBox.TabIndex = 1;
            this.companyComboBox.ValueMember = "ID";
            this.companyComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(SMS.Models.Company);
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(122, 92);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(154, 20);
            this.itemNameTextBox.TabIndex = 2;
            this.itemNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // reorderLevelTextBox
            // 
            this.reorderLevelTextBox.Location = new System.Drawing.Point(122, 122);
            this.reorderLevelTextBox.Name = "reorderLevelTextBox";
            this.reorderLevelTextBox.Size = new System.Drawing.Size(154, 20);
            this.reorderLevelTextBox.TabIndex = 2;
            // 
            // ItemSaveButton
            // 
            this.ItemSaveButton.Location = new System.Drawing.Point(201, 161);
            this.ItemSaveButton.Name = "ItemSaveButton";
            this.ItemSaveButton.Size = new System.Drawing.Size(75, 23);
            this.ItemSaveButton.TabIndex = 3;
            this.ItemSaveButton.Text = "Save";
            this.ItemSaveButton.UseVisualStyleBackColor = true;
            this.ItemSaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // itemDataGridView
            // 
            this.itemDataGridView.AutoGenerateColumns = false;
            this.itemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL_Item,
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.reorderLevelDataGridViewTextBoxColumn,
            this.categoryIDDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.companyIDDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn});
            this.itemDataGridView.DataSource = this.stockItemBindingSource;
            this.itemDataGridView.Location = new System.Drawing.Point(40, 201);
            this.itemDataGridView.Name = "itemDataGridView";
            this.itemDataGridView.Size = new System.Drawing.Size(529, 150);
            this.itemDataGridView.TabIndex = 4;
            this.itemDataGridView.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.itemDataGridView_RowPrePaint);
            // 
            // SL_Item
            // 
            this.SL_Item.HeaderText = "SL";
            this.SL_Item.Name = "SL_Item";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // reorderLevelDataGridViewTextBoxColumn
            // 
            this.reorderLevelDataGridViewTextBoxColumn.DataPropertyName = "ReorderLevel";
            this.reorderLevelDataGridViewTextBoxColumn.HeaderText = "ReorderLevel";
            this.reorderLevelDataGridViewTextBoxColumn.Name = "reorderLevelDataGridViewTextBoxColumn";
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            this.categoryIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // companyIDDataGridViewTextBoxColumn
            // 
            this.companyIDDataGridViewTextBoxColumn.DataPropertyName = "CompanyID";
            this.companyIDDataGridViewTextBoxColumn.HeaderText = "CompanyID";
            this.companyIDDataGridViewTextBoxColumn.Name = "companyIDDataGridViewTextBoxColumn";
            this.companyIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Company";
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            // 
            // stockItemBindingSource
            // 
            this.stockItemBindingSource.DataSource = typeof(SMS.Models.StockItem);
            // 
            // ItemUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.itemDataGridView);
            this.Controls.Add(this.ItemSaveButton);
            this.Controls.Add(this.reorderLevelTextBox);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.companyComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.reorderLabel);
            this.Controls.Add(this.itemNameLabel);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.categoryLebel);
            this.Name = "ItemUi";
            this.Text = "Item Setup";
            this.Load += new System.EventHandler(this.ItemUi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label categoryLebel;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.Label reorderLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.TextBox reorderLevelTextBox;
        private System.Windows.Forms.Button ItemSaveButton;
        private System.Windows.Forms.DataGridView itemDataGridView;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.BindingSource stockItemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL_Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
    }
}