using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLab3
{
    /// <summary>
    /// Реализация интерфейса Discount
    /// </summary>
    public interface IDiscount
    {
        /// <summary>
        /// Метод расчета цены с учетом скидки
        /// </summary>
        /// <returns></returns>
        double CalculateDiscount();

        /// <summary>
        /// Метод печати чека
        /// </summary>
        /// <returns></returns>
        string GetTax();
    }
}
