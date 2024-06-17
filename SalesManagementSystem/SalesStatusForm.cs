using Sub;
using System;
using System.Windows.Forms;

namespace SalesManagementSystem
{
    public partial class SalesStatusForm : System.Windows.Forms.Form
    {
        public SalesStatusForm()
        {
            InitializeComponent();
        }

        private void SalesOrderButton_Click(object sender, EventArgs e)
        {
            ShowOrderForm(true);
        }

        private void PurchaseOrderButton_Click(object sender, EventArgs e)
        {
            ShowOrderForm(false);
        }

        private void StockListButton_Click(object sender, EventArgs e)
        {

        }
        private void ShowOrderForm(bool isPurchaseOrder)
        {
            var OrderForm = new OrderForm(isPurchaseOrder);
            if (DialogResult.OK == OrderForm.ShowDialog())
            {

            }
        }
    }
}
