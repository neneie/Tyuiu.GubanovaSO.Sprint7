namespace Tyuiu.GubanovaSO.Sprint6.Task7.Project.V12
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            label1 = new Label();
            buttonOk_GSO = new Button();
            pictureBoxI_GSO = new PictureBox();
            labelWho_GSO = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxI_GSO).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 48);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // buttonOk_GSO
            // 
            buttonOk_GSO.BackColor = Color.LightCoral;
            buttonOk_GSO.Location = new Point(561, 261);
            buttonOk_GSO.Margin = new Padding(3, 4, 3, 4);
            buttonOk_GSO.Name = "buttonOk_GSO";
            buttonOk_GSO.Size = new Size(90, 36);
            buttonOk_GSO.TabIndex = 1;
            buttonOk_GSO.Text = "OK";
            buttonOk_GSO.UseVisualStyleBackColor = false;
            buttonOk_GSO.Click += button1_Click;
            // 
            // pictureBoxI_GSO
            // 
            pictureBoxI_GSO.Image = (Image)resources.GetObject("pictureBoxI_GSO.Image");
            pictureBoxI_GSO.Location = new Point(13, 16);
            pictureBoxI_GSO.Margin = new Padding(3, 4, 3, 4);
            pictureBoxI_GSO.Name = "pictureBoxI_GSO";
            pictureBoxI_GSO.Size = new Size(215, 281);
            pictureBoxI_GSO.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxI_GSO.TabIndex = 2;
            pictureBoxI_GSO.TabStop = false;
            // 
            // labelWho_GSO
            // 
            labelWho_GSO.AutoSize = true;
            labelWho_GSO.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelWho_GSO.Location = new Point(234, 48);
            labelWho_GSO.Name = "labelWho_GSO";
            labelWho_GSO.Size = new Size(418, 120);
            labelWho_GSO.TabIndex = 3;
            labelWho_GSO.Text = resources.GetString("labelWho_GSO.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(663, 311);
            Controls.Add(labelWho_GSO);
            Controls.Add(pictureBoxI_GSO);
            Controls.Add(buttonOk_GSO);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(681, 358);
            MinimumSize = new Size(681, 358);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxI_GSO).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOk_GSO;
        private System.Windows.Forms.PictureBox pictureBoxI_GSO;
        private Label labelWho_GSO;
    }
}