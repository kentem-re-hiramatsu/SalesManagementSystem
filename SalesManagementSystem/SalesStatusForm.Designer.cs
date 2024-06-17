namespace SalesManagementSystem
{
    partial class SalesStatusForm
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
            this.SalesOrderButton = new System.Windows.Forms.Button();
            this.PurchaseOrderButton = new System.Windows.Forms.Button();
            this.StockListButton = new System.Windows.Forms.Button();
            this.OrderListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PurchaseProductCheckBox = new System.Windows.Forms.CheckBox();
            this.ToDayPurchaseProductCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SalesOrderButton
            // 
            this.SalesOrderButton.Location = new System.Drawing.Point(12, 40);
            this.SalesOrderButton.Name = "SalesOrderButton";
            this.SalesOrderButton.Size = new System.Drawing.Size(95, 35);
            this.SalesOrderButton.TabIndex = 0;
            this.SalesOrderButton.Text = "販売処理";
            this.SalesOrderButton.UseVisualStyleBackColor = true;
            this.SalesOrderButton.Click += new System.EventHandler(this.SalesOrderButton_Click);
            // 
            // PurchaseOrderButton
            // 
            this.PurchaseOrderButton.Location = new System.Drawing.Point(113, 40);
            this.PurchaseOrderButton.Name = "PurchaseOrderButton";
            this.PurchaseOrderButton.Size = new System.Drawing.Size(95, 35);
            this.PurchaseOrderButton.TabIndex = 1;
            this.PurchaseOrderButton.Text = "仕入処理";
            this.PurchaseOrderButton.UseVisualStyleBackColor = true;
            this.PurchaseOrderButton.Click += new System.EventHandler(this.PurchaseOrderButton_Click);
            // 
            // StockListButton
            // 
            this.StockListButton.Location = new System.Drawing.Point(214, 40);
            this.StockListButton.Name = "StockListButton";
            this.StockListButton.Size = new System.Drawing.Size(95, 35);
            this.StockListButton.TabIndex = 2;
            this.StockListButton.Text = "在庫一覧";
            this.StockListButton.UseVisualStyleBackColor = true;
            this.StockListButton.Click += new System.EventHandler(this.StockListButton_Click);
            // 
            // OrderListView
            // 
            this.OrderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.OrderListView.HideSelection = false;
            this.OrderListView.Location = new System.Drawing.Point(12, 119);
            this.OrderListView.Name = "OrderListView";
            this.OrderListView.Size = new System.Drawing.Size(432, 225);
            this.OrderListView.TabIndex = 3;
            this.OrderListView.UseCompatibleStateImageBehavior = false;
            this.OrderListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "商品名";
            this.columnHeader1.Width = 84;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "販売価格";
            this.columnHeader2.Width = 65;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "仕入日";
            this.columnHeader3.Width = 66;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "販売日";
            this.columnHeader4.Width = 65;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "販売数";
            this.columnHeader5.Width = 62;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "売上金額";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(12, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "売上合計金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "利益合計金額";
            // 
            // PurchaseProductCheckBox
            // 
            this.PurchaseProductCheckBox.AutoSize = true;
            this.PurchaseProductCheckBox.Location = new System.Drawing.Point(330, 59);
            this.PurchaseProductCheckBox.Name = "PurchaseProductCheckBox";
            this.PurchaseProductCheckBox.Size = new System.Drawing.Size(90, 16);
            this.PurchaseProductCheckBox.TabIndex = 6;
            this.PurchaseProductCheckBox.Text = "購買した商品";
            this.PurchaseProductCheckBox.UseVisualStyleBackColor = true;
            // 
            // ToDayPurchaseProductCheckBox
            // 
            this.ToDayPurchaseProductCheckBox.AutoSize = true;
            this.ToDayPurchaseProductCheckBox.Location = new System.Drawing.Point(330, 81);
            this.ToDayPurchaseProductCheckBox.Name = "ToDayPurchaseProductCheckBox";
            this.ToDayPurchaseProductCheckBox.Size = new System.Drawing.Size(114, 16);
            this.ToDayPurchaseProductCheckBox.TabIndex = 7;
            this.ToDayPurchaseProductCheckBox.Text = "今日販売した商品";
            this.ToDayPurchaseProductCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "絞り込み検索";
            // 
            // SalesStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 430);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ToDayPurchaseProductCheckBox);
            this.Controls.Add(this.PurchaseProductCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderListView);
            this.Controls.Add(this.StockListButton);
            this.Controls.Add(this.PurchaseOrderButton);
            this.Controls.Add(this.SalesOrderButton);
            this.Name = "SalesStatusForm";
            this.Text = "販売状況";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SalesOrderButton;
        private System.Windows.Forms.Button PurchaseOrderButton;
        private System.Windows.Forms.Button StockListButton;
        private System.Windows.Forms.ListView OrderListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox PurchaseProductCheckBox;
        private System.Windows.Forms.CheckBox ToDayPurchaseProductCheckBox;
        private System.Windows.Forms.Label label3;
    }
}

