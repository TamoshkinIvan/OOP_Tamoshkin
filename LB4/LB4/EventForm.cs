using System;
using System.Windows.Forms;

namespace View
{
    //TODO:
    public partial class EventForm : Form
    {
        //TODO:
        internal EventHandler<DiscountEventArgs> DiscountAdded;

        internal EventHandler CloseForm;

        internal EventHandler CancelForm;

        internal EventHandler MessageBoxEvent;

    }
}
