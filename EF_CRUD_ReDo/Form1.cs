namespace EF_CRUD_ReDo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuProductItem_Click(object sender, EventArgs e)
        {
            var from = new ProductListForm();
            from.Show();
        }
    }
}