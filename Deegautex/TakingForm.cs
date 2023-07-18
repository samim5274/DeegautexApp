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
            ClearText();
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
                btnSave.Enabled = true;
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
    }
}
