using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tortank
{
    public partial class FullScreen : Form
    {
        PictureBox pBox;
        public FullScreen(String namePicture)
        {
            InitializeComponent();
            pBox = new PictureBox();
            this.Size = this.MaximumSize;
            this.BackColor = Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            pBox.ImageLocation = namePicture;
            pBox.Dock = DockStyle.Fill;
            pBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pBox.BackColor = Color.Black;
            this.Controls.Add(pBox);
            this.Show();

            
        }

        private void keyboradPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
