namespace Tortank
{
    partial class CreationAlbum
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
            this.buttonCreateAlbum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSubTitles = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxKeyWords = new System.Windows.Forms.TextBox();
            this.textBoxMonthDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxYearDate = new System.Windows.Forms.TextBox();
            this.textBoxDayDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCreateAlbum
            // 
            this.buttonCreateAlbum.Location = new System.Drawing.Point(39, 219);
            this.buttonCreateAlbum.Name = "buttonCreateAlbum";
            this.buttonCreateAlbum.Size = new System.Drawing.Size(241, 35);
            this.buttonCreateAlbum.TabIndex = 0;
            this.buttonCreateAlbum.Text = "Creer Nouvel Album";
            this.buttonCreateAlbum.UseVisualStyleBackColor = true;
            this.buttonCreateAlbum.Click += new System.EventHandler(this.buttonCreateAlbum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titre";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(136, 29);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(144, 20);
            this.textBoxTitle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sous-Titre";
            // 
            // textBoxSubTitles
            // 
            this.textBoxSubTitles.Location = new System.Drawing.Point(136, 67);
            this.textBoxSubTitles.Name = "textBoxSubTitles";
            this.textBoxSubTitles.Size = new System.Drawing.Size(144, 20);
            this.textBoxSubTitles.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mots Clés";
            // 
            // textBoxKeyWords
            // 
            this.textBoxKeyWords.Location = new System.Drawing.Point(136, 159);
            this.textBoxKeyWords.Name = "textBoxKeyWords";
            this.textBoxKeyWords.Size = new System.Drawing.Size(144, 20);
            this.textBoxKeyWords.TabIndex = 5;
            // 
            // textBoxMonthDate
            // 
            this.textBoxMonthDate.Location = new System.Drawing.Point(186, 114);
            this.textBoxMonthDate.Name = "textBoxMonthDate";
            this.textBoxMonthDate.Size = new System.Drawing.Size(35, 20);
            this.textBoxMonthDate.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "/";
            // 
            // textBoxYearDate
            // 
            this.textBoxYearDate.Location = new System.Drawing.Point(245, 114);
            this.textBoxYearDate.Name = "textBoxYearDate";
            this.textBoxYearDate.Size = new System.Drawing.Size(35, 20);
            this.textBoxYearDate.TabIndex = 5;
            // 
            // textBoxDayDate
            // 
            this.textBoxDayDate.Location = new System.Drawing.Point(136, 114);
            this.textBoxDayDate.Name = "textBoxDayDate";
            this.textBoxDayDate.Size = new System.Drawing.Size(35, 20);
            this.textBoxDayDate.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "/";
            // 
            // CreationAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 293);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDayDate);
            this.Controls.Add(this.textBoxYearDate);
            this.Controls.Add(this.textBoxMonthDate);
            this.Controls.Add(this.textBoxKeyWords);
            this.Controls.Add(this.textBoxSubTitles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCreateAlbum);
            this.Name = "CreationAlbum";
            this.Text = "CreationAlbum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateAlbum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSubTitles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxKeyWords;
        private System.Windows.Forms.TextBox textBoxMonthDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxYearDate;
        private System.Windows.Forms.TextBox textBoxDayDate;
        private System.Windows.Forms.Label label6;
    }
}