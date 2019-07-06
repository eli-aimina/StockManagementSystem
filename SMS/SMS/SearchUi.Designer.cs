namespace SMS
{
    partial class SearchUI
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
            this.searchCompanyLebel = new System.Windows.Forms.Label();
            this.searchCategoryLebel = new System.Windows.Forms.Label();
            this.searchCompanyComboBox = new System.Windows.Forms.ComboBox();
            this.searchCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.searchDataGridView = new System.Windows.Forms.DataGridView();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // searchCompanyLebel
            // 
            this.searchCompanyLebel.AutoSize = true;
            this.searchCompanyLebel.Location = new System.Drawing.Point(190, 22);
            this.searchCompanyLebel.Name = "searchCompanyLebel";
            this.searchCompanyLebel.Size = new System.Drawing.Size(51, 13);
            this.searchCompanyLebel.TabIndex = 0;
            this.searchCompanyLebel.Text = "Company";
            // 
            // searchCategoryLebel
            // 
            this.searchCategoryLebel.AutoSize = true;
            this.searchCategoryLebel.Location = new System.Drawing.Point(190, 58);
            this.searchCategoryLebel.Name = "searchCategoryLebel";
            this.searchCategoryLebel.Size = new System.Drawing.Size(49, 13);
            this.searchCategoryLebel.TabIndex = 0;
            this.searchCategoryLebel.Text = "Category";
            // 
            // searchCompanyComboBox
            // 
            this.searchCompanyComboBox.DataSource = this.companyBindingSource;
            this.searchCompanyComboBox.DisplayMember = "Name";
            this.searchCompanyComboBox.FormattingEnabled = true;
            this.searchCompanyComboBox.Location = new System.Drawing.Point(257, 22);
            this.searchCompanyComboBox.Name = "searchCompanyComboBox";
            this.searchCompanyComboBox.Size = new System.Drawing.Size(158, 21);
            this.searchCompanyComboBox.TabIndex = 1;
            this.searchCompanyComboBox.ValueMember = "ID";
            // 
            // searchCategoryComboBox
            // 
            this.searchCategoryComboBox.DataSource = this.categoryBindingSource;
            this.searchCategoryComboBox.DisplayMember = "Name";
            this.searchCategoryComboBox.FormattingEnabled = true;
            this.searchCategoryComboBox.Location = new System.Drawing.Point(257, 55);
            this.searchCategoryComboBox.Name = "searchCategoryComboBox";
            this.searchCategoryComboBox.Size = new System.Drawing.Size(158, 21);
            this.searchCategoryComboBox.TabIndex = 1;
            this.searchCategoryComboBox.ValueMember = "ID";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(340, 93);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchDataGridView
            // 
            this.searchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDataGridView.Location = new System.Drawing.Point(52, 132);
            this.searchDataGridView.Name = "searchDataGridView";
            this.searchDataGridView.Size = new System.Drawing.Size(617, 168);
            this.searchDataGridView.TabIndex = 3;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(SMS.Models.Company);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(SMS.Models.Category);
            // 
            // Search_and_view_item_summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchDataGridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.searchCategoryComboBox);
            this.Controls.Add(this.searchCompanyComboBox);
            this.Controls.Add(this.searchCategoryLebel);
            this.Controls.Add(this.searchCompanyLebel);
            this.Name = "Search_and_view_item_summary";
            this.Text = "Search and view Item summary";
            this.Load += new System.EventHandler(this.SearchUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchCompanyLebel;
        private System.Windows.Forms.Label searchCategoryLebel;
        private System.Windows.Forms.ComboBox searchCompanyComboBox;
        private System.Windows.Forms.ComboBox searchCategoryComboBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView searchDataGridView;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
    }
}