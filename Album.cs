using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tortank
{
    [Serializable]
    public class Album
    {
        public List<string> listPath { get; set; }
        public string title { get; set; }
        public string subtitle { get; set; }
        public string motsCle { get; set; }
        public string dateOfEvent { get; set; }
        public DateTime dateOfCreation { get; set; }
        [XmlIgnore]
        public ListView listPicture { get; set; }
        [XmlIgnore]
        public ImageList imgList { get; set; }

        public Album()
        {
            title = "Unknown";
            subtitle = "subUnknown";
            dateOfCreation = new DateTime();
            dateOfCreation = DateTime.Now;
            listPicture = new ListView();
            imgList = new ImageList();
            listPath = new List<string>();
            imgList.ImageSize = new Size(50, 50);
            listPicture.LargeImageList = this.imgList;
            listPicture.MultiSelect = true;
        }

        public void add(FileInfo file)
        {
            Image imgToAdd = Image.FromFile(file.FullName);
            imgToAdd.Tag = file;
            imgList.Images.Add(imgToAdd);
            listPath.Add(file.FullName);
            updateListView();
        }

        public void updateImageList()
        {
            FileInfo file;
            Image imgToAdd;
            foreach (string str in listPath)
            {
                file = new FileInfo(str);
                try
                {
                    imgToAdd = Image.FromFile(file.FullName);
                    imgToAdd.Tag = file;
                    imgList.Images.Add(imgToAdd);
                    updateListView();
                }
                catch (FileNotFoundException e)
                {

                }
             }
        }

         public void updateListView()
        {
            ListViewItem lvi;
            listPicture.Items.Clear();
            for (int i = 0; i < imgList.Images.Count; i++)
            {
                lvi = new ListViewItem();
                lvi.Tag = listPath[i];
                lvi.ImageIndex = i;
                listPicture.Items.Add(lvi);
            }
        }

        public string getNamePicture(int val)
        {
            return listPath[val];
        }

        public void RemovePictureAt(int val)
        {
            imgList.Images.RemoveAt(val);
            listPath.RemoveAt(val);
            updateListView();
        }

        public void RemovePictureByName(string name)
        {
            for (int i = 0; i < listPath.Count; i++)
            {
                if (name == listPath[i])
                {
                    RemovePictureAt(i);
                    break;
                }
            }
        }
    }
}
