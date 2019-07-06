namespace SMS
{
    partial class HomeUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CategorySetupButton = new System.Windows.Forms.Button();
            this.CompanySetupButton = new System.Windows.Forms.Button();
            this.ItemSetupButton = new System.Windows.Forms.Button();
            this.StockInButton = new System.Windows.Forms.Button();
            this.StockOutButton = new System.Windows.Forms.Button();
            this.ItemSummaryButton = new System.Windows.Forms.Button();
            this.ViewReportButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ViewReportButton);
            this.groupBox1.Controls.Add(this.ItemSummaryButton);
            this.groupBox1.Controls.Add(this.StockOutButton);
            this.groupBox1.Controls.Add(this.StockInButton);
            this.groupBox1.Controls.Add(this.ItemSetupButton);
            this.groupBox1.Controls.Add(this.CompanySetupButton);
            this.groupBox1.Controls.Add(this.CategorySetupButton);
            this.groupBox1.Location = new System.Drawing.Point(264, 97);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(409, 306);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // CategorySetupButton
            // 
            this.CategorySetupButton.Location = new System.Drawing.Point(136, 24);
            this.CategorySetupButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CategorySetupButton.Name = "CategorySetupButton";
            this.CategorySetupButton.Size = new System.Drawing.Size(145, 30);
            this.CategorySetupButton.TabIndex = 0;
            this.CategorySetupButton.Text = "Category Setup";
            this.CategorySetupButton.UseVisualStyleBackColor = true;
            this.CategorySetupButton.Click += new System.EventHandler(this.CategorySetupButton_Click);
            // 
            // CompanySetupButton
            // 
            this.CompanySetupButton.Location = new System.Drawing.Point(136, 63);
            this.CompanySetupButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CompanySetupButton.Name = "CompanySetupButton";
            this.CompanySetupButton.Size = new System.Drawing.Size(145, 30);
            this.CompanySetupButton.TabIndex = 1;
            this.CompanySetupButton.Text = "Company Setup ";
            this.CompanySetupButton.UseVisualStyleBackColor = true;
            this.CompanySetupButton.Click += new System.EventHandler(this.CompanySetupButton_Click);
            // 
            // ItemSetupButton
            // 
            this.ItemSetupButton.Location = new System.Drawing.Point(136, 101);
            this.ItemSetupButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ItemSetupButton.Name = "ItemSetupButton";
            this.ItemSetupButton.Size = new System.Drawing.Size(145, 30);
            this.ItemSetupButton.TabIndex = 1;
            this.ItemSetupButton.Text = "Item Setup";
            this.ItemSetupButton.UseVisualStyleBackColor = true;
            this.ItemSetupButton.Click += new System.EventHandler(this.ItemSetupButton_Click);
            // 
            // StockInButton
            // 
            this.StockInButton.Location = new System.Drawing.Point(136, 139);
            this.StockInButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StockInButton.Name = "StockInButton";
            this.StockInButton.Size = new System.Drawing.Size(145, 30);
            this.StockInButton.TabIndex = 2;
            this.StockInButton.Text = "Stock In";
            this.StockInButton.UseVisualStyleBackColor = true;
            this.StockInButton.Click += new System.EventHandler(this.StockInButton_Click);
            // 
            // StockOutButton
            // 
            this.StockOutButton.Location = new System.Drawing.Point(136, 177);
            this.StockOutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StockOutButton.Name = "StockOutButton";
            this.StockOutButton.Size = new System.Drawing.Size(145, 30);
            this.StockOutButton.TabIndex = 3;
            this.StockOutButton.Text = "Stock Out";
            this.StockOutButton.UseVisualStyleBackColor = true;
            this.StockOutButton.Click += new System.EventHandler(this.StockOutButton_Click);
            // 
            // ItemSummaryButton
            // 
            this.ItemSummaryButton.Location = new System.Drawing.Point(136, 214);
            this.ItemSummaryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ItemSummaryButton.Name = "ItemSummaryButton";
            this.ItemSummaryButton.Size = new System.Drawing.Size(145, 30);
            this.ItemSummaryButton.TabIndex = 4;
            this.ItemSummaryButton.Text = "Item Summary";
            this.ItemSummaryButton.UseVisualStyleBackColor = true;
            this.ItemSummaryButton.Click += new System.EventHandler(this.ItemSummaryButton_Click);
            // 
            // ViewReportButton
            // 
            this.ViewReportButton.Location = new System.Drawing.Point(136, 252);
            this.ViewReportButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewReportButton.Name = "ViewReportButton";
            this.ViewReportButton.Size = new System.Drawing.Size(145, 30);
            this.ViewReportButton.TabIndex = 5;
            this.ViewReportButton.Text = "View Report";
            this.ViewReportButton.UseVisualStyleBackColor = true;
            this.ViewReportButton.Click += new System.EventHandler(this.ViewReportButton_Click);
            // 
            // HomeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HomeUI";
            this.Text = "HomeUI";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ViewReportButton;
        private System.Windows.Forms.Button ItemSummaryButton;
        private System.Windows.Forms.Button StockOutButton;
        private System.Windows.Forms.Button StockInButton;
        private System.Windows.Forms.Button ItemSetupButton;
        private System.Windows.Forms.Button CompanySetupButton;
        private System.Windows.Forms.Button CategorySetupButton;
    }
}