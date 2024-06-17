namespace Sub
{
    partial class OrderForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductLabel = new System.Windows.Forms.Label();
            this.ProductTextBox = new System.Windows.Forms.TextBox();
            this.PurchaseQuantityLabel = new System.Windows.Forms.Label();
            this.PurchasePriceLabel = new System.Windows.Forms.Label();
            this.SalesPriceLabel = new System.Windows.Forms.Label();
            this.SalesQuantityLabel = new System.Windows.Forms.Label();
            this.PurchaseQuantityTextBox = new System.Windows.Forms.TextBox();
            this.PurchasePriceTextBox = new System.Windows.Forms.TextBox();
            this.SalesPriceTextBox = new System.Windows.Forms.TextBox();
            this.SalesQuantityTextBox = new System.Windows.Forms.TextBox();
            this.OrderButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.ProductLabel.Location = new System.Drawing.Point(50, 68);
            this.ProductLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(52, 15);
            this.ProductLabel.TabIndex = 0;
            this.ProductLabel.Text = "商品名";
            // 
            // ProductTextBox
            // 
            this.ProductTextBox.Enabled = false;
            this.ProductTextBox.Location = new System.Drawing.Point(131, 61);
            this.ProductTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProductTextBox.Name = "ProductTextBox";
            this.ProductTextBox.Size = new System.Drawing.Size(132, 22);
            this.ProductTextBox.TabIndex = 1;
            // 
            // PurchaseQuantityLabel
            // 
            this.PurchaseQuantityLabel.AutoSize = true;
            this.PurchaseQuantityLabel.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.PurchaseQuantityLabel.Location = new System.Drawing.Point(50, 110);
            this.PurchaseQuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PurchaseQuantityLabel.Name = "PurchaseQuantityLabel";
            this.PurchaseQuantityLabel.Size = new System.Drawing.Size(52, 15);
            this.PurchaseQuantityLabel.TabIndex = 2;
            this.PurchaseQuantityLabel.Text = "仕入数";
            // 
            // PurchasePriceLabel
            // 
            this.PurchasePriceLabel.AutoSize = true;
            this.PurchasePriceLabel.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.PurchasePriceLabel.Location = new System.Drawing.Point(50, 153);
            this.PurchasePriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PurchasePriceLabel.Name = "PurchasePriceLabel";
            this.PurchasePriceLabel.Size = new System.Drawing.Size(67, 15);
            this.PurchasePriceLabel.TabIndex = 3;
            this.PurchasePriceLabel.Text = "仕入価格";
            // 
            // SalesPriceLabel
            // 
            this.SalesPriceLabel.AutoSize = true;
            this.SalesPriceLabel.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.SalesPriceLabel.Location = new System.Drawing.Point(50, 198);
            this.SalesPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SalesPriceLabel.Name = "SalesPriceLabel";
            this.SalesPriceLabel.Size = new System.Drawing.Size(67, 15);
            this.SalesPriceLabel.TabIndex = 4;
            this.SalesPriceLabel.Text = "販売価格";
            // 
            // SalesQuantityLabel
            // 
            this.SalesQuantityLabel.AutoSize = true;
            this.SalesQuantityLabel.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.SalesQuantityLabel.Location = new System.Drawing.Point(50, 242);
            this.SalesQuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SalesQuantityLabel.Name = "SalesQuantityLabel";
            this.SalesQuantityLabel.Size = new System.Drawing.Size(52, 15);
            this.SalesQuantityLabel.TabIndex = 5;
            this.SalesQuantityLabel.Text = "販売数";
            // 
            // PurchaseQuantityTextBox
            // 
            this.PurchaseQuantityTextBox.Enabled = false;
            this.PurchaseQuantityTextBox.Location = new System.Drawing.Point(131, 103);
            this.PurchaseQuantityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PurchaseQuantityTextBox.Name = "PurchaseQuantityTextBox";
            this.PurchaseQuantityTextBox.Size = new System.Drawing.Size(132, 22);
            this.PurchaseQuantityTextBox.TabIndex = 6;
            // 
            // PurchasePriceTextBox
            // 
            this.PurchasePriceTextBox.Enabled = false;
            this.PurchasePriceTextBox.Location = new System.Drawing.Point(131, 146);
            this.PurchasePriceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PurchasePriceTextBox.Name = "PurchasePriceTextBox";
            this.PurchasePriceTextBox.Size = new System.Drawing.Size(132, 22);
            this.PurchasePriceTextBox.TabIndex = 7;
            // 
            // SalesPriceTextBox
            // 
            this.SalesPriceTextBox.Enabled = false;
            this.SalesPriceTextBox.Location = new System.Drawing.Point(131, 191);
            this.SalesPriceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SalesPriceTextBox.Name = "SalesPriceTextBox";
            this.SalesPriceTextBox.Size = new System.Drawing.Size(132, 22);
            this.SalesPriceTextBox.TabIndex = 8;
            // 
            // SalesQuantityTextBox
            // 
            this.SalesQuantityTextBox.Enabled = false;
            this.SalesQuantityTextBox.Location = new System.Drawing.Point(131, 235);
            this.SalesQuantityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SalesQuantityTextBox.Name = "SalesQuantityTextBox";
            this.SalesQuantityTextBox.Size = new System.Drawing.Size(132, 22);
            this.SalesQuantityTextBox.TabIndex = 9;
            // 
            // OrderButton
            // 
            this.OrderButton.Enabled = false;
            this.OrderButton.Location = new System.Drawing.Point(53, 277);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(89, 32);
            this.OrderButton.TabIndex = 10;
            this.OrderButton.Text = "注文";
            this.OrderButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Enabled = false;
            this.CancelButton.Location = new System.Drawing.Point(174, 277);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(89, 32);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "キャンセル";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 334);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.SalesQuantityTextBox);
            this.Controls.Add(this.SalesPriceTextBox);
            this.Controls.Add(this.PurchasePriceTextBox);
            this.Controls.Add(this.PurchaseQuantityTextBox);
            this.Controls.Add(this.SalesQuantityLabel);
            this.Controls.Add(this.SalesPriceLabel);
            this.Controls.Add(this.PurchasePriceLabel);
            this.Controls.Add(this.PurchaseQuantityLabel);
            this.Controls.Add(this.ProductTextBox);
            this.Controls.Add(this.ProductLabel);
            this.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderForm";
            this.Text = "仕入処理";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.TextBox ProductTextBox;
        private System.Windows.Forms.Label PurchaseQuantityLabel;
        private System.Windows.Forms.Label PurchasePriceLabel;
        private System.Windows.Forms.Label SalesPriceLabel;
        private System.Windows.Forms.Label SalesQuantityLabel;
        private System.Windows.Forms.TextBox PurchaseQuantityTextBox;
        private System.Windows.Forms.TextBox PurchasePriceTextBox;
        private System.Windows.Forms.TextBox SalesPriceTextBox;
        private System.Windows.Forms.TextBox SalesQuantityTextBox;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.Button CancelButton;
    }
}

