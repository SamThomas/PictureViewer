namespace Tortank
{
    partial class SlideShow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlideShow));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonNextSlide = new System.Windows.Forms.Button();
            this.buttonPreviousSlide = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonNextSlide
            // 
            this.buttonNextSlide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextSlide.Image = ((System.Drawing.Image)(resources.GetObject("buttonNextSlide.Image")));
            this.buttonNextSlide.Location = new System.Drawing.Point(1280, 321);
            this.buttonNextSlide.Name = "buttonNextSlide";
            this.buttonNextSlide.Size = new System.Drawing.Size(75, 72);
            this.buttonNextSlide.TabIndex = 0;
            this.buttonNextSlide.Text = "+";
            this.buttonNextSlide.UseVisualStyleBackColor = true;
            this.buttonNextSlide.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPreviousSlide
            // 
            this.buttonPreviousSlide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreviousSlide.Image = ((System.Drawing.Image)(resources.GetObject("buttonPreviousSlide.Image")));
            this.buttonPreviousSlide.Location = new System.Drawing.Point(12, 321);
            this.buttonPreviousSlide.Name = "buttonPreviousSlide";
            this.buttonPreviousSlide.Size = new System.Drawing.Size(75, 72);
            this.buttonPreviousSlide.TabIndex = 0;
            this.buttonPreviousSlide.Text = "-";
            this.buttonPreviousSlide.UseVisualStyleBackColor = true;
            this.buttonPreviousSlide.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(104, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1170, 718);
            this.panelMain.TabIndex = 1;
            // 
            // SlideShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 742);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.buttonPreviousSlide);
            this.Controls.Add(this.buttonNextSlide);
            this.Name = "SlideShow";
            this.Text = "SlideShow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonNextSlide;
        private System.Windows.Forms.Button buttonPreviousSlide;
        private System.Windows.Forms.Panel panelMain;
    }
}