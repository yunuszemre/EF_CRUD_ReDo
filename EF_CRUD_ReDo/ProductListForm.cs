using EF_CRUD_ReDo.DAL.Context;
using EF_CRUD_ReDo.DAL.Entity;
using EF_CRUD_ReDo.DTO;
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
                var result = DB.Products.Select(t0 => new ProductDTO()
                {
                    ProductName = t0.ProductName,
                    Description = t0.Description,
                    Disconitued = Convert.ToBoolean(t0.Discontinued),
                    UnitPrice =Convert.ToDecimal(t0.UnitPrice),
                    UnitsInStock = Convert.ToInt32(t0.UnitsInStock),
                    CategoryId = Convert.ToInt32(t0.CategoryId),
                    ProductId = Convert.ToInt32(t0.ProductId),
                }).ToList();
                dataGridView1.DataSource = null;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
