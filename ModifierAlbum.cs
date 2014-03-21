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
    public partial class ModifierAlbum : Form
    {
        public string titleToReturn { get; set; }
        public string subTitleToReturn { get; set; }
        public string dateToReturn { get; set; }
        public string keywordToReturn { get; set; }

        public ModifierAlbum(Album alb)
        {
            InitializeComponent();
            textBoxAlbumSubTitle.Text = alb.subtitle;
            textboxAlbumTitle.Text = alb.title;
            textBoxDate.Text = alb.dateOfEvent;
            textBoxKeyWords.Text = alb.motsCle;
        }

        private void buttonModifyAlbumProperties_Click(object sender, EventArgs e)
        {
            titleToReturn = textboxAlbumTitle.Text;
            subTitleToReturn = textBoxAlbumSubTitle.Text;
            dateToReturn = textBoxDate.Text;
            keywordToReturn = textBoxKeyWords.Text;
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }

    }
}
