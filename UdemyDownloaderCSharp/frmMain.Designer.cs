namespace UdemyDownloaderCSharp
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.loginTab = new System.Windows.Forms.TabPage();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.downloadOptionsTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkLectureStartEnd = new System.Windows.Forms.CheckBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.lblLectureStart = new System.Windows.Forms.Label();
            this.lblLectureEnd = new System.Windows.Forms.Label();
            this.txtLectureStart = new System.Windows.Forms.TextBox();
            this.txtLectureEnd = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnStartDownload = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.loginTab.SuspendLayout();
            this.downloadOptionsTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 341);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.loginTab);
            this.tabControl1.Controls.Add(this.downloadOptionsTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 341);
            this.tabControl1.TabIndex = 0;
            // 
            // loginTab
            // 
            this.loginTab.Controls.Add(this.txtPassword);
            this.loginTab.Controls.Add(this.txtUsername);
            this.loginTab.Controls.Add(this.lblPassword);
            this.loginTab.Controls.Add(this.lblUsername);
            this.loginTab.Location = new System.Drawing.Point(4, 22);
            this.loginTab.Name = "loginTab";
            this.loginTab.Padding = new System.Windows.Forms.Padding(3);
            this.loginTab.Size = new System.Drawing.Size(662, 300);
            this.loginTab.TabIndex = 0;
            this.loginTab.Text = "Login Credentials";
            this.loginTab.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(218, 82);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(220, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(218, 32);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(220, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(74, 85);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(74, 39);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(63, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // downloadOptionsTab
            // 
            this.downloadOptionsTab.Controls.Add(this.btnStartDownload);
            this.downloadOptionsTab.Controls.Add(this.groupBox1);
            this.downloadOptionsTab.Controls.Add(this.checkLectureStartEnd);
            this.downloadOptionsTab.Controls.Add(this.lblCourseName);
            this.downloadOptionsTab.Controls.Add(this.txtCourseName);
            this.downloadOptionsTab.Location = new System.Drawing.Point(4, 22);
            this.downloadOptionsTab.Name = "downloadOptionsTab";
            this.downloadOptionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.downloadOptionsTab.Size = new System.Drawing.Size(790, 315);
            this.downloadOptionsTab.TabIndex = 1;
            this.downloadOptionsTab.Text = "Download Options";
            this.downloadOptionsTab.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLectureEnd);
            this.groupBox1.Controls.Add(this.txtLectureStart);
            this.groupBox1.Controls.Add(this.lblLectureEnd);
            this.groupBox1.Controls.Add(this.lblLectureStart);
            this.groupBox1.Location = new System.Drawing.Point(147, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 132);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // checkLectureStartEnd
            // 
            this.checkLectureStartEnd.AutoSize = true;
            this.checkLectureStartEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLectureStartEnd.Location = new System.Drawing.Point(147, 89);
            this.checkLectureStartEnd.Name = "checkLectureStartEnd";
            this.checkLectureStartEnd.Size = new System.Drawing.Size(132, 17);
            this.checkLectureStartEnd.TabIndex = 2;
            this.checkLectureStartEnd.Text = "Lecture Start/ End";
            this.checkLectureStartEnd.UseVisualStyleBackColor = true;
            this.checkLectureStartEnd.CheckedChanged += new System.EventHandler(this.checkLectureStartEnd_CheckedChanged);
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.Location = new System.Drawing.Point(144, 15);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(82, 13);
            this.lblCourseName.TabIndex = 1;
            this.lblCourseName.Text = "Course Name";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(147, 42);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(382, 20);
            this.txtCourseName.TabIndex = 0;
            // 
            // lblLectureStart
            // 
            this.lblLectureStart.AutoSize = true;
            this.lblLectureStart.Enabled = false;
            this.lblLectureStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLectureStart.Location = new System.Drawing.Point(59, 34);
            this.lblLectureStart.Name = "lblLectureStart";
            this.lblLectureStart.Size = new System.Drawing.Size(34, 13);
            this.lblLectureStart.TabIndex = 0;
            this.lblLectureStart.Text = "Start";
            // 
            // lblLectureEnd
            // 
            this.lblLectureEnd.AutoSize = true;
            this.lblLectureEnd.Enabled = false;
            this.lblLectureEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLectureEnd.Location = new System.Drawing.Point(59, 99);
            this.lblLectureEnd.Name = "lblLectureEnd";
            this.lblLectureEnd.Size = new System.Drawing.Size(29, 13);
            this.lblLectureEnd.TabIndex = 1;
            this.lblLectureEnd.Text = "End";
            // 
            // txtLectureStart
            // 
            this.txtLectureStart.Enabled = false;
            this.txtLectureStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLectureStart.Location = new System.Drawing.Point(110, 34);
            this.txtLectureStart.Name = "txtLectureStart";
            this.txtLectureStart.Size = new System.Drawing.Size(179, 20);
            this.txtLectureStart.TabIndex = 2;
            // 
            // txtLectureEnd
            // 
            this.txtLectureEnd.Enabled = false;
            this.txtLectureEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLectureEnd.Location = new System.Drawing.Point(110, 92);
            this.txtLectureEnd.Name = "txtLectureEnd";
            this.txtLectureEnd.Size = new System.Drawing.Size(179, 20);
            this.txtLectureEnd.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 365);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 128);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(798, 128);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 16);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(792, 109);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnStartDownload
            // 
            this.btnStartDownload.Location = new System.Drawing.Point(147, 286);
            this.btnStartDownload.Name = "btnStartDownload";
            this.btnStartDownload.Size = new System.Drawing.Size(382, 23);
            this.btnStartDownload.TabIndex = 4;
            this.btnStartDownload.Text = "Start Download";
            this.btnStartDownload.UseVisualStyleBackColor = true;
            this.btnStartDownload.Click += new System.EventHandler(this.btnStartDownload_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 493);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.loginTab.ResumeLayout(false);
            this.loginTab.PerformLayout();
            this.downloadOptionsTab.ResumeLayout(false);
            this.downloadOptionsTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage loginTab;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TabPage downloadOptionsTab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkLectureStartEnd;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtLectureEnd;
        private System.Windows.Forms.TextBox txtLectureStart;
        private System.Windows.Forms.Label lblLectureEnd;
        private System.Windows.Forms.Label lblLectureStart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnStartDownload;
    }
}