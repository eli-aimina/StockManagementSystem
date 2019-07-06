namespace SMS
{
    partial class CategoryUi
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
            this.categoryNameLebel = new System.Windows.Forms.Label();
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.categoryDataGridView = new System.Windows.Forms.DataGridView();
            this.CategorySL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CategoryEditButton = new System.Windows.Forms.Button();
            this.CategoryDeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryNameLebel
            // 
            this.categoryNameLebel.AutoSize = true;
            this.categoryNameLebel.Location = new System.Drawing.Point(39, 25);
            this.categoryNameLebel.Name = "categoryNameLebel";
            this.categoryNameLebel.Size = new System.Drawing.Size(35, 13);
            this.categoryNameLebel.TabIndex = 0;
            this.categoryNameLebel.Text = "Name";
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.Location = new System.Drawing.Point(96, 25);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(251, 20);
            this.categoryNameTextBox.TabIndex = 1;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(96, 62);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // categoryDataGridView
            // 
            this.categoryDataGridView.AutoGenerateColumns = false;
            this.categoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategorySL,
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.categoryDataGridView.DataSource = this.categoryBindingSource;
            this.categoryDataGridView.Location = new System.Drawing.Point(96, 123);
            this.categoryDataGridView.Name = "categoryDataGridView";
            this.categoryDataGridView.Size = new System.Drawing.Size(251, 150);
            this.categoryDataGridView.TabIndex = 3;
            this.categoryDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.categoryDataGridView_CellContentClick);
            this.categoryDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.categoryDataGridView_RowPostPaint);
            this.categoryDataGridView.Paint += new System.Windows.Forms.PaintEventHandler(this.categoryDataGridView_Paint);
            // 
            // CategorySL
            // 
            this.CategorySL.HeaderText = "SL";
            this.CategorySL.Name = "CategorySL";
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
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(SMS.Models.Category);
            // 
            // CategoryEditButton
            // 
            this.CategoryEditButton.Location = new System.Drawing.Point(188, 62);
            this.CategoryEditButton.Name = "CategoryEditButton";
            this.CategoryEditButton.Size = new System.Drawing.Size(75, 23);
            this.CategoryEditButton.TabIndex = 4;
            this.CategoryEditButton.Text = "Edit";
            this.CategoryEditButton.UseVisualStyleBackColor = true;
            this.CategoryEditButton.Click += new System.EventHandler(this.CategoryEditButton_Click);
            // 
            // CategoryDeleteButton
            // 
            this.CategoryDeleteButton.Location = new System.Drawing.Point(272, 62);
            this.CategoryDeleteButton.Name = "CategoryDeleteButton";
            this.CategoryDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.CategoryDeleteButton.TabIndex = 5;
            this.CategoryDeleteButton.Text = "Delete";
            this.CategoryDeleteButton.UseVisualStyleBackColor = true;
            this.CategoryDeleteButton.Click += new System.EventHandler(this.CategoryDeleteButton_Click);
            // 
            // CategoryUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.CategoryDeleteButton);
            this.Controls.Add(this.CategoryEditButton);
            this.Controls.Add(this.categoryDataGridView);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.categoryNameTextBox);
            this.Controls.Add(this.categoryNameLebel);
            this.Name = "CategoryUi";
            this.Text = "Category setup";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label categoryNameLebel;
        private System.Windows.Forms.TextBox categoryNameTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView categoryDataGridView;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.Button CategoryEditButton;
        private System.Windows.Forms.Button CategoryDeleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategorySL;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}

