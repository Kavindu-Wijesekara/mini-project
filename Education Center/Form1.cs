using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Education_Center
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();

            bunifuFormDock1.SubscribeControlToDragEvents(bunifuGradientPanel1);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage1);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage2);
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);
        }

        private void Guna2Button2_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(1);
        }

        public void Alert(String msg, frm_Alert.enmType type)
        {
            frm_Alert frm = new frm_Alert();
            frm.showAlert(msg, type);
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "Nuwan" && txt_Password.Text == "1234")
            {
                this.Alert("Success!", frm_Alert.enmType.Success);
                this.Hide();
              string user = txt_Username.Text;
                frm_Home obj = new frm_Home(char.ToUpper(user[0]) + user.Substring(1));
                obj.Show(); 
              /*  frm_Home Hm = new frm_Home();
                Hm.Show(); */
            }
            else
            {
                this.Alert("Error!", frm_Alert.enmType.Error);
            }
        }
    }
}
