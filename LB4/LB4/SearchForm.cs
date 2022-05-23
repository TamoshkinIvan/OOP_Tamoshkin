using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Model;

namespace View
{
    /// <summary>
    /// 
    /// </summary>
    public partial class SearchForm : EventForm
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly BindingList<DiscountBase> _dataSource;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataSource"></param>
        public SearchForm(BindingList<DiscountBase> dataSource)
        {
            InitializeComponent();
            _dataSource = dataSource;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchFormLoad(object sender, EventArgs e)
        {
            dataGridViewSearch.RowsDefaultCellStyle.Alignment
                = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewSearch.RowHeadersVisible = false;
            dataGridViewSearch.Width = 603;
            dataGridViewSearch.DataSource = _dataSource;
            dataGridViewSearch.Columns[0].Width = 150;
            dataGridViewSearch.Columns[1].Width = 150;
            dataGridViewSearch.Columns[2].Width = 150;
            dataGridViewSearch.Columns[3].Width = 150;
            foreach (DataGridViewColumn col in dataGridViewSearch.Columns)
            {
                comboBoxSearch.Items.Add(col.Name);
            }
            this.MaximizeBox = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancelClick(object sender, EventArgs e)
        {
            CancelForm?.Invoke(sender, e);
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSearchClick(object sender, EventArgs e)
        {
            var selectedState = "";
            if (comboBoxSearch.SelectedIndex != -1)
            {
                selectedState = comboBoxSearch.SelectedItem.ToString();
                SearchObject(textBoxSearch.Text, selectedState);
            }
            else
            {
                MessageBoxEvent?.Invoke("Пожалуйста, выберите элемент поиска.", e);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="property"></param>
        private void SearchObject(string value, string property)
        {
            dataGridViewSearch.DataSource = _dataSource;
            var foundDiscont = new List<DiscountBase>();
            if (_dataSource.Count == 0)
            {
                MessageBoxEvent?.Invoke("Таблица пуста.", EventArgs.Empty);
            }

            foreach (var discount in _dataSource)
            {
                if (typeof(DiscountBase).
                    GetProperty(property).GetValue(discount).ToString() == value)
                {
                    foundDiscont.Add(discount);
                }
            }

            dataGridViewSearch.DataSource = foundDiscont;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchFormClosed(object sender, FormClosedEventArgs e)
        {
            CloseForm?.Invoke(sender, e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonReloadClick(object sender, EventArgs e)
        {
            dataGridViewSearch.DataSource = _dataSource;
        }

        //TODO:?
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e){}
    }
}
