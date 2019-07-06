namespace SMS
{
    partial class ViewUi
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
            this.fromDateLebel = new System.Windows.Forms.Label();
            this.toDateLebel = new System.Windows.Forms.Label();
            this.FromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SoldRadioButton = new System.Windows.Forms.RadioButton();
            this.DamageRadioButton = new System.Windows.Forms.RadioButton();
            this.LostRadioButton = new System.Windows.Forms.RadioButton();
            this.ViewSearchButton = new System.Windows.Forms.Button();
            this.viewDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.viewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fromDateLebel
            // 
            this.fromDateLebel.AutoSize = true;
            this.fromDateLebel.Location = new System.Drawing.Point(177, 29);
            this.fromDateLebel.Name = "fromDateLebel";
            this.fromDateLebel.Size = new System.Drawing.Size(56, 13);
            this.fromDateLebel.TabIndex = 0;
            this.fromDateLebel.Text = "From Date";
            // 
            // toDateLebel
            // 
            this.toDateLebel.AutoSize = true;
            this.toDateLebel.Location = new System.Drawing.Point(177, 70);
            this.toDateLebel.Name = "toDateLebel";
            this.toDateLebel.Size = new System.Drawing.Size(46, 13);
            this.toDateLebel.TabIndex = 0;
            this.toDateLebel.Text = "To Date";
            // 
            // FromDateTimePicker
            // 
            this.FromDateTimePicker.Location = new System.Drawing.Point(240, 27);
            this.FromDateTimePicker.Name = "FromDateTimePicker";
            this.FromDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.FromDateTimePicker.TabIndex = 1;
            // 
            // ToDateTimePicker
            // 
            this.ToDateTimePicker.Location = new System.Drawing.Point(240, 67);
            this.ToDateTimePicker.Name = "ToDateTimePicker";
            this.ToDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ToDateTimePicker.TabIndex = 2;
            // 
            // SoldRadioButton
            // 
            this.SoldRadioButton.AutoSize = true;
            this.SoldRadioButton.Checked = true;
            this.SoldRadioButton.Location = new System.Drawing.Point(215, 106);
            this.SoldRadioButton.Name = "SoldRadioButton";
            this.SoldRadioButton.Size = new System.Drawing.Size(46, 17);
            this.SoldRadioButton.TabIndex = 3;
            this.SoldRadioButton.TabStop = true;
            this.SoldRadioButton.Text = "Sold";
            this.SoldRadioButton.UseVisualStyleBackColor = true;
            // 
            // DamageRadioButton
            // 
            this.DamageRadioButton.AutoSize = true;
            this.DamageRadioButton.Location = new System.Drawing.Point(303, 106);
            this.DamageRadioButton.Name = "DamageRadioButton";
            this.DamageRadioButton.Size = new System.Drawing.Size(71, 17);
            this.DamageRadioButton.TabIndex = 3;
            this.DamageRadioButton.Text = "Damaged";
            this.DamageRadioButton.UseVisualStyleBackColor = true;
            // 
            // LostRadioButton
            // 
            this.LostRadioButton.AutoSize = true;
            this.LostRadioButton.Location = new System.Drawing.Point(395, 106);
            this.LostRadioButton.Name = "LostRadioButton";
            this.LostRadioButton.Size = new System.Drawing.Size(45, 17);
            this.LostRadioButton.TabIndex = 3;
            this.LostRadioButton.TabStop = true;
            this.LostRadioButton.Text = "Lost";
            this.LostRadioButton.UseVisualStyleBackColor = true;
            // 
            // ViewSearchButton
            // 
            this.ViewSearchButton.Location = new System.Drawing.Point(449, 133);
            this.ViewSearchButton.Name = "ViewSearchButton";
            this.ViewSearchButton.Size = new System.Drawing.Size(75, 23);
            this.ViewSearchButton.TabIndex = 4;
            this.ViewSearchButton.Text = "Search";
            this.ViewSearchButton.UseVisualStyleBackColor = true;
            this.ViewSearchButton.Click += new System.EventHandler(this.ViewSearchButton_Click);
            // 
            // viewDataGridView
            // 
            this.viewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewDataGridView.Location = new System.Drawing.Point(162, 162);
            this.viewDataGridView.Name = "viewDataGridView";
            this.viewDataGridView.Size = new System.Drawing.Size(437, 150);
            this.viewDataGridView.TabIndex = 5;
            // 
            // ViewUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewDataGridView);
            this.Controls.Add(this.ViewSearchButton);
            this.Controls.Add(this.LostRadioButton);
            this.Controls.Add(this.DamageRadioButton);
            this.Controls.Add(this.SoldRadioButton);
            this.Controls.Add(this.ToDateTimePicker);
            this.Controls.Add(this.FromDateTimePicker);
            this.Controls.Add(this.toDateLebel);
            this.Controls.Add(this.fromDateLebel);
            this.Name = "ViewUi";
            this.Text = "View Between Two Dates Report";
            ((System.ComponentModel.ISupportInitialize)(this.viewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fromDateLebel;
        private System.Windows.Forms.Label toDateLebel;
        private System.Windows.Forms.DateTimePicker FromDateTimePicker;
        private System.Windows.Forms.DateTimePicker ToDateTimePicker;
        private System.Windows.Forms.RadioButton SoldRadioButton;
        private System.Windows.Forms.RadioButton DamageRadioButton;
        private System.Windows.Forms.RadioButton LostRadioButton;
        private System.Windows.Forms.Button ViewSearchButton;
        private System.Windows.Forms.DataGridView viewDataGridView;
    }
}