using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Model;

namespace View
{
    /// <summary>
    /// Реализация класса AddForm
    /// </summary>
    public partial class AddForm : EventForm
    {
        /// <summary>
        /// Инициализация формы 
        /// </summary>
        public AddForm()
        {
            InitializeComponent();
            #if !DEBUG
            button1.Visible = false;
            #endif
        }

        public EventHandler<DiscountEventArgs> DiscountAdded;

        /// <summary>
        /// Список товаров
        /// </summary>
        private readonly List<GoodsType> _goodsTypeList = 
            new List<GoodsType>()
            {
                GoodsType.ChildrenProducts,
                GoodsType.Clothes,
                GoodsType.Food
            };

        /// <summary>
        /// Список скидок
        /// </summary>
        private readonly List<DiscountType> _discountTypeList =
            new List<DiscountType>()
            {
                Model.DiscountType.Coupon,
                Model.DiscountType.Percent
            };

        /// <summary>
        /// Реализация загрузки формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            CouponDiscountValue.Visible = false;
        }

        /// <summary>
        /// Реализация добавления скидки в список
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Реализация проверки выбранных параметров на форме
        /// </summary>
        /// <returns></returns>
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

            if (string.IsNullOrEmpty(textBoxPrice.Text)
                || string.IsNullOrWhiteSpace(textBoxPrice.Text))
            {
                MessageBoxEvent?.Invoke(
                    "Пожалуйста, укажите цену товара.", EventArgs.Empty);
                return true;
            }

            if (string.IsNullOrEmpty(textBoxCouponDiscount.Text)
                || string.IsNullOrWhiteSpace(textBoxCouponDiscount.Text))
            {
                MessageBoxEvent?.Invoke(
                    "Пожалуйста, укажите величину скидки по купону.", EventArgs.Empty);
                return true;
            }
            return false;

        }

        /// <summary>
        /// Описание работы Combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxDiscountTypeSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedDiscount = discountTypeComboBox.SelectedItem;
            if (selectedDiscount.ToString() == "Coupon")
            {
                textBoxCouponDiscount.Visible = true;
                CouponDiscountValue.Visible = true;
                textBoxCouponDiscount.Text = "";
            }
            else
            {
                textBoxCouponDiscount.Visible = false;
                CouponDiscountValue.Visible = false;
                textBoxCouponDiscount.Text = "0";
            }
        }

        /// <summary>
        /// Метод добавления экземпляра класса DiscountBase
        /// </summary>
        /// <param name="discount"></param>
        /// <param name="good"></param>
        /// <param name="price"></param>
        /// <param name="discountCoupon"></param>
        /// <returns>Экземпляр класса DiscountBase</returns>
        private DiscountBase GetDiscount(DiscountType discount ,GoodsType good, float price, float discountCoupon)
        {
            switch (discount)
            {
                case Model.DiscountType.Coupon:
                    return new DiscountCoupon(good, price, discountCoupon);
                case Model.DiscountType.Percent:
                    return new DiscountPercent(good, price);
                default:
                    return null;
            }
        }

        /// <summary>
        /// Реализация работы отмены действия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButtonClick(object sender, EventArgs e)
        {
            CancelForm?.Invoke(sender, e);
        }

        /// <summary>
        /// Реалиация закрытия формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddFormFormClosed
            (object sender, FormClosedEventArgs e)
        {
            CloseForm?.Invoke(sender, e);
        }

        /// <summary>
        /// Реализация добавления рандомного экземпляра
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RandomDiscountButtonClick(object sender, EventArgs e)
        {
            var rnd = new Random();
            var discountType = _discountTypeList[rnd.Next(0, _discountTypeList.Count)];
            var goodType = _goodsTypeList[rnd.Next(0, _goodsTypeList.Count)];
            var discountRandom = GetDiscount(discountType, goodType,
                rnd.Next(0, 10000), rnd.Next(0, 1000));
            DiscountAdded.Invoke(this, new DiscountEventArgs(discountRandom));
            Close();

        }
    }
}
