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
            this.button1 = new System.Windows.Forms.Button();
            this.CouponDiscountValue = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.GoodType = new System.Windows.Forms.Label();
            this.DiscountType = new System.Windows.Forms.Label();
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
            this.groupBoxData.Controls.Add(this.button1);
            this.groupBoxData.Controls.Add(this.CouponDiscountValue);
            this.groupBoxData.Controls.Add(this.Price);
            this.groupBoxData.Controls.Add(this.GoodType);
            this.groupBoxData.Controls.Add(this.DiscountType);
            this.groupBoxData.Controls.Add(this.Cancel);
            this.groupBoxData.Controls.Add(this.Add);
            this.groupBoxData.Controls.Add(this.textBoxCouponDiscount);
            this.groupBoxData.Controls.Add(this.textBoxPrice);
            this.groupBoxData.Controls.Add(this.goodTypeComboBox);
            this.groupBoxData.Controls.Add(this.discountTypeComboBox);
            this.groupBoxData.Location = new System.Drawing.Point(12, 12);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(316, 289);
            this.groupBoxData.TabIndex = 1;
            this.groupBoxData.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 236);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Random Discount";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.RandomDiscountButtonClick);
            // 
            // CouponDiscountValue
            // 
            this.CouponDiscountValue.AutoSize = true;
            this.CouponDiscountValue.Location = new System.Drawing.Point(96, 170);
            this.CouponDiscountValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CouponDiscountValue.Name = "CouponDiscountValue";
            this.CouponDiscountValue.Size = new System.Drawing.Size(119, 13);
            this.CouponDiscountValue.TabIndex = 10;
            this.CouponDiscountValue.Text = "Coupon Discount Value";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(96, 125);
            this.Price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(31, 13);
            this.Price.TabIndex = 9;
            this.Price.Text = "Price";
            // 
            // GoodType
            // 
            this.GoodType.AutoSize = true;
            this.GoodType.Location = new System.Drawing.Point(96, 76);
            this.GoodType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GoodType.Name = "GoodType";
            this.GoodType.Size = new System.Drawing.Size(60, 13);
            this.GoodType.TabIndex = 8;
            this.GoodType.Text = "Good Type";
            // 
            // DiscountType
            // 
            this.DiscountType.AutoSize = true;
            this.DiscountType.Location = new System.Drawing.Point(96, 28);
            this.DiscountType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DiscountType.Name = "DiscountType";
            this.DiscountType.Size = new System.Drawing.Size(76, 13);
            this.DiscountType.TabIndex = 7;
            this.DiscountType.Text = "Discount Type";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(235, 236);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(7, 236);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 5;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.ButtonAddClick);
            // 
            // textBoxCouponDiscount
            // 
            this.textBoxCouponDiscount.Location = new System.Drawing.Point(98, 186);
            this.textBoxCouponDiscount.Name = "textBoxCouponDiscount";
            this.textBoxCouponDiscount.Size = new System.Drawing.Size(121, 20);
            this.textBoxCouponDiscount.TabIndex = 4;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(98, 141);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(121, 20);
            this.textBoxPrice.TabIndex = 3;
            // 
            // goodTypeComboBox
            // 
            this.goodTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.goodTypeComboBox.FormattingEnabled = true;
            this.goodTypeComboBox.Location = new System.Drawing.Point(98, 93);
            this.goodTypeComboBox.Name = "goodTypeComboBox";
            this.goodTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.goodTypeComboBox.TabIndex = 2;
            // 
            // discountTypeComboBox
            // 
            this.discountTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.discountTypeComboBox.FormattingEnabled = true;
            this.discountTypeComboBox.Location = new System.Drawing.Point(98, 45);
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
            this.ClientSize = new System.Drawing.Size(338, 312);
            this.Controls.Add(this.groupBoxData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Label CouponDiscountValue;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label GoodType;
        private System.Windows.Forms.Label DiscountType;
        private System.Windows.Forms.Button button1;
    }
}