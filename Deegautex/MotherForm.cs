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
    public partial class MotherForm : Form
    {
        public static string LcurrentUser;
        public MotherForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var db = new DGTDBEntities();
            int id = 1;
            var SC = db.TB_Security.Where(a => a.Id.ToString() == id.ToString()).FirstOrDefault();
            var dt1 = Convert.ToDateTime(SC.Security);
            var dt2 = dt1 - DateTime.Now;
            label4.Text = dt2.ToString("dd");
            switch (label4.Text)
            {
                case "00":
                    for (int i = 0; i <= 15; i++)
                    {
                        MessageBox.Show("Your license is already expired. Please update your license. Thank you!", "Validity Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show("Your license has been expired. Please call developer or update your product key. Thanks!", "Validity Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);                                               
                    }
                    break;
                case "01":
                    MessageBox.Show("Your license will be expired after " + dt2.ToString("dd") + " days. Please update your license or call the developer. Thank you!");
                    LoginUser();
                    break;
                case "02":
                    MessageBox.Show("Your license will be expired after " + dt2.ToString("dd") + " days. Please update your license or call the developer. Thank you!");
                    LoginUser();
                    break;
                case "03":
                    MessageBox.Show("Your license will be expired after " + dt2.ToString("dd") + " days. Please update your license or call the developer. Thank you!");
                    LoginUser();
                    break;
                case "04":
                    MessageBox.Show("Your license will be expired after " + dt2.ToString("dd") + " days. Please update your license or call the developer. Thank you!");
                    LoginUser();
                    break;
                case "05":
                    MessageBox.Show("Your license will be expired after " + dt2.ToString("dd") + " days. Please update your license or call the developer. Thank you!");
                    LoginUser();
                    break;
                case "06":
                    MessageBox.Show("Your license will be expired after " + dt2.ToString("dd") + " days. Please update your license or call the developer. Thank you!");
                    LoginUser();
                    break;
                case "07":
                    MessageBox.Show("Your license will be expired after " + dt2.ToString("dd") + " days. Please update your license or call the developer. Thank you!");
                    LoginUser();
                    break;   
                default:
                    LoginUser();
                    break;
            }
        }

        private void LoginUser()
        {
            int id = 1;
            var db = new DGTDBEntities();
            var select = db.TB_UserInfo.Where(a => a.Password.ToString() == txtPassword.Text.Trim() && a.Username.ToString() == txtUsername.Text.Trim()).FirstOrDefault();
            var select2 = db.TB_Security.Where(a => a.Id.ToString() == id.ToString()).FirstOrDefault();
            var valid = Convert.ToDateTime(select2.Security);

            if (DateTime.Now < valid)
            {
                try
                {
                    if (select.D == "Y") { dashboardToolStripMenuItem.Visible = true; } else { dashboardToolStripMenuItem.Visible = false; }
                    if (select.T == "Y") { transectionToolStripMenuItem.Visible = true; } else { transectionToolStripMenuItem.Visible = false; }
                    if (select.F == "Y") { followUpToolStripMenuItem.Visible = true; } else { followUpToolStripMenuItem.Visible = false; }
                    if (select.A == "Y") { accessoryToolStripMenuItem.Visible = true; } else { accessoryToolStripMenuItem.Visible = false; }
                    if (select.S == "Y") { settingToolStripMenuItem.Visible = true; } else { settingToolStripMenuItem.Visible = false; }

                    LcurrentUser = select.FirstName + " " + select.LastName;
                    groupBox1.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "Please check the username and password and try again.", "Login Fail", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    txtUsername.Focus();
                }
            }
            else if (DateTime.Now > valid) 
            {
                MessageBox.Show("Your license is already expired. Please update your license. Thank you!", "Validity Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Your license has been expired. Please call developer or update your product key. Thanks!", "Validity Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            var db = new DGTDBEntities();
            int id = 1;
            var select2 = db.TB_Security.Where(a => a.Id.ToString() == id.ToString()).FirstOrDefault();
            var valid = Convert.ToDateTime(select2.Security);

            var dt2 = Convert.ToDateTime(select2.Security);
            var dt3 = dt2 - DateTime.Now;
            label4.Text = dt3.ToString("dd");

            switch (label4.Text)
            {
                case "00":
                    label8.Visible = true;
                    break;
                case "01":
                    label8.Visible = true;
                    break;
                case "02":
                    label8.Visible = true;
                    break;
                case "03":
                    label8.Visible = true;
                    break;
                case "04":
                    label8.Visible = true;
                    break;
                case "05":
                    label8.Visible = true;
                    break;
                case "06":
                    label8.Visible = true;
                    break;
                case "07":
                    label8.Visible = true;
                    break;
                default:
                    label8.Visible = false;
                    break;
            }
        }

        private void MotherForm_Load(object sender, EventArgs e)
        {
            //SecurityAlart();
        }

        private void SecurityAlart()
        {
            var db = new DGTDBEntities();
            int id = 1;
            var SC = db.TB_Security.Where(a => a.Id.ToString() == id.ToString()).FirstOrDefault();
            var dt1 = Convert.ToDateTime(SC.Security);
            var dt2 = dt1 - DateTime.Now;
            label4.Text = dt2.ToString("dd");
            switch (label4.Text)
            {
                case "00":
                    MessageBox.Show("Your license is already expired. Please update your license. Thank you!", "Validity Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Your license has been expired. Please call developer or update your product key. Thanks!", "Validity Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "01":
                    MessageBox.Show("Your license will be expired after " + dt2.ToString("dd") + " days. Please update your license or call the developer. Thank you!");
                    break;
                case "02":
                    MessageBox.Show("Your license will be expired after " + dt2.ToString("dd") + " days. Please update your license or call the developer. Thank you!");
                    break;
                case "03":
                    MessageBox.Show("Your license will be expired after " + dt2.ToString("dd") + " days. Please update your license or call the developer. Thank you!");
                    break;
                case "04":
                    MessageBox.Show("Your license will be expired after " + dt2.ToString("dd") + " days. Please update your license or call the developer. Thank you!");
                    break;
                case "05":
                    MessageBox.Show("Your license will be expired after " + dt2.ToString("dd") + " days. Please update your license or call the developer. Thank you!");
                    break;
                case "06":
                    MessageBox.Show("Your license will be expired after " + dt2.ToString("dd") + " days. Please update your license or call the developer. Thank you!");
                    break;
                case "07":
                    MessageBox.Show("Your license will be expired after " + dt2.ToString("dd") + " days. Please update your license or call the developer. Thank you!");
                    break;
                default:
                    MessageBox.Show("You can not login. Because your product key already expired. Please update your license or call the developer. Thank you!");
                    break;
            }
        }

        private void imTakingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new TakingForm();
            obj.ShowDialog();
        }

        private void joinNewEmloyeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new EmplyeeInfoForm();
            obj.ShowDialog();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var obj = new TakindAndGivenDetailForm();
            obj.ShowDialog();
        }
    }
}
