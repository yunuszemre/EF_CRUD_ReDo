using EF_CRUD_ReDo.DAL.Context;
using EF_CRUD_ReDo.DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_CRUD_ReDo
{
    public partial class ProductListForm : Form
    {
        public ProductListForm()
        {
            InitializeComponent();
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            FillGrid();

        }

        private void FillGrid()
        {
            using (EComerceDBContext DB = new EComerceDBContext())
            {
                var result = DB.Products.ToList();
                dataGridView1.DataSource = result;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GetProductId(e);
        }

        private void GetProductId(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var product = (dataGridView1.DataSource as List<Product>)[e.RowIndex];
                if (product != null)
                {
                    var form = new ProductForm();
                    form.Tag = product.ProductId;
                    form.ShowDialog();
                }
            }
        }
    }
}
