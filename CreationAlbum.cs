using System;
using System.IO;
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
    public partial class CreationAlbum : Form
    {
        public Album alb { get; set; }
        private string pathToCheck;

        public CreationAlbum(string path)
        {
            InitializeComponent();
            pathToCheck = path;
        }

        private void buttonCreateAlbum_Click(object sender, EventArgs e)
        {
            string str = pathToCheck + "\\" + textBoxTitle.Text;
            if (!Directory.Exists(str))
            {
                alb = new Album();
                alb.title = textBoxTitle.Text;
                alb.subtitle = textBoxSubTitles.Text;
                alb.motsCle = textBoxKeyWords.Text;
                alb.dateOfEvent = textBoxDayDate.Text + "/" + textBoxMonthDate.Text + "/" + textBoxYearDate.Text;
                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Le dossier existe deja");
            }
            
        }

    }
}
