namespace Tortank
{
    partial class ModifierAlbum
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonModifyAlbumProperties = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textboxAlbumTitle = new System.Windows.Forms.TextBox();
            this.textBoxAlbumSubTitle = new System.Windows.Forms.TextBox();
            this.textBoxKeyWords = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonModifyAlbumProperties
            // 
            this.buttonModifyAlbumProperties.Location = new System.Drawing.Point(31, 244);
            this.buttonModifyAlbumProperties.Name = "buttonModifyAlbumProperties";
            this.buttonModifyAlbumProperties.Size = new System.Drawing.Size(232, 58);
            this.buttonModifyAlbumProperties.TabIndex = 0;
            this.buttonModifyAlbumProperties.Text = "Modifier";
            this.buttonModifyAlbumProperties.UseVisualStyleBackColor = true;
            this.buttonModifyAlbumProperties.Click += new System.EventHandler(this.buttonModifyAlbumProperties_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sous-Titre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mots Clés";
            // 
            // textboxAlbumTitle
            // 
            this.textboxAlbumTitle.Location = new System.Drawing.Point(137, 41);
            this.textboxAlbumTitle.Name = "textboxAlbumTitle";
            this.textboxAlbumTitle.Size = new System.Drawing.Size(126, 20);
            this.textboxAlbumTitle.TabIndex = 2;
            // 
            // textBoxAlbumSubTitle
            // 
            this.textBoxAlbumSubTitle.Location = new System.Drawing.Point(137, 74);
            this.textBoxAlbumSubTitle.Name = "textBoxAlbumSubTitle";
            this.textBoxAlbumSubTitle.Size = new System.Drawing.Size(126, 20);
            this.textBoxAlbumSubTitle.TabIndex = 2;
            // 
            // textBoxKeyWords
            // 
            this.textBoxKeyWords.Location = new System.Drawing.Point(137, 153);
            this.textBoxKeyWords.Multiline = true;
            this.textBoxKeyWords.Name = "textBoxKeyWords";
            this.textBoxKeyWords.Size = new System.Drawing.Size(126, 66);
            this.textBoxKeyWords.TabIndex = 2;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(137, 113);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(126, 20);
            this.textBoxDate.TabIndex = 3;
            // 
            // ModifierAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 332);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxKeyWords);
            this.Controls.Add(this.textBoxAlbumSubTitle);
            this.Controls.Add(this.textboxAlbumTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonModifyAlbumProperties);
            this.Name = "ModifierAlbum";
            this.Text = "ModifierAlbum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonModifyAlbumProperties;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textboxAlbumTitle;
        private System.Windows.Forms.TextBox textBoxAlbumSubTitle;
        private System.Windows.Forms.TextBox textBoxKeyWords;
        private System.Windows.Forms.TextBox textBoxDate;
    }
}