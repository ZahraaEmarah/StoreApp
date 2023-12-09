using Store.Data;
using Store.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store.App
{
    public partial class StoreFront : Form
    {
        StoreContext context;
        public StoreFront()
        {
            context = new StoreContext();
            InitializeComponent();
        }

        private void StoreFront_Load(object sender, EventArgs e)
        {
            context.Category.Load();

            categoryComboBox.ValueMember = "Id";
            categoryComboBox.DisplayMember = "Name";
            categoryComboBox.DataSource = context.Category.Local.ToBindingList();
        }

        void GetCategoryProducts(String TargetCategoryId)
        {
            var categoryProducts = context.Product.Where(c => c.CategoryId == TargetCategoryId).ToList();
            BindDataGridView(categoryProducts);
        }

        void BindDataGridView(List<Product> products)
        {
            //List<Product> productsList = products.Select(p => new Product
            //{
            //    Title = book.Title,
            //    Author = book.Author,
            //    BookISBN = book.BookISBN,
            //    PublishDate = book.PublishDate,
            //    BasePrice = book.BasePrice
            //}).ToList();
            dataGridView1.DataSource = products;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category selectedCategory = (Category)categoryComboBox.SelectedItem;

            if (selectedCategory != null)
            {
                var resultIndex = categoryComboBox.FindStringExact(selectedCategory.Name);
                if (resultIndex > -1)
                {
                    GetCategoryProducts(selectedCategory.Id);
                }
            }
        }
    }
}
