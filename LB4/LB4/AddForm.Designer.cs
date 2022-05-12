namespace View
{
    partial class AddForm
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
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.textBoxCouponDiscount = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.goodTypeComboBox = new System.Windows.Forms.ComboBox();
            this.discountTypeComboBox = new System.Windows.Forms.ComboBox();
            this.groupBoxData.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.Cancel);
            this.groupBoxData.Controls.Add(this.Add);
            this.groupBoxData.Controls.Add(this.textBoxCouponDiscount);
            this.groupBoxData.Controls.Add(this.textBoxPrice);
            this.groupBoxData.Controls.Add(this.goodTypeComboBox);
            this.groupBoxData.Controls.Add(this.discountTypeComboBox);
            this.groupBoxData.Location = new System.Drawing.Point(12, 12);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(257, 273);
            this.groupBoxData.TabIndex = 1;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "groupBox1";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(162, 220);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(30, 220);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 5;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.ButtonAddClick);
            // 
            // textBoxCouponDiscount
            // 
            this.textBoxCouponDiscount.Location = new System.Drawing.Point(75, 171);
            this.textBoxCouponDiscount.Name = "textBoxCouponDiscount";
            this.textBoxCouponDiscount.Size = new System.Drawing.Size(121, 20);
            this.textBoxCouponDiscount.TabIndex = 4;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(75, 129);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(121, 20);
            this.textBoxPrice.TabIndex = 3;
            // 
            // goodTypeComboBox
            // 
            this.goodTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.goodTypeComboBox.FormattingEnabled = true;
            this.goodTypeComboBox.Location = new System.Drawing.Point(75, 83);
            this.goodTypeComboBox.Name = "goodTypeComboBox";
            this.goodTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.goodTypeComboBox.TabIndex = 2;
            // 
            // discountTypeComboBox
            // 
            this.discountTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.discountTypeComboBox.FormattingEnabled = true;
            this.discountTypeComboBox.Location = new System.Drawing.Point(75, 38);
            this.discountTypeComboBox.Name = "discountTypeComboBox";
            this.discountTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.discountTypeComboBox.Sorted = true;
            this.discountTypeComboBox.TabIndex = 1;
            this.discountTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDiscountTypeSelectedIndexChanged);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 287);
            this.Controls.Add(this.groupBoxData);
            this.Name = "AddForm";
            this.Text = "InputForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddFormFormClosed);
            this.Load += new System.EventHandler(this.AddFormLoad);
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.ComboBox discountTypeComboBox;
        private System.Windows.Forms.TextBox textBoxCouponDiscount;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.ComboBox goodTypeComboBox;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Add;
    }
}