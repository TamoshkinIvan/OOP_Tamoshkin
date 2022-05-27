using System;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Класс событий
    /// </summary>
    public partial class EventForm : Form
    {
        /// <summary>
        /// Событие закрытия формы
        /// </summary>
        internal EventHandler CloseForm;

        /// <summary>
        /// Событие отмены действия 
        /// </summary>
        internal EventHandler CancelForm;

        /// <summary>
        /// События вызова окна сообщения
        /// </summary>
        internal EventHandler MessageBoxEvent;
    }
}
