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
    public partial class SlideShow : Form
    {
        private List<string> lNamePicture;
        private Album alb;
        private PictureBox pBox;
        private int cpt;

        public SlideShow(Album newAlbum)
        {
            InitializeComponent();
            lNamePicture = new List<string>();
            pBox = new PictureBox();
            cpt = 0;
            alb = newAlbum;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pBox.Dock = DockStyle.Fill;


            if (alb.listPath.Count != 0)
            {
                pBox.ImageLocation = alb.listPath[0];
                this.Show();
            }
            else this.Dispose();
            this.panelMain.Controls.Add(pBox);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                pBox.ImageLocation = alb.listPath[cpt];
                cpt++;
            }
            catch (ArgumentOutOfRangeException emh)
            {

            }
            if (cpt >= alb.listPath.Count)
            {
                cpt = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = timer1.Interval + 100;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(timer1.Interval > 100) timer1.Interval = timer1.Interval - 100;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Right:
                    cpt++;
                    if (cpt >= alb.listPath.Count)
                    {
                        cpt = 0;
                    }
                    pBox.ImageLocation = alb.listPath[cpt];
                    break;

                case Keys.Left:
                    cpt--;
                    if (cpt < 0)
                    {
                        cpt = alb.listPath.Count-1;
                       
                    }
                    pBox.ImageLocation = alb.listPath[cpt];
                    break;

                case Keys.Escape:
                    this.Dispose();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
