using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Model;

namespace View
{
    /// <summary>
    /// Класс формы поиска
    /// </summary>
    public partial class SearchForm : EventForm
    {
        /// <summary>
        /// Источник данных 
        /// </summary>
        private readonly BindingList<DiscountBase> _dataSource;

        /// <summary>
        /// Инициализация формы поиска
        /// </summary>
        /// <param name="dataSource"></param>
        public SearchForm(BindingList<DiscountBase> dataSource)
        {
            InitializeComponent();
            _dataSource = dataSource;
        }

        /// <summary>
        /// Загрузка формы поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchFormLoad(object sender, EventArgs e)
        {
            dataGridViewSearch.RowsDefaultCellStyle.Alignment
                = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewSearch.RowHeadersVisible = false;
            //dataGridViewSearch.Width = 603;
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
        /// Реализация отмены
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancelClick(object sender, EventArgs e)
        {
            CancelForm?.Invoke(sender, e);
            
        }

        /// <summary>
        /// Реализация поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSearchClick(object sender, EventArgs e)
        {
            var selectedState = "";
            if (comboBoxSearch.SelectedIndex != -1 )
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
        /// Метод поиска выбранной категории
        /// </summary>
        /// <param name="value"></param>
        /// <param name="property"></param>
        private void SearchObject(string value, string property)
        {
            dataGridViewSearch.DataSource = _dataSource;
            var foundDiscount = new List<DiscountBase>();
            if (_dataSource.Count == 0)
            {
                MessageBoxEvent?.Invoke("Таблица пуста.", EventArgs.Empty);
            }

            foreach (var discount in _dataSource)
            {
                if (typeof(DiscountBase).
                    GetProperty(property).GetValue(discount).ToString() == value)
                {
                    foundDiscount.Add(discount);
                }
            }

            dataGridViewSearch.DataSource = foundDiscount;
        }

        /// <summary>
        /// Реализация закрытия формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchFormClosed(object sender, FormClosedEventArgs e)
        {
            CloseForm?.Invoke(sender, e);
        }

        /// <summary>
        /// Реализация повторной загрузки данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonReloadClick(object sender, EventArgs e)
        {
            dataGridViewSearch.DataSource = _dataSource;
        }
        }
}
