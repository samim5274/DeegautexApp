namespace Deegautex
{
    partial class TakingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBack = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbxReceiver = new System.Windows.Forms.ComboBox();
            this.txtPurpose = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGRemark = new System.Windows.Forms.TextBox();
            this.btnGSave = new System.Windows.Forms.Button();
            this.dtpGDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxGiven = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGPurpose = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBack
            // 
            this.lblBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.Black;
            this.lblBack.Location = new System.Drawing.Point(21, 718);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(51, 25);
            this.lblBack.TabIndex = 0;
            this.lblBack.Text = "Back";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Enabled = false;
            this.dtpDate.Location = new System.Drawing.Point(193, 47);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(297, 29);
            this.dtpDate.TabIndex = 1;
            // 
            // cbxReceiver
            // 
            this.cbxReceiver.FormattingEnabled = true;
            this.cbxReceiver.Location = new System.Drawing.Point(193, 112);
            this.cbxReceiver.Name = "cbxReceiver";
            this.cbxReceiver.Size = new System.Drawing.Size(297, 29);
            this.cbxReceiver.TabIndex = 2;
            // 
            // txtPurpose
            // 
            this.txtPurpose.Location = new System.Drawing.Point(193, 179);
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.Size = new System.Drawing.Size(297, 29);
            this.txtPurpose.TabIndex = 3;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(193, 245);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(297, 116);
            this.txtRemark.TabIndex = 4;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(193, 402);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(297, 29);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(12, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(81, 30);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "loguser";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Taking Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Purpose";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Remark";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Amount";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(193, 471);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(297, 42);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRemark);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxReceiver);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPurpose);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(54, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 587);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGRemark);
            this.groupBox2.Controls.Add(this.btnGSave);
            this.groupBox2.Controls.Add(this.dtpGDate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbxGiven);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtGPurpose);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtGAmount);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(668, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 587);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // txtGRemark
            // 
            this.txtGRemark.Location = new System.Drawing.Point(193, 245);
            this.txtGRemark.Multiline = true;
            this.txtGRemark.Name = "txtGRemark";
            this.txtGRemark.Size = new System.Drawing.Size(297, 116);
            this.txtGRemark.TabIndex = 4;
            // 
            // btnGSave
            // 
            this.btnGSave.Enabled = false;
            this.btnGSave.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGSave.Location = new System.Drawing.Point(193, 471);
            this.btnGSave.Name = "btnGSave";
            this.btnGSave.Size = new System.Drawing.Size(297, 42);
            this.btnGSave.TabIndex = 11;
            this.btnGSave.Text = "Save";
            this.btnGSave.UseVisualStyleBackColor = true;
            this.btnGSave.Click += new System.EventHandler(this.btnGSave_Click);
            // 
            // dtpGDate
            // 
            this.dtpGDate.Enabled = false;
            this.dtpGDate.Location = new System.Drawing.Point(193, 47);
            this.dtpGDate.Name = "dtpGDate";
            this.dtpGDate.Size = new System.Drawing.Size(297, 29);
            this.dtpGDate.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Amount";
            // 
            // cbxGiven
            // 
            this.cbxGiven.FormattingEnabled = true;
            this.cbxGiven.Location = new System.Drawing.Point(193, 112);
            this.cbxGiven.Name = "cbxGiven";
            this.cbxGiven.Size = new System.Drawing.Size(297, 29);
            this.cbxGiven.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 30);
            this.label6.TabIndex = 9;
            this.label6.Text = "Remark";
            // 
            // txtGPurpose
            // 
            this.txtGPurpose.Location = new System.Drawing.Point(193, 179);
            this.txtGPurpose.Name = "txtGPurpose";
            this.txtGPurpose.Size = new System.Drawing.Size(297, 29);
            this.txtGPurpose.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 30);
            this.label7.TabIndex = 8;
            this.label7.Text = "Purpose";
            // 
            // txtGAmount
            // 
            this.txtGAmount.Location = new System.Drawing.Point(193, 402);
            this.txtGAmount.Name = "txtGAmount";
            this.txtGAmount.Size = new System.Drawing.Size(297, 29);
            this.txtGAmount.TabIndex = 5;
            this.txtGAmount.TextChanged += new System.EventHandler(this.txtGAmount_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 30);
            this.label8.TabIndex = 7;
            this.label8.Text = "Given Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("NSimSun", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(118, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(375, 35);
            this.label10.TabIndex = 14;
            this.label10.Text = "Money Taking Section";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("NSimSun", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(732, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(357, 35);
            this.label11.TabIndex = 15;
            this.label11.Text = "Money Given Section";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(1234, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 40);
            this.label9.TabIndex = 16;
            this.label9.Text = "X";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // TakingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lblUser);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TakingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TakingForm";
            this.Load += new System.EventHandler(this.TakingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbxReceiver;
        private System.Windows.Forms.TextBox txtPurpose;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGRemark;
        private System.Windows.Forms.Button btnGSave;
        private System.Windows.Forms.DateTimePicker dtpGDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxGiven;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGPurpose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
    }
}