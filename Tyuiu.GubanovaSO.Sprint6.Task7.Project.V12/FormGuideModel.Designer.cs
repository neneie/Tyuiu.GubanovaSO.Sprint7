namespace Tyuiu.GubanovaSO.Sprint6.Task7.Project.V12
{
    partial class FormGuideModel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuideModel));
            pictureBox1_GSO = new PictureBox();
            labelGuide_GSO = new Label();
            pictureBox2_GSO = new PictureBox();
            pictureBox3_GSO = new PictureBox();
            pictureBox4_GSO = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_GSO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2_GSO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3_GSO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4_GSO).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1_GSO
            // 
            pictureBox1_GSO.Image = (Image)resources.GetObject("pictureBox1_GSO.Image");
            pictureBox1_GSO.Location = new Point(12, 51);
            pictureBox1_GSO.Name = "pictureBox1_GSO";
            pictureBox1_GSO.Size = new Size(570, 125);
            pictureBox1_GSO.TabIndex = 0;
            pictureBox1_GSO.TabStop = false;
            // 
            // labelGuide_GSO
            // 
            labelGuide_GSO.AutoSize = true;
            labelGuide_GSO.Location = new Point(12, 9);
            labelGuide_GSO.Name = "labelGuide_GSO";
            labelGuide_GSO.Size = new Size(917, 540);
            labelGuide_GSO.TabIndex = 1;
            labelGuide_GSO.Text = resources.GetString("labelGuide_GSO.Text");
            labelGuide_GSO.Click += label1_Click;
            // 
            // pictureBox2_GSO
            // 
            pictureBox2_GSO.Image = (Image)resources.GetObject("pictureBox2_GSO.Image");
            pictureBox2_GSO.Location = new Point(12, 552);
            pictureBox2_GSO.Name = "pictureBox2_GSO";
            pictureBox2_GSO.Size = new Size(414, 192);
            pictureBox2_GSO.TabIndex = 2;
            pictureBox2_GSO.TabStop = false;
            // 
            // pictureBox3_GSO
            // 
            pictureBox3_GSO.Image = (Image)resources.GetObject("pictureBox3_GSO.Image");
            pictureBox3_GSO.Location = new Point(12, 239);
            pictureBox3_GSO.Name = "pictureBox3_GSO";
            pictureBox3_GSO.Size = new Size(810, 119);
            pictureBox3_GSO.TabIndex = 3;
            pictureBox3_GSO.TabStop = false;
            // 
            // pictureBox4_GSO
            // 
            pictureBox4_GSO.Image = (Image)resources.GetObject("pictureBox4_GSO.Image");
            pictureBox4_GSO.Location = new Point(12, 422);
            pictureBox4_GSO.Name = "pictureBox4_GSO";
            pictureBox4_GSO.Size = new Size(810, 53);
            pictureBox4_GSO.TabIndex = 4;
            pictureBox4_GSO.TabStop = false;
            // 
            // FormGuideModel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(932, 755);
            Controls.Add(pictureBox4_GSO);
            Controls.Add(pictureBox3_GSO);
            Controls.Add(pictureBox2_GSO);
            Controls.Add(pictureBox1_GSO);
            Controls.Add(labelGuide_GSO);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(950, 802);
            MinimumSize = new Size(950, 802);
            Name = "FormGuideModel";
            Text = "Руководство";
            ((System.ComponentModel.ISupportInitialize)pictureBox1_GSO).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2_GSO).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3_GSO).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4_GSO).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1_GSO;
        private Label labelGuide_GSO;
        private PictureBox pictureBox2_GSO;
        private PictureBox pictureBox3_GSO;
        private PictureBox pictureBox4_GSO;
    }
}