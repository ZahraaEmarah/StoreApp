namespace Store.App
{
    partial class StoreFront
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.storeTitleLabel = new System.Windows.Forms.Label();
            this.filterLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceComboBox = new System.Windows.Forms.ComboBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.myOrdersBtn = new System.Windows.Forms.Button();
            this.shoppingCartBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 291);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1527, 560);
            this.dataGridView1.TabIndex = 0;
            // 
            // storeTitleLabel
            // 
            this.storeTitleLabel.AutoSize = true;
            this.storeTitleLabel.Font = new System.Drawing.Font("Georgia", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.storeTitleLabel.Location = new System.Drawing.Point(12, 25);
            this.storeTitleLabel.Name = "storeTitleLabel";
            this.storeTitleLabel.Size = new System.Drawing.Size(307, 51);
            this.storeTitleLabel.TabIndex = 1;
            this.storeTitleLabel.Text = "Online Store";
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.filterLabel.Location = new System.Drawing.Point(12, 103);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(86, 25);
            this.filterLabel.TabIndex = 2;
            this.filterLabel.Text = "Filter by:";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(113, 150);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(303, 33);
            this.categoryComboBox.TabIndex = 3;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(23, 153);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(88, 25);
            this.categoryLabel.TabIndex = 4;
            this.categoryLabel.Text = "Category:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(23, 197);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(53, 25);
            this.priceLabel.TabIndex = 5;
            this.priceLabel.Text = "Price:";
            // 
            // priceComboBox
            // 
            this.priceComboBox.FormattingEnabled = true;
            this.priceComboBox.Location = new System.Drawing.Point(113, 194);
            this.priceComboBox.Name = "priceComboBox";
            this.priceComboBox.Size = new System.Drawing.Size(303, 33);
            this.priceComboBox.TabIndex = 6;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(23, 240);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(554, 31);
            this.searchTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // myOrdersBtn
            // 
            this.myOrdersBtn.Location = new System.Drawing.Point(1267, 238);
            this.myOrdersBtn.Name = "myOrdersBtn";
            this.myOrdersBtn.Size = new System.Drawing.Size(263, 34);
            this.myOrdersBtn.TabIndex = 10;
            this.myOrdersBtn.Text = "My Orders";
            this.myOrdersBtn.UseVisualStyleBackColor = true;
            // 
            // shoppingCartBtn
            // 
            this.shoppingCartBtn.Location = new System.Drawing.Point(1267, 188);
            this.shoppingCartBtn.Name = "shoppingCartBtn";
            this.shoppingCartBtn.Size = new System.Drawing.Size(263, 34);
            this.shoppingCartBtn.TabIndex = 11;
            this.shoppingCartBtn.Text = "Shopping Cart";
            this.shoppingCartBtn.UseVisualStyleBackColor = true;
            // 
            // StoreFront
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 863);
            this.Controls.Add(this.shoppingCartBtn);
            this.Controls.Add(this.myOrdersBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.priceComboBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.storeTitleLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StoreFront";
            this.Text = "StoreFront";
            this.Load += new System.EventHandler(this.StoreFront_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label storeTitleLabel;
        private Label filterLabel;
        private ComboBox categoryComboBox;
        private Label categoryLabel;
        private Label priceLabel;
        private ComboBox priceComboBox;
        private TextBox searchTextBox;
        private Button button1;
        private Button myOrdersBtn;
        private Button shoppingCartBtn;
    }
}