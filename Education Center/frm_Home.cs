using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Education_Center
{
    public partial class frm_Home : Form
    {

        //Feilds
        private Form currentChildForm;

        //public frm_Home()
        public frm_Home(string val)
        {
            InitializeComponent();
            lblName.Text = val;

            //Form
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

       

        //Title bar
        //Drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParm, int lParam);

        private void PanelTitlebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //title bar buttons
        private void Guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Guna2GradientButton2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
                WindowState = FormWindowState.Normal;
        }

        private void Btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Time
        private void PanelHome_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        //Open multi forms
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelHome.Controls.Add(childForm);
            panelHome.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //Menu Buttons
        private void BtnHome_Click_1(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
        }

        private void BtnStudent_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frm_student());
        }

        private void BtnTeacher_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frm_teacher());
        }

        private void BtnBook_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Subject());
        }

        private void BtnDashbord_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Dashbord());
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Settings());
        }

        private void Btn_SignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Login obj = new frm_Login();
            obj.Show();
        }

        //toolTips

        private void BtnHome_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Home", btnHome);
        }

        private void BtnStudent_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Student", btnStudent);
        }

        private void BtnTeacher_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Teacher", btnTeacher);
        }

        private void BtnBook_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Subjects", btnBook);
        }

        private void BtnDashbord_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Dashbord", btnDashbord);
        }

        private void BtnSettings_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Settings", btnSettings);
        }

        private void GunaPictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("A+ Education Center", gunaPictureBox2);
        }

        private void Btn_SignOut_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Sign Out", btn_SignOut);
        }

        
    }
}
