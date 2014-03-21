using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace Tortank
{

    public class CollectionAlbum 
    {
        public List<Album> toSerialize;
        [XmlIgnore]
        public ListView listeAlbum;


        public CollectionAlbum()
        {
            listeAlbum = new ListView();
            
            listeAlbum.View = View.LargeIcon;
        }

        public int Count()
        {
            return listeAlbum.Items.Count;
        }

        public void add(Album alb)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = alb.title;
            lvi.Tag = alb;
            lvi.ImageIndex = 0;
            listeAlbum.Items.Add(lvi);
            alb.updateListView();
        }

        public void setListAlbum(List<Album> listAlbum)
        {
            foreach (Album alb in listAlbum)
            {
                this.add(alb);
            }
        }

        public Album getAlbum(int val)
        {
            Album albToReturn;
            if (val < listeAlbum.Items.Count)
            {
                albToReturn = (Album)listeAlbum.Items[val].Tag;
            }
            else
            {
                albToReturn = new Album();
            }
            return albToReturn;
        }

        public void Serialize()
        {
            toSerialize = new List<Album>();
            Album albBuffer;
            for (int i = 0; i < listeAlbum.Items.Count; i++)
            {
                albBuffer = (Album)listeAlbum.Items[i].Tag;
 
                toSerialize.Add(albBuffer);
            }
        }

        public List<Album> getSerialize()
        {
            return toSerialize;
        }

        public void Deserialize()
        {
            for (int i = 0; i < toSerialize.Count; i++)
            {
                this.add(toSerialize[i]);
            }
        }

        public void RemoveAt(int val)
        {
            listeAlbum.Items.RemoveAt(val);
        }

        public List<Album> getAlbumChecked()
        {
            List<Album> tabAlbumToReturn = new List<Album>();

            for (int i = 0; i < listeAlbum.Items.Count; i++)
            {
                if (listeAlbum.Items[i].Selected == true)
                {
                    tabAlbumToReturn.Add((Album)listeAlbum.Items[i].Tag);
                }
            }

            return tabAlbumToReturn;
        }
    }
}
