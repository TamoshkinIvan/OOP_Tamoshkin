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
            this.button1 = new System.Windows.Forms.Button();
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
            this.groupBoxData.Location = new System.Drawing.Point(16, 15);
            this.groupBoxData.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxData.Size = new System.Drawing.Size(421, 356);
            this.groupBoxData.TabIndex = 1;
            this.groupBoxData.TabStop = false;
            // 
            // CouponDiscountValue
            // 
            this.CouponDiscountValue.AutoSize = true;
            this.CouponDiscountValue.Location = new System.Drawing.Point(128, 209);
            this.CouponDiscountValue.Name = "CouponDiscountValue";
            this.CouponDiscountValue.Size = new System.Drawing.Size(147, 16);
            this.CouponDiscountValue.TabIndex = 10;
            this.CouponDiscountValue.Text = "Coupon Discount Value";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(128, 154);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(38, 16);
            this.Price.TabIndex = 9;
            this.Price.Text = "Price";
            // 
            // GoodType
            // 
            this.GoodType.AutoSize = true;
            this.GoodType.Location = new System.Drawing.Point(128, 94);
            this.GoodType.Name = "GoodType";
            this.GoodType.Size = new System.Drawing.Size(76, 16);
            this.GoodType.TabIndex = 8;
            this.GoodType.Text = "Good Type";
            // 
            // DiscountType
            // 
            this.DiscountType.AutoSize = true;
            this.DiscountType.Location = new System.Drawing.Point(128, 35);
            this.DiscountType.Name = "DiscountType";
            this.DiscountType.Size = new System.Drawing.Size(94, 16);
            this.DiscountType.TabIndex = 7;
            this.DiscountType.Text = "Discount Type"; 
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(313, 291);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 28);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(9, 291);
            this.Add.Margin = new System.Windows.Forms.Padding(4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(100, 28);
            this.Add.TabIndex = 5;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.ButtonAddClick);
            // 
            // textBoxCouponDiscount
            // 
            this.textBoxCouponDiscount.Location = new System.Drawing.Point(131, 229);
            this.textBoxCouponDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCouponDiscount.Name = "textBoxCouponDiscount";
            this.textBoxCouponDiscount.Size = new System.Drawing.Size(160, 22);
            this.textBoxCouponDiscount.TabIndex = 4;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(131, 174);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(160, 22);
            this.textBoxPrice.TabIndex = 3;
            // 
            // goodTypeComboBox
            // 
            this.goodTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.goodTypeComboBox.FormattingEnabled = true;
            this.goodTypeComboBox.Location = new System.Drawing.Point(131, 114);
            this.goodTypeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.goodTypeComboBox.Name = "goodTypeComboBox";
            this.goodTypeComboBox.Size = new System.Drawing.Size(160, 24);
            this.goodTypeComboBox.TabIndex = 2;
            // 
            // discountTypeComboBox
            // 
            this.discountTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.discountTypeComboBox.FormattingEnabled = true;
            this.discountTypeComboBox.Location = new System.Drawing.Point(131, 55);
            this.discountTypeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.discountTypeComboBox.Name = "discountTypeComboBox";
            this.discountTypeComboBox.Size = new System.Drawing.Size(160, 24);
            this.discountTypeComboBox.Sorted = true;
            this.discountTypeComboBox.TabIndex = 1;
            this.discountTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDiscountTypeSelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Random Discount";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.RandomDiscountButtonClick);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 384);
            this.Controls.Add(this.groupBoxData);
            this.Margin = new System.Windows.Forms.Padding(4);
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