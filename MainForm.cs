using System;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Resources;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Windows.Forms;


namespace Tortank
{
    public partial class MainForm : Form
    {
        private string nomFichier = "save.xml";
        private string pathAbsolute = @"C:\MonAlbumPerso";
        private Size albumPictureSize; 
        private CollectionAlbum cAlbum;
        private TreeNode nodePrincipale;
        private ImageList img = new ImageList();
        private int albumSelected = 0;

        public MainForm()
        {
            InitializeComponent();
            
            Initialize();
            InitializeEventHandler();
            updateTreeNode();
            cAlbum.listeAlbum.LargeImageList = img;
            cAlbum.listeAlbum.Size = panel_folder.Size;
            panel_folder.Controls.Add(cAlbum.listeAlbum);
            cAlbum.listeAlbum.AllowDrop = true;
            
            
        }

        /*
         * Initialise les différentes images ainsi que les variables.
         * La collection d'album est généré grace au fichier xml 
         * 
         */

        public void Initialize()
        {
            Assembly assembly;
            Stream imageStream;
            StreamReader textStreamReader;

            try
               {
                  assembly = Assembly.GetExecutingAssembly();
                  imageStream = assembly.GetManifestResourceStream("Tortank.dossier.png.bmp");
                  img.Images.Add(new Bitmap(imageStream));
                  //textStreamReader = new StreamReader(assembly.GetManifestResourceStream("MyNamespace.MyTextFile.txt"));
               }
            catch
               {
           
               }
            
            albumPictureSize = new Size(50, 50);
            img.ImageSize = albumPictureSize;

            cAlbum = new CollectionAlbum();
            List<Album> oldList = Serialize.loadXML(nomFichier);
            foreach (Album alb in oldList)
            {
                this.AddAlbum(alb);
            }

            if (cAlbum.Count() != 0)
            {
                panel_Picture.Controls.Clear();
                panel_Picture.Controls.Add(cAlbum.getAlbum(0).listPicture);
                cAlbum.getAlbum(0).listPicture.Size = panel_Picture.Size;
                albumSelected = 0;
                updateInfoAlbum();
            }
            else
            {
                ListView buffer = new ListView();
                buffer.Size = panel_Picture.Size;
                panel_Picture.Controls.Add(buffer);
            }
        }

        public void InitializeEventHandler()
        {
            cAlbum.listeAlbum.DragEnter += new DragEventHandler(this.listAlbum_DragEnter);
            cAlbum.listeAlbum.DragDrop += new DragEventHandler(this.listPicture_DragDrop);
            cAlbum.listeAlbum.DragOver += new DragEventHandler(this.listAlbum_DragOver);
            cAlbum.listeAlbum.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewFolder_ItemChecked);
        }

        public void updateTreeNode()
        {
            treeViewAlbums.Nodes.Clear();
            nodePrincipale = new TreeNode("Photo Viewer");
            TreeNode buffer = new TreeNode();
            if (cAlbum.Count() != 0)
            {
                for(int i=0;i<cAlbum.Count();i++){
                   // nodePrincipale.Nodes.Add(cAlbum.getAlbum(i).title);
                    buffer = new TreeNode(cAlbum.getAlbum(i).title);
                    for (int j = 0; j < cAlbum.getAlbum(i).listPath.Count; j++)
                    {
                        buffer.Nodes.Add(cAlbum.getAlbum(i).listPath[j]);
                    }
                    nodePrincipale.Nodes.Add(buffer);
                }
                
            }
            treeViewAlbums.Nodes.Add(nodePrincipale);
        }

        /*
         * Lors du clic de création d'album, une nouvelle form s'ouvre et une fois fermé (en verifiant le resultat) 
         * On recupere l'album crée dans cette form pour l'ajouter à la collection         * 
         */

        private void buttonCreateAlbum_Click(object sender, EventArgs e)
        {
            CreationAlbum ca = new CreationAlbum(pathAbsolute);
            if (ca.ShowDialog() == DialogResult.OK)
            {
                Album album = ca.alb;
                this.AddAlbum(album);
                updateInfoAlbum();
                panel_Picture.Controls.Clear();
                panel_Picture.Controls.Add(album.listPicture);
                album.listPicture.Size = panel_Picture.Size;
                updateTreeNode();
            }        
        }

