namespace LiOnBrowser
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenu();
            this.closeToolStripMenuItem = new System.Windows.Forms.MenuItem();
            this.closeAllButThisToolStripMenuItem = new System.Windows.Forms.MenuItem();
            this.closeTabToolStripMenuItem = new System.Windows.Forms.MenuItem();
            this.imagelist = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.monoFlat_ThemeContainer1 = new MonoFlat_ThemeContainer();
            this.MainTab = new KRBTabControl.KRBTabControl();
            this.tabPageEx3 = new KRBTabControl.TabPageEx();
            this.tabPageEx1 = new KRBTabControl.TabPageEx();
            this.monoFlat_Button1 = new MonoFlat_Button();
            this.monoFlat_HeaderLabel1 = new MonoFlat_HeaderLabel();
            this.Maxbtn = new Ambiance.Ambiance_Button_1();
            this.closebtn = new Ambiance.Ambiance_Button_1();
            this.ambiance_Button_11 = new Ambiance.Ambiance_Button_1();
            this.eachtab1 = new LiOnBrowser.Eachtab();
            this.monoFlat_ThemeContainer1.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.tabPageEx3.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Password.png");
            this.imageList1.Images.SetKeyName(1, "User.png");
            this.imageList1.Images.SetKeyName(2, "1401943218_new-message.png");
            this.imageList1.Images.SetKeyName(3, "back-icon1.png");
            this.imageList1.Images.SetKeyName(4, "rss.jpg");
            this.imageList1.Images.SetKeyName(5, "rss.png");
            this.imageList1.Images.SetKeyName(6, "rss_logo.jpg");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.closeToolStripMenuItem,
            this.closeAllButThisToolStripMenuItem,
            this.closeTabToolStripMenuItem});
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Index = 0;
            this.closeToolStripMenuItem.Text = "New Tab";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // closeAllButThisToolStripMenuItem
            // 
            this.closeAllButThisToolStripMenuItem.Index = 1;
            this.closeAllButThisToolStripMenuItem.Text = "Close all other tabs";
            // 
            // closeTabToolStripMenuItem
            // 
            this.closeTabToolStripMenuItem.Index = 2;
            this.closeTabToolStripMenuItem.Text = "Close tab";
            this.closeTabToolStripMenuItem.Click += new System.EventHandler(this.closeTabToolStripMenuItem_Click);
            // 
            // imagelist
            // 
            this.imagelist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagelist.ImageStream")));
            this.imagelist.TransparentColor = System.Drawing.Color.Transparent;
            this.imagelist.Images.SetKeyName(0, "01.ico");
            this.imagelist.Images.SetKeyName(1, "2.ico");
            this.imagelist.Images.SetKeyName(2, "3.ico");
            this.imagelist.Images.SetKeyName(3, "4.ico");
            this.imagelist.Images.SetKeyName(4, "5.ico");
            this.imagelist.Images.SetKeyName(5, "6.ico");
            this.imagelist.Images.SetKeyName(6, "7.ico");
            this.imagelist.Images.SetKeyName(7, "8.ico");
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // monoFlat_ThemeContainer1
            // 
            this.monoFlat_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.monoFlat_ThemeContainer1.Controls.Add(this.MainTab);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_Button1);
            this.monoFlat_ThemeContainer1.Controls.Add(this.monoFlat_HeaderLabel1);
            this.monoFlat_ThemeContainer1.Controls.Add(this.Maxbtn);
            this.monoFlat_ThemeContainer1.Controls.Add(this.closebtn);
            this.monoFlat_ThemeContainer1.Controls.Add(this.ambiance_Button_11);
            this.monoFlat_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monoFlat_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monoFlat_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.monoFlat_ThemeContainer1.Name = "monoFlat_ThemeContainer1";
            this.monoFlat_ThemeContainer1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.monoFlat_ThemeContainer1.RoundCorners = true;
            this.monoFlat_ThemeContainer1.Sizable = true;
            this.monoFlat_ThemeContainer1.Size = new System.Drawing.Size(1303, 733);
            this.monoFlat_ThemeContainer1.SmartBounds = true;
            this.monoFlat_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.monoFlat_ThemeContainer1.TabIndex = 0;
            // 
            // MainTab
            // 
            this.MainTab.AllowDrop = true;
            this.MainTab.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.MainTab.BackgroundHatcher.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MainTab.BackgroundHatcher.ForeColor = System.Drawing.Color.Gainsboro;
            this.MainTab.BackgroundHatcher.HatchStyle = "DiagonalBrick";
            this.MainTab.BackgroundHatcher.HatchType = System.Drawing.Drawing2D.HatchStyle.DiagonalBrick;
            this.MainTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainTab.BackgroundImage")));
            this.MainTab.CaptionButtons.InactiveCaptionButtonsColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MainTab.CaptionRandomizer.Transparency = ((byte)(255));
            this.MainTab.Controls.Add(this.tabPageEx3);
            this.MainTab.Controls.Add(this.tabPageEx1);
            this.MainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainTab.GradientCaption.InactiveCaptionColorEnd = System.Drawing.SystemColors.ActiveBorder;
            this.MainTab.GradientCaption.InactiveCaptionColorStart = System.Drawing.SystemColors.ActiveBorder;
            this.MainTab.GradientCaption.InactiveCaptionTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MainTab.HeaderStyle = KRBTabControl.KRBTabControl.TabHeaderStyle.Texture;
            this.MainTab.ImageList = this.imagelist;
            this.MainTab.IsDrawHeader = false;
            this.MainTab.ItemSize = new System.Drawing.Size(0, 30);
            this.MainTab.Location = new System.Drawing.Point(10, 70);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(1283, 654);
            this.MainTab.TabGradient.ColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(3)))));
            this.MainTab.TabGradient.ColorStart = System.Drawing.Color.Green;
            this.MainTab.TabGradient.GradientStyle = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.MainTab.TabGradient.TabPageSelectedTextColor = System.Drawing.Color.White;
            this.MainTab.TabGradient.TabPageTextColor = System.Drawing.Color.DimGray;
            this.MainTab.TabHOffset = -2;
            this.MainTab.TabIndex = 7;
            this.MainTab.TabPageCloseIconColor = System.Drawing.Color.White;
            this.MainTab.UpDownStyle = KRBTabControl.KRBTabControl.UpDown32Style.OfficeBlue;
            // 
            // tabPageEx3
            // 
            this.tabPageEx3.BackColor = System.Drawing.SystemColors.Window;
            this.tabPageEx3.Controls.Add(this.eachtab1);
            this.tabPageEx3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPageEx3.Location = new System.Drawing.Point(1, 36);
            this.tabPageEx3.Name = "tabPageEx3";
            this.tabPageEx3.Size = new System.Drawing.Size(1281, 596);
            this.tabPageEx3.TabIndex = 0;
            this.tabPageEx3.Text = "Server Settings";
            // 
            // tabPageEx1
            // 
            this.tabPageEx1.BackColor = System.Drawing.Color.White;
            this.tabPageEx1.Font = new System.Drawing.Font("Arial", 10F);
            this.tabPageEx1.Location = new System.Drawing.Point(1, 36);
            this.tabPageEx1.Name = "tabPageEx1";
            this.tabPageEx1.Size = new System.Drawing.Size(1281, 596);
            this.tabPageEx1.TabIndex = 1;
            this.tabPageEx1.Text = "Schedules";
            // 
            // monoFlat_Button1
            // 
            this.monoFlat_Button1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_Button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.monoFlat_Button1.Image = null;
            this.monoFlat_Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.monoFlat_Button1.Location = new System.Drawing.Point(10, 5);
            this.monoFlat_Button1.Name = "monoFlat_Button1";
            this.monoFlat_Button1.Size = new System.Drawing.Size(83, 41);
            this.monoFlat_Button1.TabIndex = 5;
            this.monoFlat_Button1.Text = "Menu";
            this.monoFlat_Button1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // monoFlat_HeaderLabel1
            // 
            this.monoFlat_HeaderLabel1.AutoSize = true;
            this.monoFlat_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.monoFlat_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monoFlat_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.monoFlat_HeaderLabel1.Location = new System.Drawing.Point(425, 9);
            this.monoFlat_HeaderLabel1.Name = "monoFlat_HeaderLabel1";
            this.monoFlat_HeaderLabel1.Size = new System.Drawing.Size(169, 37);
            this.monoFlat_HeaderLabel1.TabIndex = 4;
            this.monoFlat_HeaderLabel1.Text = "Lion Browser";
            // 
            // Maxbtn
            // 
            this.Maxbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maxbtn.BackColor = System.Drawing.Color.Transparent;
            this.Maxbtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Maxbtn.Image = null;
            this.Maxbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Maxbtn.Location = new System.Drawing.Point(1201, 0);
            this.Maxbtn.Name = "Maxbtn";
            this.Maxbtn.Size = new System.Drawing.Size(48, 22);
            this.Maxbtn.TabIndex = 2;
            this.Maxbtn.Text = "[   ]";
            this.Maxbtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Maxbtn.Click += new System.EventHandler(this.Maxbtn_Click);
            // 
            // closebtn
            // 
            this.closebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closebtn.BackColor = System.Drawing.Color.Transparent;
            this.closebtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.closebtn.Image = null;
            this.closebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closebtn.Location = new System.Drawing.Point(1257, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(46, 22);
            this.closebtn.TabIndex = 1;
            this.closebtn.Text = "X";
            this.closebtn.TextAlignment = System.Drawing.StringAlignment.Center;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // ambiance_Button_11
            // 
            this.ambiance_Button_11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ambiance_Button_11.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Button_11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ambiance_Button_11.Image = null;
            this.ambiance_Button_11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ambiance_Button_11.Location = new System.Drawing.Point(1144, 0);
            this.ambiance_Button_11.Margin = new System.Windows.Forms.Padding(2);
            this.ambiance_Button_11.Name = "ambiance_Button_11";
            this.ambiance_Button_11.Size = new System.Drawing.Size(45, 22);
            this.ambiance_Button_11.TabIndex = 3;
            this.ambiance_Button_11.Text = "-";
            this.ambiance_Button_11.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ambiance_Button_11.Click += new System.EventHandler(this.ambiance_Button_11_Click);
            // 
            // eachtab1
            // 
            this.eachtab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eachtab1.Location = new System.Drawing.Point(0, 0);
            this.eachtab1.Name = "eachtab1";
            this.eachtab1.Size = new System.Drawing.Size(1281, 596);
            this.eachtab1.TabIndex = 0;
            this.eachtab1.Load += new System.EventHandler(this.eachtab1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1303, 733);
            this.Controls.Add(this.monoFlat_ThemeContainer1);
            this.Font = new System.Drawing.Font("Myriad Pro Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.monoFlat_ThemeContainer1.ResumeLayout(false);
            this.monoFlat_ThemeContainer1.PerformLayout();
            this.MainTab.ResumeLayout(false);
            this.tabPageEx3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenu contextMenuStrip1;
        private System.Windows.Forms.MenuItem closeToolStripMenuItem;
        private System.Windows.Forms.MenuItem closeAllButThisToolStripMenuItem;
        private System.Windows.Forms.MenuItem closeTabToolStripMenuItem;


        private MonoFlat_ThemeContainer monoFlat_ThemeContainer1;
        private Ambiance.Ambiance_Button_1 ambiance_Button_11;
        private Ambiance.Ambiance_Button_1 Maxbtn;
        private Ambiance.Ambiance_Button_1 closebtn;
        private MonoFlat_HeaderLabel monoFlat_HeaderLabel1;
        private MonoFlat_Button monoFlat_Button1;
        private System.Windows.Forms.ImageList imagelist;
        private System.Windows.Forms.Timer timer1;
        private KRBTabControl.KRBTabControl MainTab;
        private KRBTabControl.TabPageEx tabPageEx3;
        private KRBTabControl.TabPageEx tabPageEx1;
        private Eachtab eachtab1;
       
    }
}

