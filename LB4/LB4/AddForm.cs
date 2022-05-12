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
    public partial class AddForm : EventForm
    {
        /// <summary>
        /// Data source for DataGrid
        /// </summary>
        private BindingList<DiscountProperties> _dataSource;

        public AddForm()
        {
            InitializeComponent();
        }

        private readonly List<GoodsType> _goodsTypeList = 
            new List<GoodsType>()
            {
                GoodsType.ChildrenProducts,
                GoodsType.Clothes,
                GoodsType.Food

            };

        private readonly List<DiscountType> _discountTypeList =
            new List<DiscountType>()
            {
                DiscountType.Coupon,
                DiscountType.Percent
            };

        private void AddFormLoad(object sender, EventArgs e)
        {
            groupBoxData.Visible = true;
            foreach (var goodType in _goodsTypeList)
            {
                goodTypeComboBox.Items.Add(goodType);
            }
            foreach (var discountType in _discountTypeList)
            {
                discountTypeComboBox.Items.Add(discountType);
            }
            textBoxCouponDiscount.Visible = false;
        }


        private void ButtonAddClick(object sender, EventArgs e)
        {
            if (DataTableAddValidation())
            {
                return;
            }

            try
            {
                var discount = GetDiscount((DiscountType) discountTypeComboBox.SelectedItem,
                    (GoodsType) goodTypeComboBox.SelectedItem,
                    float.Parse(textBoxPrice.Text), float.Parse(textBoxCouponDiscount.Text));
                DiscountAdded.Invoke
                    (this, new DiscountEventArgs(discount));
                this.Close();
            }
            catch (ArgumentException text)
            {
                MessageBoxEvent?.Invoke(text.Message, e);
            }
            catch (Exception text)
            {
                MessageBoxEvent?.Invoke(text.Message, e);
            }
        }

        private bool DataTableAddValidation()
        {
            if (discountTypeComboBox.SelectedIndex == -1)
            {
                MessageBoxEvent?.Invoke(
                    "Пожалуйста, выберите тип скидки.", EventArgs.Empty);
                return true;
            }

            if (goodTypeComboBox.SelectedIndex == -1)
            {
                MessageBoxEvent?.Invoke(
                    "Пожалуйтса, выберите тип товара.", EventArgs.Empty);
                return true;
            }

            return false;

        }

        private void ComboBoxDiscountTypeSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedDiscount = discountTypeComboBox.SelectedItem;
            if (selectedDiscount.ToString() == "Coupon")
            {
                textBoxCouponDiscount.Visible = true;
                textBoxCouponDiscount.Text = "";
            }
            else
            {
                textBoxCouponDiscount.Visible = false;
                textBoxCouponDiscount.Text = "0";
            }
        }


        private DiscountBase GetDiscount(DiscountType discount ,GoodsType good, float price, float discountCoupon)
        {
            switch (discount)
            {
                case DiscountType.Coupon:
                    return new DiscountCoupon(good, price, discountCoupon);
                case DiscountType.Percent:
                    return new DiscountPercent(good, price);
                default:
                    return null;
            }
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            CancelForm?.Invoke(sender, e);
        }

        private void AddFormFormClosed
            (object sender, FormClosedEventArgs e)
        {
            CloseForm?.Invoke(sender, e);
        }
    }
}
