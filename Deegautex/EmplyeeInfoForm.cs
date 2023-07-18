using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            FillGrid();
        }

        private void FillGrid()
        {
            var db = new DGTDBEntities();
            dgvEmplyee.DataSource = db.TB_EmployeeInfo.ToList();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text=="Save")
            {
                if (txtName.Text == "" && txtPhone.Text == "")
                {
                    MessageBox.Show(@"Please fill the all valu and then save. Thank you.", "Data save Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtName.Text != null)
                {
                    var db = new DGTDBEntities();
                    var tb = new TB_EmployeeInfo();

                    tb.Name = txtName.Text.Trim();
                    tb.Address = txtAddress.Text.Trim();
                    tb.Phone = Convert.ToInt32(txtPhone.Text.Trim());
                    tb.GenderId = Convert.ToInt32(cbxGender.SelectedValue);
                    tb.DateOfBirth = Convert.ToDateTime(dtpDateOfBirth.Value);
                    tb.JoinDate = Convert.ToDateTime(dtpJoinDate.Value);
                    tb.RefarName = txtReferName.Text.Trim();
                    tb.R_Address = txtR_Address.Text.Trim();
                    tb.R_Phone = Convert.ToInt32(txtR_Phone.Text.Trim());

                    db.TB_EmployeeInfo.Add(tb);
                    db.SaveChanges();
                    ClearText();
                    FillGrid();
                }
            }      
            else if (btnSave.Text=="Edit")
            {
                MessageBox.Show(@"Data update not possible. Thank you.", "Data save Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearText();
            }      
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                btnSave.Enabled = false;
            }
            else if (txtPhone.Text != null)
            {
                if (txtPhone.TextLength > 11)
                {
                    MessageBox.Show(@"your input digit out of lenth. Please input your current number. Thank you.", "Erorr input", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    btnSave.Enabled = false;
                }
                else if (txtPhone.TextLength < 12 && txtPhone.TextLength > 10)
                {
                    if (txtPhone.TextLength == 11)
                    {
                        btnSave.Enabled = true;
                    }
                    else
                    {
                        btnSave.Enabled = false;
                    }
                }
                else if ( txtPhone.TextLength <= 10)
                {
                    btnSave.Enabled = false;
                }
            }
        }

        private void dgvEmplyee_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtSearch.Text = dgvEmplyee.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            SearchItem();
        }

        private void SearchItem()
        {
            if (txtSearch.Text=="")
            {
                //MessageBox.Show("Data not found. Please try again.","Search Failed!",MessageBoxButtons.RetryCancel,MessageBoxIcon.Exclamation);
                ClearText();
            }
            else if (txtSearch.Text != null)
            {
                try
                {
                    var db = new DGTDBEntities();
                    var select = db.TB_EmployeeInfo.Where(a => a.Id.ToString() == txtSearch.Text.Trim()).FirstOrDefault();

                    txtName.Text = select.Name;
                    txtAddress.Text = select.Address;
                    txtPhone.Text = select.Phone.ToString();
                    cbxGender.SelectedValue = select.GenderId;
                    dtpDateOfBirth.Value = Convert.ToDateTime(select.DateOfBirth);
                    dtpJoinDate.Value = Convert.ToDateTime(select.JoinDate);
                    txtReferName.Text = select.RefarName;
                    txtR_Address.Text = select.R_Address;
                    txtR_Phone.Text = select.R_Phone.ToString();
                    btnSave.Enabled = true;
                    btnSave.Text = "Edit";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchItem();
        }
    }
}
