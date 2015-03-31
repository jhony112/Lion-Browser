using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LiOnBrowser
{
    public partial class Eachtab : UserControl
    {
        Form1 myparent;
        Control controler;
        TabPage misty;
        System.IO.Stream s1 = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("LiOnBrowser.Resources.Nex64tdark.png");
        
        System.IO.Stream s2 = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("LiOnBrowser.Resources.Nex64t.png");
        
        System.IO.Stream s3 = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("LiOnBrowser.Resources.Previous64dark.png");
        
        System.IO.Stream s4 = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("LiOnBrowser.Resources.Previous64.png");
        Icon[] iconarray=new Icon[7];
        public Eachtab()
        {
            InitializeComponent();
          //  back.Image = imageList1.Images[0];
           // Foward.Image = imageList1.Images[1];

            myparent = (Form1)this.ParentForm;
           controler = this.Parent;
         misty = (TabPage)controler;
          
        }

        private void monoFlat_Panel1_Click(object sender, EventArgs e)
        {
            
        }

        private void Foward_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {

        }

        private void ambiance_TextBox1_TextChanged(object sender, EventArgs e)
        {
            
            Ambiance.Ambiance_TextBox mine = (Ambiance.Ambiance_TextBox)sender;
            if (mine.Text.Contains("http://"))
            {
               // MessageBox.Show("correct");
            }
            else
            {
                mine.Text = "http://" + mine.Text;

            }
        }

        private void Foward_MouseHover(object sender, EventArgs e)
        {
            Bitmap bmp1 = new Bitmap(s1);
            Foward.Image = bmp1;
           //MessageBox.Show("Hover");
        }

        private void back_MouseHover(object sender, EventArgs e)
        {
            Bitmap bmp1 = new Bitmap(s3);
            
            Back.Image = bmp1;
          //  MessageBox.Show("Hover");
        }

        private void Foward_MouseLeave(object sender, EventArgs e)
        {
            Bitmap bmp1 = new Bitmap(s2);
            Foward.Image = bmp1;
        }

        private void Back_MouseLeave(object sender, EventArgs e)
        {
            Bitmap bmp1 = new Bitmap(s4);

            Back.Image = bmp1;
        }
       
        private void Eachtab_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 7; i++)
            {
                Bitmap b = new Bitmap(imagelist.Images[i]);
                IntPtr hicon = b.GetHicon();
                iconarray[i] = System.Drawing.Icon.FromHandle(hicon);
                b.Dispose();
                b = null;
            }
        }

        private void monoFlat_Button1_Click(object sender, EventArgs e)
        {
            Browser.Navigate(mainurl.Text);
            timer1.Start();
        }

        private void mainurl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                monoFlat_Button1_Click(this, new EventArgs());
            }
        }

        private void Enter_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Boolean loading = false;
            try
            {
                if (loading == true)
                {
                    return;
                }
                loading = true;
                int i = 0;
              // controler.
           // misty. = iconarray[i];
                i = i + 1;
            if (i >= 8){
                i = 0;
            } 
                
            }
            catch (Exception)
            {
                loading = false;
                
            }

        }

        private void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

       
    }
}
