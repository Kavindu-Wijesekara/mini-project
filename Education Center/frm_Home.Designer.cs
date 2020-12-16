namespace Education_Center
{
    partial class frm_Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Home));
            this.panelTitlebar = new System.Windows.Forms.Panel();
            this.btn_Fullscreen = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_Minimize = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btn_exit = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panelHome = new System.Windows.Forms.Panel();
            this.panelDateTime = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_SignOut = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.btnDashbord = new Guna.UI2.WinForms.Guna2Button();
            this.btnTeacher = new Guna.UI2.WinForms.Guna2Button();
            this.btnBook = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.btnStudent = new Guna.UI2.WinForms.Guna2Button();
            this.panelTitlebar.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.panelDateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitlebar
            // 
            this.panelTitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(55)))), ((int)(((byte)(230)))));
            this.panelTitlebar.Controls.Add(this.btn_Fullscreen);
            this.panelTitlebar.Controls.Add(this.btn_Minimize);
            this.panelTitlebar.Controls.Add(this.label1);
            this.panelTitlebar.Controls.Add(this.lblName);
            this.panelTitlebar.Controls.Add(this.btn_exit);
            this.panelTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlebar.Location = new System.Drawing.Point(101, 0);
            this.panelTitlebar.Name = "panelTitlebar";
            this.panelTitlebar.Size = new System.Drawing.Size(799, 45);
            this.panelTitlebar.TabIndex = 3;
            this.panelTitlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitlebar_MouseDown);
            // 
            // btn_Fullscreen
            // 
            this.btn_Fullscreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Fullscreen.Animated = true;
            this.btn_Fullscreen.BackColor = System.Drawing.Color.Transparent;
            this.btn_Fullscreen.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Fullscreen.BorderRadius = 10;
            this.btn_Fullscreen.CheckedState.Parent = this.btn_Fullscreen;
            this.btn_Fullscreen.CustomImages.Parent = this.btn_Fullscreen;
            this.btn_Fullscreen.FillColor = System.Drawing.Color.Transparent;
            this.btn_Fullscreen.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_Fullscreen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Fullscreen.ForeColor = System.Drawing.Color.White;
            this.btn_Fullscreen.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Fullscreen.HoverState.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.btn_Fullscreen.HoverState.Image = global::Education_Center.Properties.Resources.fullscreeeniconB;
            this.btn_Fullscreen.HoverState.Parent = this.btn_Fullscreen;
            this.btn_Fullscreen.Image = global::Education_Center.Properties.Resources.fullscreeeniconW;
            this.btn_Fullscreen.ImageSize = new System.Drawing.Size(24, 24);
            this.btn_Fullscreen.Location = new System.Drawing.Point(725, 7);
            this.btn_Fullscreen.Name = "btn_Fullscreen";
            this.btn_Fullscreen.ShadowDecoration.Parent = this.btn_Fullscreen;
            this.btn_Fullscreen.Size = new System.Drawing.Size(30, 30);
            this.btn_Fullscreen.TabIndex = 8;
            this.btn_Fullscreen.Click += new System.EventHandler(this.Guna2GradientButton2_Click);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimize.Animated = true;
            this.btn_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minimize.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Minimize.BorderRadius = 10;
            this.btn_Minimize.CheckedState.Parent = this.btn_Minimize;
            this.btn_Minimize.CustomImages.Parent = this.btn_Minimize;
            this.btn_Minimize.FillColor = System.Drawing.Color.Transparent;
            this.btn_Minimize.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_Minimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Minimize.ForeColor = System.Drawing.Color.White;
            this.btn_Minimize.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_Minimize.HoverState.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.btn_Minimize.HoverState.Image = global::Education_Center.Properties.Resources.minimizeiconB;
            this.btn_Minimize.HoverState.Parent = this.btn_Minimize;
            this.btn_Minimize.Image = global::Education_Center.Properties.Resources.minimizeiconW;
            this.btn_Minimize.ImageSize = new System.Drawing.Size(23, 23);
            this.btn_Minimize.Location = new System.Drawing.Point(692, 7);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.ShadowDecoration.Parent = this.btn_Minimize;
            this.btn_Minimize.Size = new System.Drawing.Size(30, 30);
            this.btn_Minimize.TabIndex = 7;
            this.btn_Minimize.Click += new System.EventHandler(this.Btn_Minimize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome Back,";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(143, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(166, 29);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name Of User";
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.Animated = true;
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.BorderColor = System.Drawing.Color.Transparent;
            this.btn_exit.BorderRadius = 10;
            this.btn_exit.CheckedState.Parent = this.btn_exit;
            this.btn_exit.CustomImages.Parent = this.btn_exit;
            this.btn_exit.FillColor = System.Drawing.Color.Transparent;
            this.btn_exit.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_exit.HoverState.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.btn_exit.HoverState.Image = global::Education_Center.Properties.Resources.icons8_multiply_55px_1;
            this.btn_exit.HoverState.Parent = this.btn_exit;
            this.btn_exit.Image = global::Education_Center.Properties.Resources.icons8_multiply_55px_2;
            this.btn_exit.ImageSize = new System.Drawing.Size(28, 28);
            this.btn_exit.Location = new System.Drawing.Point(758, 7);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.ShadowDecoration.Parent = this.btn_exit;
            this.btn_exit.Size = new System.Drawing.Size(30, 30);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Click += new System.EventHandler(this.Guna2GradientButton1_Click);
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.panelDateTime);
            this.panelHome.Controls.Add(this.gunaPictureBox2);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(101, 45);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(799, 555);
            this.panelHome.TabIndex = 4;
            this.panelHome.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelHome_Paint);
            // 
            // panelDateTime
            // 
            this.panelDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDateTime.Controls.Add(this.lblDate);
            this.panelDateTime.Controls.Add(this.lblTime);
            this.panelDateTime.Location = new System.Drawing.Point(420, 443);
            this.panelDateTime.Name = "panelDateTime";
            this.panelDateTime.Size = new System.Drawing.Size(355, 100);
            this.panelDateTime.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Cursor = System.Windows.Forms.Cursors.No;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblDate.Location = new System.Drawing.Point(58, 60);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(61, 25);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTime.Location = new System.Drawing.Point(62, 10);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(134, 55);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Time";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(271, 84);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(256, 256);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gunaPictureBox2.TabIndex = 3;
            this.gunaPictureBox2.TabStop = false;
            this.gunaPictureBox2.MouseHover += new System.EventHandler(this.GunaPictureBox2_MouseHover);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btn_SignOut);
            this.bunifuGradientPanel1.Controls.Add(this.btnSettings);
            this.bunifuGradientPanel1.Controls.Add(this.gunaPictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.btnDashbord);
            this.bunifuGradientPanel1.Controls.Add(this.btnTeacher);
            this.bunifuGradientPanel1.Controls.Add(this.btnBook);
            this.bunifuGradientPanel1.Controls.Add(this.btnHome);
            this.bunifuGradientPanel1.Controls.Add(this.btnStudent);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(232)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(200)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(200)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(44)))), ((int)(((byte)(232)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(101, 600);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // btn_SignOut
            // 
            this.btn_SignOut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_SignOut.Animated = true;
            this.btn_SignOut.BackColor = System.Drawing.Color.Transparent;
            this.btn_SignOut.BorderColor = System.Drawing.Color.Transparent;
            this.btn_SignOut.BorderRadius = 15;
            this.btn_SignOut.CheckedState.Parent = this.btn_SignOut;
            this.btn_SignOut.CustomImages.Parent = this.btn_SignOut;
            this.btn_SignOut.FillColor = System.Drawing.Color.Transparent;
            this.btn_SignOut.FillColor2 = System.Drawing.Color.Transparent;
            this.btn_SignOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_SignOut.ForeColor = System.Drawing.Color.White;
            this.btn_SignOut.HoverState.FillColor = System.Drawing.Color.LightCoral;
            this.btn_SignOut.HoverState.FillColor2 = System.Drawing.Color.LightCoral;
            this.btn_SignOut.HoverState.Image = global::Education_Center.Properties.Resources.exiticonB;
            this.btn_SignOut.HoverState.Parent = this.btn_SignOut;
            this.btn_SignOut.Image = global::Education_Center.Properties.Resources.exiticonW;
            this.btn_SignOut.Location = new System.Drawing.Point(20, 514);
            this.btn_SignOut.Name = "btn_SignOut";
            this.btn_SignOut.ShadowDecoration.Parent = this.btn_SignOut;
            this.btn_SignOut.Size = new System.Drawing.Size(60, 50);
            this.btn_SignOut.TabIndex = 7;
            this.btn_SignOut.Click += new System.EventHandler(this.Btn_SignOut_Click);
            this.btn_SignOut.MouseHover += new System.EventHandler(this.Btn_SignOut_MouseHover);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BorderColor = System.Drawing.Color.Transparent;
            this.btnSettings.BorderRadius = 15;
            this.btnSettings.BorderThickness = 1;
            this.btnSettings.CheckedState.Parent = this.btnSettings;
            this.btnSettings.CustomImages.Parent = this.btnSettings;
            this.btnSettings.FillColor = System.Drawing.Color.Transparent;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnSettings.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnSettings.HoverState.Image = global::Education_Center.Properties.Resources.settingsiconB;
            this.btnSettings.HoverState.Parent = this.btnSettings;
            this.btnSettings.Image = global::Education_Center.Properties.Resources.settingsiconW;
            this.btnSettings.Location = new System.Drawing.Point(20, 417);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.ShadowDecoration.Parent = this.btnSettings;
            this.btnSettings.Size = new System.Drawing.Size(60, 50);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            this.btnSettings.MouseHover += new System.EventHandler(this.BtnSettings_MouseHover);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(101, 109);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // btnDashbord
            // 
            this.btnDashbord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDashbord.BackColor = System.Drawing.Color.Transparent;
            this.btnDashbord.BorderColor = System.Drawing.Color.Transparent;
            this.btnDashbord.BorderRadius = 15;
            this.btnDashbord.BorderThickness = 1;
            this.btnDashbord.CheckedState.Parent = this.btnDashbord;
            this.btnDashbord.CustomImages.Parent = this.btnDashbord;
            this.btnDashbord.FillColor = System.Drawing.Color.Transparent;
            this.btnDashbord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDashbord.ForeColor = System.Drawing.Color.White;
            this.btnDashbord.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnDashbord.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnDashbord.HoverState.Image = global::Education_Center.Properties.Resources.charticonB;
            this.btnDashbord.HoverState.Parent = this.btnDashbord;
            this.btnDashbord.Image = global::Education_Center.Properties.Resources.charticonW;
            this.btnDashbord.Location = new System.Drawing.Point(20, 361);
            this.btnDashbord.Name = "btnDashbord";
            this.btnDashbord.ShadowDecoration.Parent = this.btnDashbord;
            this.btnDashbord.Size = new System.Drawing.Size(60, 50);
            this.btnDashbord.TabIndex = 5;
            this.btnDashbord.Click += new System.EventHandler(this.BtnDashbord_Click);
            this.btnDashbord.MouseHover += new System.EventHandler(this.BtnDashbord_MouseHover);
            // 
            // btnTeacher
            // 
            this.btnTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTeacher.BackColor = System.Drawing.Color.Transparent;
            this.btnTeacher.BorderColor = System.Drawing.Color.Transparent;
            this.btnTeacher.BorderRadius = 15;
            this.btnTeacher.BorderThickness = 1;
            this.btnTeacher.CheckedState.Parent = this.btnTeacher;
            this.btnTeacher.CustomImages.Parent = this.btnTeacher;
            this.btnTeacher.FillColor = System.Drawing.Color.Transparent;
            this.btnTeacher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTeacher.ForeColor = System.Drawing.Color.White;
            this.btnTeacher.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnTeacher.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnTeacher.HoverState.Image = global::Education_Center.Properties.Resources.teachericonB;
            this.btnTeacher.HoverState.Parent = this.btnTeacher;
            this.btnTeacher.Image = global::Education_Center.Properties.Resources.teachericonW;
            this.btnTeacher.Location = new System.Drawing.Point(20, 249);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.ShadowDecoration.Parent = this.btnTeacher;
            this.btnTeacher.Size = new System.Drawing.Size(60, 50);
            this.btnTeacher.TabIndex = 5;
            this.btnTeacher.Click += new System.EventHandler(this.BtnTeacher_Click_1);
            this.btnTeacher.MouseHover += new System.EventHandler(this.BtnTeacher_MouseHover);
            // 
            // btnBook
            // 
            this.btnBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBook.BackColor = System.Drawing.Color.Transparent;
            this.btnBook.BorderColor = System.Drawing.Color.Transparent;
            this.btnBook.BorderRadius = 15;
            this.btnBook.BorderThickness = 1;
            this.btnBook.CheckedState.Parent = this.btnBook;
            this.btnBook.CustomImages.Parent = this.btnBook;
            this.btnBook.FillColor = System.Drawing.Color.Transparent;
            this.btnBook.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBook.ForeColor = System.Drawing.Color.White;
            this.btnBook.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnBook.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnBook.HoverState.Image = global::Education_Center.Properties.Resources.booksiconB;
            this.btnBook.HoverState.Parent = this.btnBook;
            this.btnBook.Image = global::Education_Center.Properties.Resources.booksiconW;
            this.btnBook.Location = new System.Drawing.Point(20, 305);
            this.btnBook.Name = "btnBook";
            this.btnBook.ShadowDecoration.Parent = this.btnBook;
            this.btnBook.Size = new System.Drawing.Size(60, 50);
            this.btnBook.TabIndex = 5;
            this.btnBook.Click += new System.EventHandler(this.BtnBook_Click);
            this.btnBook.MouseHover += new System.EventHandler(this.BtnBook_MouseHover);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderRadius = 15;
            this.btnHome.BorderThickness = 1;
            this.btnHome.CheckedState.Parent = this.btnHome;
            this.btnHome.CustomImages.Parent = this.btnHome;
            this.btnHome.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnHome.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.HoverState.Image = global::Education_Center.Properties.Resources.homeiconB;
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.Image = global::Education_Center.Properties.Resources.homeiconW;
            this.btnHome.Location = new System.Drawing.Point(20, 137);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(60, 50);
            this.btnHome.TabIndex = 5;
            this.btnHome.Click += new System.EventHandler(this.BtnHome_Click_1);
            this.btnHome.MouseHover += new System.EventHandler(this.BtnHome_MouseHover);
            // 
            // btnStudent
            // 
            this.btnStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStudent.BackColor = System.Drawing.Color.Transparent;
            this.btnStudent.BorderColor = System.Drawing.Color.Transparent;
            this.btnStudent.BorderRadius = 15;
            this.btnStudent.BorderThickness = 1;
            this.btnStudent.CheckedState.Parent = this.btnStudent;
            this.btnStudent.CustomImages.Parent = this.btnStudent;
            this.btnStudent.FillColor = System.Drawing.Color.Transparent;
            this.btnStudent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStudent.ForeColor = System.Drawing.Color.White;
            this.btnStudent.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btnStudent.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnStudent.HoverState.Image = global::Education_Center.Properties.Resources.studenticonB;
            this.btnStudent.HoverState.Parent = this.btnStudent;
            this.btnStudent.Image = global::Education_Center.Properties.Resources.studenticonW;
            this.btnStudent.Location = new System.Drawing.Point(20, 193);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.ShadowDecoration.Parent = this.btnStudent;
            this.btnStudent.Size = new System.Drawing.Size(60, 50);
            this.btnStudent.TabIndex = 5;
            this.btnStudent.Click += new System.EventHandler(this.BtnStudent_Click_1);
            this.btnStudent.MouseHover += new System.EventHandler(this.BtnStudent_MouseHover);
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelTitlebar);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Home";
            this.panelTitlebar.ResumeLayout(false);
            this.panelTitlebar.PerformLayout();
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.panelDateTime.ResumeLayout(false);
            this.panelDateTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_exit;
        private System.Windows.Forms.Panel panelTitlebar;
        private System.Windows.Forms.Panel panelHome;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnSettings;
        private Guna.UI2.WinForms.Guna2Button btnDashbord;
        private Guna.UI2.WinForms.Guna2Button btnBook;
        private Guna.UI2.WinForms.Guna2Button btnTeacher;
        private Guna.UI2.WinForms.Guna2Button btnStudent;
        private System.Windows.Forms.Panel panelDateTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_SignOut;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Fullscreen;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Minimize;
    }
}