using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using GongSolutions.Shell;
using System.Media;

namespace Transmitter
{
    public partial class Transmitter : Form
    {


        bool flag = true;
        public Transmitter()
        {
            InitializeComponent();


            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox1.Image = new Bitmap(Properties.Resources.comp);
            pictureBox2.Image = new Bitmap(Properties.Resources.Лист);
            pictureBox3.Image = new Bitmap(Properties.Resources.Папка);
            Exit.SizeMode = PictureBoxSizeMode.StretchImage;
            Exit.Image = new Bitmap(Properties.Resources.Close);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.Image = new Bitmap(Properties.Resources.Вопрос);

            Min.SizeMode = PictureBoxSizeMode.StretchImage;
            Min.Image = new Bitmap(Properties.Resources.Space);
            Max.SizeMode = PictureBoxSizeMode.StretchImage;
            Max.Image = new Bitmap(Properties.Resources.Square);

        }



        protected override void WndProc(ref Message m)
        {
            if ((m_ContextMenu == null) || (!m_ContextMenu.HandleMenuMessage(ref m)))
            {
                base.WndProc(ref m);
            }
        }

        //void shellView_Navigated(object sender, EventArgs e)
        //{
        //    backButton.Enabled = shellView.CanNavigateBack;
        //    forwardButton.Enabled = shellView.CanNavigateForward;
        //    upButton.Enabled = shellView.CanNavigateParent;
        //}

        void fileMenu_Popup(object sender, EventArgs e)
        {
            ShellItem[] selectedItems = shellView.SelectedItems;

            if (selectedItems.Length > 0)
            {
                m_ContextMenu = new ShellContextMenu(selectedItems);
            }
            else
            {
                m_ContextMenu = new ShellContextMenu(treeView.SelectedFolder);
            }

          
        }

        void refreshMenu_Click(object sender, EventArgs e)
        {
            shellView.RefreshContents();
            treeView.RefreshContents();
        }

       

        void backButton_Popup(object sender, EventArgs e)
        {
            List<MenuItem> items = new List<MenuItem>();

            foreach (ShellItem f in shellView.History.HistoryBack)
            {
                MenuItem item = new MenuItem(f.DisplayName);
                item.Tag = f;
                item.Click += new EventHandler(backButtonMenuItem_Click);
                items.Insert(0, item);
            }

          
        }

        void forwardButton_Popup(object sender, EventArgs e)
        {
           
            foreach (ShellItem f in shellView.History.HistoryForward)
            {
                MenuItem item = new MenuItem(f.DisplayName);
                item.Tag = f;
                item.Click += new EventHandler(forwardButtonMenuItem_Click);
              
            }
        }

        void backButtonMenuItem_Click(object sender, EventArgs e)
        {
            MenuItem item = (MenuItem)sender;
            ShellItem folder = (ShellItem)item.Tag;
            shellView.NavigateBack(folder);
        }

        void forwardButtonMenuItem_Click(object sender, EventArgs e)
        {
            MenuItem item = (MenuItem)sender;
            ShellItem folder = (ShellItem)item.Tag;
            shellView.NavigateForward(folder);
        }

        void ShellExplorer_ResizeEnd(object sender, EventArgs e)
        {
            int calculatedWidth = shellView.Width - shellView.GetColumnWidth(1)
                - shellView.GetColumnWidth(2) - shellView.GetColumnWidth(3) - 25;
            shellView.SetColumnWidth(0, calculatedWidth);
        }

        ShellContextMenu m_ContextMenu;


        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Min_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void Max_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                this.WindowState = FormWindowState.Maximized;
                Change();

                flag = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                Change();
                flag = true;
            }

        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void справкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.bing.com/search?q=%d1%81%d0%bf%d1%80%d0%b0%d0%b2%d0%ba%d0%b0+%d0%be%d0%b1+%d0%b8%d1%81%d0%bf%d0%be%d0%bb%d1%8c%d0%b7%d0%be%d0%b2%d0%b0%d0%bd%d0%b8%d0%b8+%d0%bf%d1%80%d0%be%d0%b2%d0%be%d0%b4%d0%bd%d0%b8%d0%ba%d0%b0+%d0%b2+windows&filters=guid:%224026535-ru-dia%22%20lang:%22ru%22&form=S00028");

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.bing.com/search?q=%d1%81%d0%bf%d1%80%d0%b0%d0%b2%d0%ba%d0%b0+%d0%be%d0%b1+%d0%b8%d1%81%d0%bf%d0%be%d0%bb%d1%8c%d0%b7%d0%be%d0%b2%d0%b0%d0%bd%d0%b8%d0%b8+%d0%bf%d1%80%d0%be%d0%b2%d0%be%d0%b4%d0%bd%d0%b8%d0%ba%d0%b0+%d0%b2+windows&filters=guid:%224026535-ru-dia%22%20lang:%22ru%22&form=S00028");

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 reg = new AboutBox1();

            reg.ShowDialog();
        }




        private void Change()
        {
            int PressF = this.Width;
            int ToPayRespect = this.Height;

            panel1.Width = PressF;
            panel2.Width = PressF;
            panel2.Height = ToPayRespect - 143;
            panel3.Width = PressF;
            panel3.Location = new Point(0, ToPayRespect - 39);
            panel5.Width = PressF;
            Min.Location = new Point(PressF - 142, 15);
            Exit.Location = new Point(PressF - 47, 15);
            Max.Location = new Point(PressF - 95, 15);
            pictureBox5.Location = new Point(PressF - 59, 4);
           
        }

        private void Open_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
           
          shellView.NavigateBack();
           
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            shellView.NavigateForward();
        }

        private void Up_Click(object sender, EventArgs e)
        {

            shellView.NavigateParent();
        }
    }
}
