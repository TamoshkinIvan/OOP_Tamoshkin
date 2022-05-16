using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using Model;

namespace View
{
    public partial class MainForm : EventForm
    {

        private BindingList<DiscountBase> _discountList =
            new BindingList<DiscountBase>()
            {
                new DiscountCoupon(GoodsType.ChildrenProducts, 10000, 500),
                new DiscountPercent(GoodsType.Clothes, 800)
            };



        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }


        private void MainFormLoad(object sender, EventArgs e)
        {
            dataGridViewData.RowHeadersVisible = false;
            dataGridViewData.Width = 603;

            dataGridViewData.DataSource = _discountList;

            dataGridViewData.Columns[0].Width = 150;
            dataGridViewData.Columns[1].Width = 150;
            dataGridViewData.Columns[2].Width = 150;
            dataGridViewData.Columns[3].Width = 150;
            dataGridViewData.RowsDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            MinimizeBox = false;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void EventHandler(EventForm form)
        {
            form.CloseForm  += (o, args) =>
            {
                this.Show();
            };
            form.CancelForm += (sender, args) =>
            {
                form.Close();
                this.Show();
            };
            form.MessageBoxEvent += (o, args) =>
            {
                this.ErrorMessageBox(o.ToString());
            };
        }

        private void ErrorMessageBox(string text)
        {
            MessageBox.Show(this,
                text,
                "Error!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
        }

        private void AddDiscountClick(object sender, EventArgs e)
        {
            var addForm = new AddForm();
            addForm.StartPosition = FormStartPosition.CenterScreen;
            addForm.Show();
            this.Hide();

            addForm.DiscountAdded += (o, args)
                =>
            {
                _discountList.Add(args.Discount);
            };
            EventHandler(addForm);

        }

        private void SearchButtonClick(object sender, EventArgs e)
        {
            var searchForm = new SearchForm(_discountList);
            searchForm.StartPosition = FormStartPosition.CenterScreen;
            searchForm.Show();
            this.Hide();
            EventHandler(searchForm);
        }

        private void ButtonDeleteClick(object sender, EventArgs e)
        {
            if (dataGridViewData.SelectedRows.Count == 0)
            {
                ErrorMessageBox("Не выбрана строка для удаления.");
                return;
            }

            foreach (DataGridViewRow row in dataGridViewData.SelectedRows)
            {
                _discountList.RemoveAt(row.Index);
            }

            if (dataGridViewData.RowCount != 0)
            {
                dataGridViewData.Rows[0].Selected = true;
            }
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            var fileBrowser = new SaveFileDialog();
            fileBrowser.Filter = "DiscountBase (*.dc)|*.dc";
            fileBrowser.ShowDialog();
            string path = fileBrowser.FileName;

            var xmlSerialaizer =
                new XmlSerializer(typeof(BindingList<DiscountBase>));

            if (string.IsNullOrEmpty(path))
            {
                return;
            }

            using (var fileWriter = new FileStream(path, FileMode.Create))
            {
                xmlSerialaizer.Serialize(fileWriter, _discountList);
            }
        }

        private void ReadButtonClick(object sender, EventArgs e)
        {
            var fileBrowser = new OpenFileDialog();
            fileBrowser.Filter = "DiscountBase (*.dc)|*.dc";
            fileBrowser.ShowDialog();

            string path = fileBrowser.FileName;

            if (string.IsNullOrEmpty(path))
            {
                return;
            }

            var XmlSerializer =
                new XmlSerializer(typeof(BindingList<DiscountBase>));

            try
            {
                using (var fileReader = new FileStream(path, FileMode.Open))
                {
                    _discountList = (BindingList<DiscountBase>)
                        XmlSerializer.Deserialize(fileReader);

                }

                ;

                dataGridViewData.DataSource = _discountList;

            }
            catch (InvalidOperationException _)
            {
                ErrorMessageBox("Файл поврежден.");
            }
            catch (ArgumentException _)
            {
                ErrorMessageBox("Not valid data in file");
            }
            catch (Exception ex)
            {
                ErrorMessageBox(ex.Message);
            }
            
        }
    }
}
