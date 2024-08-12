using System;
using System.Windows.Forms;
using System.Drawing;
using Mission05; // Pastikan namespace ini ditambahkan di bagian atas MainForm.cs

namespace Mission05
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            FormAddEmployee formAdd = new FormAddEmployee();
            formAdd.ShowDialog();
        }

        private void BtnEditEmployee_Click(object sender, EventArgs e)
        {
            FormEditEmployee formEdit = new FormEditEmployee();
            formEdit.ShowDialog();
        }

        private void BtnShowEmployees_Click(object sender, EventArgs e)
        {
            FormShowEmployees formShow = new FormShowEmployees();
            formShow.ShowDialog();
        }

        private void BtnSearchEmployee_Click(object sender, EventArgs e)
        {
            FormSearchEmployee formSearch = new FormSearchEmployee();
            formSearch.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
