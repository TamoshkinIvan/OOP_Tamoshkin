using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class SearchForm : EventForm
    {

        private readonly BindingList<DiscountBase> _dataSource;

        public SearchForm(BindingList<DiscountBase> dataSource)
        {
            InitializeComponent();
            _dataSource = dataSource;
        }

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

        private void ButtonCanceClick(object sender, EventArgs e)
        {
            CancelForm?.Invoke(sender, e);
            
        }

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
    }
}