        private void AddAlbum(Album album)
        {
            album.listPicture.MouseDown += new MouseEventHandler(this.listPicture_MouseDown);
            album.listPicture.DragEnter += new DragEventHandler(this.listPicture_DragEnter);
            album.listPicture.AllowDrop = true;
            album.updateImageList();
            album.listPicture.MultiSelect = true;
            cAlbum.add(album);
            albumSelected = cAlbum.Count() - 1;
           
        }
     
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int valToDelete = -1;
            Boolean bSelected = false;
            for (int i = 0; i < cAlbum.listeAlbum.Items.Count; i++)
            {
                if (cAlbum.listeAlbum.Items[i].Selected == true)
                {
                    bSelected = true;
                    valToDelete = i;
                    break;
                    
                }
            }

            if (bSelected)
            {
                panel_Picture.Controls.Clear();
                ListView buffer = (new ListView());
                buffer.Size = panel_Picture.Size;
                panel_Picture.Controls.Add(buffer);
                cAlbum.RemoveAt(valToDelete);
                albumSelected = 0;
                updateInfoAlbum();
                updateTreeNode();
            }
        }

        private void listViewFolder_ItemChecked(object sender, EventArgs e)
        {
            for (int i = 0; i < cAlbum.listeAlbum.Items.Count; i++)
            {
                if (cAlbum.listeAlbum.Items[i].Selected == true)
                {
                    panel_Picture.Controls.Clear();
                    panel_Picture.Controls.Add(cAlbum.getAlbum(i).listPicture);
                    cAlbum.getAlbum(i).listPicture.Size = panel_Picture.Size;
                    cAlbum.getAlbum(i).listPicture.MultiSelect = true;
                    albumSelected = i;
                    updateInfoAlbum();
                    break;
                }
            }

                
        }

        /*
         * Fonction de mise à jour de la fenetre de description de l'album selection
         */

        private void updateInfoAlbum()
        {
            if ((albumSelected < cAlbum.Count()) && cAlbum.Count() !=0 )
            {
                labelTitleCurrentAlbum.Text = cAlbum.getAlbum(albumSelected).title;
                labelSubtitlesCurrentAlbum.Text = cAlbum.getAlbum(albumSelected).subtitle;
                labelDateCurrentAlbum.Text = cAlbum.getAlbum(albumSelected).dateOfEvent;
                labelKeywordCurrentAlbum.Text = cAlbum.getAlbum(albumSelected).motsCle;
            }
            else
            {
                labelTitleCurrentAlbum.Text = "";
                labelSubtitlesCurrentAlbum.Text = "";
                labelDateCurrentAlbum.Text = "";
                labelKeywordCurrentAlbum.Text = "";
            }
        }

        private void button_add_picture_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileInfo fInfo = null;

                for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
                {
                    fInfo = new FileInfo(openFileDialog1.FileNames[i]);
                    cAlbum.getAlbum(albumSelected).add(fInfo);
                    panel_Picture.Controls.Clear();
                    panel_Picture.Controls.Add(cAlbum.getAlbum(albumSelected).listPicture);
                    updateTreeNode();
                }  
            }
           
        }
        // Efface l'image présente dans le panel
        private void button_delete_picture_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cAlbum.getAlbum(albumSelected).listPicture.Items.Count; i++)
            {
                if (cAlbum.getAlbum(albumSelected).listPicture.Items[i].Selected == true)
                {
                    Console.WriteLine("L'item  " + i + " est selectionne");
                    cAlbum.getAlbum(albumSelected).RemovePictureAt(i);
                    updateTreeNode();
                }

            }
        }

        // Affiche l'image en plein écran
        private void buttonFullscreen(object sender, EventArgs e)
        {
            for (int i = 0; i < cAlbum.getAlbum(albumSelected).listPicture.Items.Count; i++)
            {
                if (cAlbum.getAlbum(albumSelected).listPicture.Items[i].Selected == true)
                {
                    FullScreen fs = new FullScreen(cAlbum.getAlbum(albumSelected).getNamePicture(i));
                }
            }
        }

        // 1er évenement du Drag & Drop: l'utilisateur click sur l'image 
        private void listPicture_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Clicks == 1)
            {
                List<ListViewItem> toSend =new List<ListViewItem>();
                for (int i = 0; i < cAlbum.getAlbum(albumSelected).listPicture.Items.Count; i++)
                {
                    if (cAlbum.getAlbum(albumSelected).listPicture.Items[i].Selected == true)
                    {
                        toSend.Add(cAlbum.getAlbum(albumSelected).listPicture.Items[i]);
                    }
                }
                if (toSend != null) cAlbum.getAlbum(albumSelected).listPicture.DoDragDrop(toSend, DragDropEffects.Copy); // Copie de l'image sur laquelle l'utilisateur a clické
            }
        }

        // 2ème évenement du drag & drop: l'utilisateur maintient le click et 
        //glisse l'image pour l'introduire dans la zone choisie
        private void listPicture_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
           
        }

        // 2ème évenement du drag & drop: l'utilisateur maintient le click et 
        //glisse l'album pour l'introduire dans la zone choisie
        private void listAlbum_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

        }

        /*
         * Fonction drop : Dépot des fichiers selectionne dans l'album
         * et suppression dans le précedant
         */

        private void listPicture_DragDrop(object sender, DragEventArgs e)
        {
            List<ListViewItem> lvi = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));  
            for (int i = 0; i < cAlbum.listeAlbum.Items.Count; i++)
                {
                    Point Souris_ecran = new Point(e.X, e.Y);
                    Point Souris = panel_folder.PointToClient(Souris_ecran);
                    Point Item = cAlbum.listeAlbum.Items[i].Position;
                    if (Souris.X > Item.X && Souris.X < Item.X + 50 && Souris.Y > Item.Y && Souris.Y < Item.Y + 50)
                    {
                        for (int j = 0; j < lvi.Count; j++)
                        {
                            cAlbum.getAlbum(i).add(new FileInfo((string)lvi[j].Tag));
                            cAlbum.getAlbum(albumSelected).RemovePictureByName((string)lvi[j].Tag);
                        }
                       
                    }
                }
           
        }
        /*
         * Fonction pour surligner les albums en dessous de la souris
         */

        private void listAlbum_DragOver(object sender, DragEventArgs e)
        {
            Point Souris_ecran = new Point(e.X, e.Y);
            Point Souris = panel_folder.PointToClient(Souris_ecran);
            cAlbum.listeAlbum.Select();
            for (int i = 0; i < cAlbum.listeAlbum.Items.Count; i++)
            {
                Point Item = cAlbum.listeAlbum.Items[i].Position;
                if (Souris.X > Item.X && Souris.X < Item.X + 50 && Souris.Y > Item.Y && Souris.Y < Item.Y + 50)
                {
                    cAlbum.listeAlbum.Items[i].Selected = true;  
                }
                else cAlbum.listeAlbum.Items[i].Selected = false;
            }      
        }

        /*
         * Surcharge de la méthode OnFormClosing, fermeture de la fenetre avec le croix rouge.         * 
         */

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            cAlbum.Serialize();
            Serialize.saveXML(cAlbum.getSerialize(), nomFichier);
        }

        private void buttonSlideShow_Click(object sender, EventArgs e)
        {
            SlideShow sw = new SlideShow(cAlbum.getAlbum(albumSelected));
        }

        /*
         * Fonction de modification d'album, et modifie l'album selectionne
         */
        private void buttonModifyAlbum_Click(object sender, EventArgs e)
        {
            ModifierAlbum modif = new ModifierAlbum(cAlbum.getAlbum(albumSelected));
            if (modif.ShowDialog() == DialogResult.OK)
            {
                cAlbum.getAlbum(albumSelected).title = modif.titleToReturn;
                cAlbum.getAlbum(albumSelected).subtitle = modif.subTitleToReturn;
                cAlbum.getAlbum(albumSelected).motsCle = modif.keywordToReturn;
                cAlbum.getAlbum(albumSelected).dateOfEvent = modif.dateToReturn;
                updateTreeNode();
            }
        }

        /*
         * Lance une page HTML avec les images de l'album 
         * ATTENTION : Firefox peut empecher la page de s'ouvrir
         */

        private void buttonWebClick(object sender, EventArgs e)
        {
            StringWriter stringwriter = new StringWriter();
            // Write into the HTML file
            stringwriter.WriteLine("<!DOCTYPE html");
            stringwriter.WriteLine("<html>");
            stringwriter.WriteLine("<body>");
            stringwriter.WriteLine("<h1>Photo Viewer</h1>");
            stringwriter.WriteLine("<p>Gareth Dys - Damien Marguerite - Samuel Thomas");
            // Pictures display
            foreach (string element in cAlbum.getAlbum(albumSelected).listPath)
            {
                stringwriter.WriteLine("<td width=\"120\" align=\"center\"><a href=\"web.html\">");
                stringwriter.WriteLine("<img src= \"" + element + "\" alt = \"\" title=\""+cAlbum.getAlbum(albumSelected).title+"\" />");
            }
            stringwriter.WriteLine("</body>");
            stringwriter.WriteLine("</html>");
            // WriteAllText creates a file, writes the specified string to the file
            System.IO.File.WriteAllText(@"c:\Users\Public\web.html", stringwriter.ToString());
            // Launch the HTML file in default web browser
            System.Diagnostics.Process.Start(@"c:\Users\Public\web.html");            
        }
    }
}
