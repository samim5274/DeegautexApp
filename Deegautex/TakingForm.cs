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
    public partial class TakingForm : Form
    {
        public TakingForm()
        {
            InitializeComponent();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TakingForm_Load(object sender, EventArgs e)
        {
            var logus = MotherForm.LcurrentUser;
            lblUser.Text = "" + logus;
            FillReceiver();
            FillGiver();
            ClearText();
            ClearTextG();
        }

        private void ClearTextG()
        {
            dtpGDate.Value = DateTime.Now;
            cbxGiven.Text = string.Empty;
            txtGPurpose.Text = string.Empty;
            txtGRemark.Text = string.Empty;
            txtGAmount.Text = string.Empty;
        }

        private void FillGiver()
        {
            var obj = new Manager();
            var list = obj.GetEmployee();
            cbxGiven.DisplayMember = "Name";
            cbxGiven.ValueMember = "Id";
            cbxGiven.DataSource = list;
        }

        private void ClearText()
        {
            dtpDate.Value = DateTime.Now;
            cbxReceiver.Text = string.Empty;
            txtPurpose.Text = string.Empty;
            txtRemark.Text = string.Empty;
            txtAmount.Text = string.Empty;
        }

        private void FillReceiver()
        {
            var obj = new Manager();
            var list = obj.GetEmployee();
            cbxReceiver.DisplayMember = "Name";
            cbxReceiver.ValueMember = "Id";
            cbxReceiver.DataSource = list;
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtAmount.Text == "")
            {
                btnSave.Enabled = false;
            }
            else if (txtAmount.Text != null)
            {
                try
                {
                    double amount = Convert.ToInt32(txtAmount.Text);
                    if (amount < 0)
                    {
                        btnSave.Enabled = false;
                    }
                    else if (amount > 0)
                    {
                        btnSave.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    txtAmount.Text = string.Empty;
                    txtAmount.Focus();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Are you sure do you went to update information?", "Update Info!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var db = new DGTDBEntities();
                var tb = new TB_MoneyTaking();

                tb.Date = Convert.ToDateTime(dtpDate.Value);
                tb.ReceiverId = Convert.ToInt32(cbxReceiver.SelectedValue);
                tb.Purpose = txtPurpose.Text.Trim();
                tb.Remark = txtRemark.Text.Trim();
                tb.TotalMoney = Convert.ToInt32(txtAmount.Text.Trim());
                tb.LoginUserName = lblUser.Text.Trim();

                db.TB_MoneyTaking.Add(tb);
                db.SaveChanges();
                ClearText();
            }
        }

        private void txtGAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtGAmount.Text == "")
            {
                btnGSave.Enabled = false;
            }
            else if (txtGAmount.Text != null)
            {
                try
                {
                    double amount = Convert.ToInt32(txtGAmount.Text);
                    if (amount < 0)
                    {
                        btnGSave.Enabled = false;
                    }
                    else if (amount > 0)
                    {
                        btnGSave.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    txtGAmount.Text = string.Empty;
                    txtGAmount.Focus();
                }
            }
        }

        private void btnGSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Are you sure do you went to update information?", "Update Info!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var db = new DGTDBEntities();
                var tb = new TB_MoneyGiven();

                tb.Date = Convert.ToDateTime(dtpGDate.Value);
                tb.GiverId = Convert.ToInt32(cbxGiven.SelectedValue);
                tb.Purpose = txtGPurpose.Text.Trim();
                tb.Remark = txtGRemark.Text.Trim();
                tb.TotalMoney = Convert.ToInt32(txtGAmount.Text.Trim());
                tb.LoginUserName = lblUser.Text.Trim();

                db.TB_MoneyGiven.Add(tb);
                db.SaveChanges();
                ClearTextG();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
