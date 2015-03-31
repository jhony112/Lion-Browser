using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LiOnBrowser
{
    public partial class Form1 : Form
    {
        private Point _imagelocation = new Point(15, 5);
        private Point _imhHitArea = new Point(13, 2);
       
        public Form1()
        {

            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            //this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //System.Reflection.Assembly thisExe;
            //thisExe = System.Reflection.Assembly.GetExecutingAssembly();
            //string[] resources = thisExe.GetManifestResourceNames();
            //string list = "";
            //foreach (string resourse in resources)
            //{
            //    MessageBox.Show(resourse);
            //}
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.userControl11.Controls.Add(this.userControl11.TabPages[0]);
        }

        private void closeTabToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            //TabControl tc = (TabControl)sender;
            //Point p=e.Location;
            //    int _tabWidth=0;
            //    _tabWidth = this.tabControl1.GetTabRect(tc.SelectedIndex).Width - (_imhHitArea.X);
            //    Rectangle r = this.tabControl1.GetTabRect(tc.SelectedIndex);
            //    r.Offset(_tabWidth, _imhHitArea.Y);
            //    r.Width = 16;
            //    r.Height = 16;
            //    if (r.Contains(p))
            //    {
            //        TabPage Tabp = (TabPage)tc.TabPages[tc.SelectedIndex];
            //        tc.TabPages.Remove(Tabp);
        }

        private void ambiance_TabControl1_MouseDown(object sender, MouseEventArgs e)
        { 
            for (int i = 0; i < this.ambiance_TabControl1.TabPages.Count; i++)
                {
                    Rectangle r = ambiance_TabControl1.GetTabRect(i);
                    //Getting the position of the "x" mark.
                    Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 7, 9, 7);
                    if (closeButton.Contains(e.Location))
                    {
                        if (MessageBox.Show("Would you like to Close this Tab?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            this.ambiance_TabControl1.TabPages.RemoveAt(i);
                            break;
                        }
                    }
                }
            }

        private void ambiance_Button_11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Maxbtn_Click(object sender, EventArgs e)
        {
            if
            (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                Maxbtn.Text = "[]";
            }
            else if (this.WindowState == FormWindowState.Normal) {
                this.WindowState = FormWindowState.Maximized;
                Maxbtn.Text = "()";
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



            //private void ambiance_TabControl1_DrawItem(object sender, DrawItemEventArgs e)
            //{
            //    MessageBox.Show("Test");
            //    e.Graphics.DrawString("x", e.Font, Brushes.Red, e.Bounds.Right - 15, e.Bounds.Top + 4);
            //    e.Graphics.DrawString(this.ambiance_TabControl1.TabPages[e.Index].Text, e.Font, Brushes.Red, e.Bounds.Left + 12, e.Bounds.Top + 4);
            //    e.DrawFocusRectangle();

            //}

            //private void ambiance_TabControl1_MouseDown(object sender, MouseEventArgs e)
            //{
            //    for (int i = 0; i < this.ambiance_TabControl1.TabPages.Count; i++)
            //    {
            //        Rectangle r = ambiance_TabControl1.GetTabRect(i);
            //        //Getting the position of the "x" mark.
            //        Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 9, 7);
            //        if (closeButton.Contains(e.Location))
            //        {
            //            if (MessageBox.Show("Would you like to Close this Tab?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //            {
            //                this.ambiance_TabControl1.TabPages.RemoveAt(i);
            //                break;
            //            }
            //        }
            //    }
            //}
        }

    }

