using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UdemyDownloaderCSharp
{
    public partial class frmMain : Form
    {
        private string consoleOuPut;
        public frmMain()
        {
            InitializeComponent();
        }

        private void checkLectureStartEnd_CheckedChanged(object sender, EventArgs e)
        {
            if(checkLectureStartEnd.Checked)
            {
                lblLectureStart.Enabled = true;
                lblLectureEnd.Enabled = true;
                txtLectureStart.Enabled = true;
                txtLectureEnd.Enabled = true;
            }
            else
            {
                lblLectureStart.Enabled = false;
                lblLectureEnd.Enabled = false;
                txtLectureStart.Enabled = false;
                txtLectureEnd.Enabled = false;

            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnStartDownload_Click(object sender, EventArgs e)
        {
            bool optionsSet = checkDownloadOptions();
            if (optionsSet)
            {
                ProcessStartInfo ps = new ProcessStartInfo();
                ps.FileName = "cmd.exe";
                ps.WorkingDirectory =Directory.GetCurrentDirectory();
                ps.Arguments = "/c udemy-dl.exe -u " + txtUsername.Text + " -p " + txtPassword.Text + " " + txtCourseName.Text;
                ps.RedirectStandardOutput = true;
                ps.RedirectStandardError = true;
                ps.CreateNoWindow = true;
                ps.UseShellExecute = false;

                Process process = Process.Start(ps);
                process.EnableRaisingEvents = true;
                process.OutputDataReceived += Process_OutputDataReceived;
                process.ErrorDataReceived += Process_ErrorDataReceived;
                process.Exited += Process_Exited;
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

            }
            else
            {

            }
        }

        private void ReportProgress(string txt)
        {
            richTextBox1.Invoke((Action)delegate
            {
                richTextBox1.Text += txt;
                //if (txt.Contains("dist\\client.exe"))
                //{
                //    int length = richTextBox1.TextLength;
                //    richTextBox1.SelectionStart = length;
                //    richTextBox1.SelectionLength = txt.Length;
                //    richTextBox1.SelectionColor = Color.Green;

                //}
                //richTextBox1.SelectionStart = richTextBox1.Text.Length;
                //richTextBox1.ScrollToCaret();

            }
            );
        }

        private void Process_Exited(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text = consoleOuPut;

                btnStartDownload.Invoke((Action)delegate
                {
                 
                         
                        MessageBox.Show("Process complete. Saved to dist folder!", "ExeBuilt", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //MessageBox.Show("Process complete. Saved to " + lblOutPath.Text, "ExeBuilt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
               
                    

                    btnStartDownload.Enabled = true;
                }


                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            try
            {
               consoleOuPut = e.Data + Environment.NewLine;
               ReportProgress(consoleOuPut);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }
        }
        private void Process_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            try
            {
                consoleOuPut = e.Data + Environment.NewLine;
                ReportProgress(consoleOuPut);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private bool checkDownloadOptions()
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
                return false;
            if (string.IsNullOrEmpty(txtPassword.Text))
                return false;
            if (string.IsNullOrEmpty(txtCourseName.Text))
                return false;
            return true;
        }


    }
}
