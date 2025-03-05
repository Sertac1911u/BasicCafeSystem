using OOPWithNLayer.BusinessLayer.Abstract;
using OOPWithNLayer.BusinessLayer.Concrete;
using OOPWithNLayer.DataAccessLayer.EntityFramework;
using OOPWithNLayer.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPWithNLayer.PresentationLayer
{
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService _categoryService;

        public FrmCategory()
        {
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();

        }
        private void btnList_Click(object sender, EventArgs e)
        {
            var categoryValues = _categoryService.TGetAll();
            dataGridView1.DataSource = categoryValues;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName=txtCategoryName.Text;
            category.CategoryStatus = true;
            _categoryService.TInsert(category);
            MessageBox.Show("Eklendi!!!!!!!!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var deletedValues = _categoryService.TGetById(id);
            _categoryService.TDelete(deletedValues);
            MessageBox.Show("Olley");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var getById = _categoryService.TGetById(id);
            dataGridView1.DataSource= getById;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int updatedId = int.Parse(txtCategoryId.Text);
            var updateValue = _categoryService.TGetById(updatedId);
            updateValue.CategoryName = txtCategoryName.Text;
            updateValue.CategoryStatus = true;
            _categoryService.TUpdate(updateValue);
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            
        }
    }
}
