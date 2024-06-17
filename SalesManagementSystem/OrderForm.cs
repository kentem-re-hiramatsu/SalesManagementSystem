using System.Windows.Forms;

namespace Sub
{
    public partial class OrderForm : Form
    {
        private bool _isPurchaseOrder;

        public OrderForm(bool isPurchaseOrder)
        {
            InitializeComponent();
            _isPurchaseOrder = isPurchaseOrder;
        }

        private void OrderForm_Load(object sender, System.EventArgs e)
        {
            SetInitialValues();
        }

        private void SetInitialValues()
        {
            ProductTextBox.Enabled = _isPurchaseOrder;
            PurchaseQuantityTextBox.Enabled = _isPurchaseOrder;
            PurchasePriceTextBox.Enabled = _isPurchaseOrder;
            SalesPriceTextBox.Enabled = _isPurchaseOrder;
            SalesQuantityTextBox.Enabled = !_isPurchaseOrder;

        }

    }
}
