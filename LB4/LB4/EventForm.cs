using System;
using System.Windows.Forms;

namespace View
{
    public partial class EventForm : Form
    {
        internal EventHandler<DiscountEventArgs> DiscountAdded;

        internal EventHandler CloseForm;

        internal EventHandler CancelForm;

        internal EventHandler MessageBoxEvent;

    }
}
