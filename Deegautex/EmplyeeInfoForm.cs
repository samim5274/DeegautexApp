using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deegautex
{
    public partial class EmplyeeInfoForm : Form
    {
        public EmplyeeInfoForm()
        {
            InitializeComponent();
        }

        private void EmplyeeInfoForm_Load(object sender, EventArgs e)
        {
            FillGender();
            ClearText();
        }

        private void ClearText()
        {
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtReferName.Text = string.Empty;
            txtR_Address.Text = string.Empty;
            txtR_Phone.Text = string.Empty;
            cbxGender.Text = string.Empty;
            dtpDateOfBirth.Value = DateTime.Now;
            dtpJoinDate.Value = DateTime.Now;
        }

        private void FillGender()
        {
            var obj = new Manager();
            var list = obj.GetGender();
            cbxGender.DisplayMember = "Gender";
            cbxGender.ValueMember = "Id";
            cbxGender.DataSource = list;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }
    }
}
