namespace View
{
    partial class SearchForm
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
            this.Cance = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // Cance
            // 
            this.Cance.Location = new System.Drawing.Point(373, 338);
            this.Cance.Name = "Cance";
            this.Cance.Size = new System.Drawing.Size(75, 23);
            this.Cance.TabIndex = 5;
            this.Cance.Text = "Cancel";
            this.Cance.UseVisualStyleBackColor = true;
            this.Cance.Click += new System.EventHandler(this.ButtonCanceClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(251, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonSearchClick);
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Location = new System.Drawing.Point(327, 291);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSearch.TabIndex = 2;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(126, 292);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 1;
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.AllowUserToResizeColumns = false;
            this.dataGridViewSearch.AllowUserToResizeRows = false;
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Location = new System.Drawing.Point(49, 72);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.ReadOnly = true;
            this.dataGridViewSearch.Size = new System.Drawing.Size(544, 150);
            this.dataGridViewSearch.TabIndex = 0;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 411);
            this.Controls.Add(this.Cance);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.dataGridViewSearch);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Cance;
    }
}