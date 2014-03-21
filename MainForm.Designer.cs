namespace Tortank
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.treeViewAlbums = new System.Windows.Forms.TreeView();
            this.button_new_folder = new System.Windows.Forms.Button();
            this.button_delete_folder = new System.Windows.Forms.Button();
            this.panel_folder = new System.Windows.Forms.Panel();
            this.panel_Picture = new System.Windows.Forms.Panel();
            this.button_add_picture = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_delete_picture = new System.Windows.Forms.Button();
            this.buttonFullScreen = new System.Windows.Forms.Button();
            this.buttonSlideShow = new System.Windows.Forms.Button();
            this.buttonModifyAlbum = new System.Windows.Forms.Button();
            this.buttonWeb = new System.Windows.Forms.Button();
            this.panelPropriete = new System.Windows.Forms.Panel();
            this.labelTitleCurrentAlbum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelKeywordCurrentAlbum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelDateCurrentAlbum = new System.Windows.Forms.Label();
            this.labelSubtitlesCurrentAlbum = new System.Windows.Forms.Label();
            this.panelPropriete.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewAlbums
            // 
            this.treeViewAlbums.Location = new System.Drawing.Point(28, 51);
            this.treeViewAlbums.Name = "treeViewAlbums";
            this.treeViewAlbums.Size = new System.Drawing.Size(167, 189);
            this.treeViewAlbums.TabIndex = 0;
            // 
            // button_new_folder
            // 
            this.button_new_folder.AutoSize = true;
            this.button_new_folder.Image = ((System.Drawing.Image)(resources.GetObject("button_new_folder.Image")));
            this.button_new_folder.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_new_folder.Location = new System.Drawing.Point(222, 48);
            this.button_new_folder.Name = "button_new_folder";
            this.button_new_folder.Size = new System.Drawing.Size(60, 67);
            this.button_new_folder.TabIndex = 1;
            this.button_new_folder.UseVisualStyleBackColor = true;
            this.button_new_folder.Click += new System.EventHandler(this.buttonCreateAlbum_Click);
            // 
            // button_delete_folder
            // 
            this.button_delete_folder.Image = ((System.Drawing.Image)(resources.GetObject("button_delete_folder.Image")));
            this.button_delete_folder.Location = new System.Drawing.Point(222, 121);
            this.button_delete_folder.Name = "button_delete_folder";
            this.button_delete_folder.Size = new System.Drawing.Size(60, 61);
            this.button_delete_folder.TabIndex = 3;
            this.button_delete_folder.UseVisualStyleBackColor = true;
            this.button_delete_folder.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // panel_folder
            // 
            this.panel_folder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel_folder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_folder.Location = new System.Drawing.Point(301, 51);
            this.panel_folder.Name = "panel_folder";
            this.panel_folder.Size = new System.Drawing.Size(242, 420);
            this.panel_folder.TabIndex = 4;
            // 
            // panel_Picture
            // 
            this.panel_Picture.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel_Picture.Location = new System.Drawing.Point(595, 51);
            this.panel_Picture.Name = "panel_Picture";
            this.panel_Picture.Size = new System.Drawing.Size(242, 420);
            this.panel_Picture.TabIndex = 5;
            // 
            // button_add_picture
            // 
            this.button_add_picture.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button_add_picture.FlatAppearance.BorderSize = 12;
            this.button_add_picture.Image = ((System.Drawing.Image)(resources.GetObject("button_add_picture.Image")));
            this.button_add_picture.Location = new System.Drawing.Point(867, 51);
            this.button_add_picture.Name = "button_add_picture";
            this.button_add_picture.Size = new System.Drawing.Size(54, 54);
            this.button_add_picture.TabIndex = 6;
            this.button_add_picture.UseVisualStyleBackColor = true;
            this.button_add_picture.Click += new System.EventHandler(this.button_add_picture_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // button_delete_picture
            // 
            this.button_delete_picture.Image = ((System.Drawing.Image)(resources.GetObject("button_delete_picture.Image")));
            this.button_delete_picture.Location = new System.Drawing.Point(867, 112);
            this.button_delete_picture.Name = "button_delete_picture";
            this.button_delete_picture.Size = new System.Drawing.Size(54, 55);
            this.button_delete_picture.TabIndex = 7;
            this.button_delete_picture.UseVisualStyleBackColor = true;
            this.button_delete_picture.Click += new System.EventHandler(this.button_delete_picture_Click);
            // 
            // buttonFullScreen
            // 
            this.buttonFullScreen.Image = ((System.Drawing.Image)(resources.GetObject("buttonFullScreen.Image")));
            this.buttonFullScreen.Location = new System.Drawing.Point(867, 173);
            this.buttonFullScreen.Name = "buttonFullScreen";
            this.buttonFullScreen.Size = new System.Drawing.Size(55, 62);
            this.buttonFullScreen.TabIndex = 8;
            this.buttonFullScreen.UseVisualStyleBackColor = true;
            this.buttonFullScreen.Click += new System.EventHandler(this.buttonFullscreen);
            // 
            // buttonSlideShow
            // 
            this.buttonSlideShow.Image = ((System.Drawing.Image)(resources.GetObject("buttonSlideShow.Image")));
            this.buttonSlideShow.Location = new System.Drawing.Point(469, 478);
            this.buttonSlideShow.Name = "buttonSlideShow";
            this.buttonSlideShow.Size = new System.Drawing.Size(227, 68);
            this.buttonSlideShow.TabIndex = 11;
            this.buttonSlideShow.UseVisualStyleBackColor = true;
            this.buttonSlideShow.Click += new System.EventHandler(this.buttonSlideShow_Click);
            // 
            // buttonModifyAlbum
            // 
            this.buttonModifyAlbum.Image = ((System.Drawing.Image)(resources.GetObject("buttonModifyAlbum.Image")));
            this.buttonModifyAlbum.Location = new System.Drawing.Point(228, 188);
            this.buttonModifyAlbum.Name = "buttonModifyAlbum";
            this.buttonModifyAlbum.Size = new System.Drawing.Size(54, 61);
            this.buttonModifyAlbum.TabIndex = 12;
            this.buttonModifyAlbum.UseVisualStyleBackColor = true;
            this.buttonModifyAlbum.Click += new System.EventHandler(this.buttonModifyAlbum_Click);
            // 
            // buttonWeb
            // 
            this.buttonWeb.Image = ((System.Drawing.Image)(resources.GetObject("buttonWeb.Image")));
            this.buttonWeb.Location = new System.Drawing.Point(867, 257);
            this.buttonWeb.Name = "buttonWeb";
            this.buttonWeb.Size = new System.Drawing.Size(54, 63);
            this.buttonWeb.TabIndex = 13;
            this.buttonWeb.UseVisualStyleBackColor = true;
            this.buttonWeb.Click += new System.EventHandler(this.buttonWebClick);
            // 
            // panelPropriete
            // 
            this.panelPropriete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPropriete.Controls.Add(this.labelTitleCurrentAlbum);
            this.panelPropriete.Controls.Add(this.label5);
            this.panelPropriete.Controls.Add(this.labelKeywordCurrentAlbum);
            this.panelPropriete.Controls.Add(this.label7);
            this.panelPropriete.Controls.Add(this.label6);
            this.panelPropriete.Controls.Add(this.labelDateCurrentAlbum);
            this.panelPropriete.Controls.Add(this.labelSubtitlesCurrentAlbum);
            this.panelPropriete.Location = new System.Drawing.Point(28, 310);
            this.panelPropriete.Name = "panelPropriete";
            this.panelPropriete.Size = new System.Drawing.Size(248, 161);
            this.panelPropriete.TabIndex = 14;
            // 
            // labelTitleCurrentAlbum
            // 
            this.labelTitleCurrentAlbum.AutoSize = true;
            this.labelTitleCurrentAlbum.Location = new System.Drawing.Point(95, 10);
            this.labelTitleCurrentAlbum.Name = "labelTitleCurrentAlbum";
            this.labelTitleCurrentAlbum.Size = new System.Drawing.Size(0, 13);
            this.labelTitleCurrentAlbum.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mots-Clés";
            // 
            // labelKeywordCurrentAlbum
            // 
            this.labelKeywordCurrentAlbum.AutoSize = true;
            this.labelKeywordCurrentAlbum.Location = new System.Drawing.Point(95, 124);
            this.labelKeywordCurrentAlbum.Name = "labelKeywordCurrentAlbum";
            this.labelKeywordCurrentAlbum.Size = new System.Drawing.Size(0, 13);
            this.labelKeywordCurrentAlbum.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sous-Titre";
            // 
            // labelDateCurrentAlbum
            // 
            this.labelDateCurrentAlbum.AutoSize = true;
            this.labelDateCurrentAlbum.Location = new System.Drawing.Point(95, 80);
            this.labelDateCurrentAlbum.Name = "labelDateCurrentAlbum";
            this.labelDateCurrentAlbum.Size = new System.Drawing.Size(0, 13);
            this.labelDateCurrentAlbum.TabIndex = 0;
            // 
            // labelSubtitlesCurrentAlbum
            // 
            this.labelSubtitlesCurrentAlbum.AutoSize = true;
            this.labelSubtitlesCurrentAlbum.Location = new System.Drawing.Point(95, 43);
            this.labelSubtitlesCurrentAlbum.Name = "labelSubtitlesCurrentAlbum";
            this.labelSubtitlesCurrentAlbum.Size = new System.Drawing.Size(0, 13);
            this.labelSubtitlesCurrentAlbum.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(953, 558);
            this.Controls.Add(this.panelPropriete);
            this.Controls.Add(this.buttonWeb);
            this.Controls.Add(this.buttonModifyAlbum);
            this.Controls.Add(this.buttonSlideShow);
            this.Controls.Add(this.buttonFullScreen);
            this.Controls.Add(this.button_delete_picture);
            this.Controls.Add(this.button_add_picture);
            this.Controls.Add(this.panel_Picture);
            this.Controls.Add(this.panel_folder);
            this.Controls.Add(this.button_delete_folder);
            this.Controls.Add(this.button_new_folder);
            this.Controls.Add(this.treeViewAlbums);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Photo Viewer";
            this.panelPropriete.ResumeLayout(false);
            this.panelPropriete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewAlbums;
        private System.Windows.Forms.Button button_new_folder;
        private System.Windows.Forms.Button button_delete_folder;
        private System.Windows.Forms.Panel panel_folder;
        private System.Windows.Forms.Panel panel_Picture;
        private System.Windows.Forms.Button button_add_picture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_delete_picture;
        private System.Windows.Forms.Button buttonFullScreen;
        private System.Windows.Forms.Button buttonSlideShow;
        private System.Windows.Forms.Button buttonModifyAlbum;
        private System.Windows.Forms.Button buttonWeb;
        private System.Windows.Forms.Panel panelPropriete;
        private System.Windows.Forms.Label labelTitleCurrentAlbum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelKeywordCurrentAlbum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelDateCurrentAlbum;
        private System.Windows.Forms.Label labelSubtitlesCurrentAlbum;
        protected System.Windows.Forms.Label label7;
    }
}

