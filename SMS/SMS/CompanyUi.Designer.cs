namespace SMS
{
    partial class CompanyUi
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
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.CompanySaveButton = new System.Windows.Forms.Button();
            this.CompanyEditButton = new System.Windows.Forms.Button();
            this.CompanyDeleteButton = new System.Windows.Forms.Button();
            this.companyDataGridView = new System.Windows.Forms.DataGridView();
            this.SL_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.companyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Location = new System.Drawing.Point(51, 24);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(35, 13);
            this.companyNameLabel.TabIndex = 0;
            this.companyNameLabel.Text = "Name";
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.Location = new System.Drawing.Point(92, 24);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(248, 20);
            this.companyNameTextBox.TabIndex = 1;
            // 
            // CompanySaveButton
            // 
            this.CompanySaveButton.Location = new System.Drawing.Point(92, 60);
            this.CompanySaveButton.Name = "CompanySaveButton";
            this.CompanySaveButton.Size = new System.Drawing.Size(64, 23);
            this.CompanySaveButton.TabIndex = 2;
            this.CompanySaveButton.Text = "Save";
            this.CompanySaveButton.UseVisualStyleBackColor = true;
            this.CompanySaveButton.Click += new System.EventHandler(this.CompanySaveButton_Click);
            // 
            // CompanyEditButton
            // 
            this.CompanyEditButton.Location = new System.Drawing.Point(179, 60);
            this.CompanyEditButton.Name = "CompanyEditButton";
            this.CompanyEditButton.Size = new System.Drawing.Size(68, 23);
            this.CompanyEditButton.TabIndex = 3;
            this.CompanyEditButton.Text = "Edit";
            this.CompanyEditButton.UseVisualStyleBackColor = true;
            this.CompanyEditButton.Click += new System.EventHandler(this.CompanyEditButton_Click);
            // 
            // CompanyDeleteButton
            // 
            this.CompanyDeleteButton.Location = new System.Drawing.Point(279, 60);
            this.CompanyDeleteButton.Name = "CompanyDeleteButton";
            this.CompanyDeleteButton.Size = new System.Drawing.Size(61, 23);
            this.CompanyDeleteButton.TabIndex = 4;
            this.CompanyDeleteButton.Text = "Delete";
            this.CompanyDeleteButton.UseVisualStyleBackColor = true;
            this.CompanyDeleteButton.Click += new System.EventHandler(this.CompanyDeleteButton_Click);
            // 
            // companyDataGridView
            // 
            this.companyDataGridView.AutoGenerateColumns = false;
            this.companyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL_column,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.companyDataGridView.DataSource = this.companyBindingSource;
            this.companyDataGridView.Location = new System.Drawing.Point(92, 116);
            this.companyDataGridView.Name = "companyDataGridView";
            this.companyDataGridView.Size = new System.Drawing.Size(248, 150);
            this.companyDataGridView.TabIndex = 5;
            this.companyDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.companyDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.companyDataGridView_RowPostPaint);
            // 
            // SL_column
            // 
            this.SL_column.HeaderText = "SL";
            this.SL_column.Name = "SL_column";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(SMS.Models.Company);
            // 
            // CompanyUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.companyDataGridView);
            this.Controls.Add(this.CompanyDeleteButton);
            this.Controls.Add(this.CompanyEditButton);
            this.Controls.Add(this.CompanySaveButton);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(this.companyNameLabel);
            this.Name = "CompanyUi";
            this.Text = "Company setup";
            this.Load += new System.EventHandler(this.CompanyUi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.Button CompanySaveButton;
        private System.Windows.Forms.Button CompanyEditButton;
        private System.Windows.Forms.Button CompanyDeleteButton;
        private System.Windows.Forms.DataGridView companyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource companyBindingSource;
    }
}