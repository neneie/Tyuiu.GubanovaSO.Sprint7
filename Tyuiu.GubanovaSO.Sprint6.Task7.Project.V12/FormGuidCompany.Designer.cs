namespace Tyuiu.GubanovaSO.Sprint6.Task7.Project.V12
{
    partial class FormGuidCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuidCompany));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(548, 144);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 237);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(633, 248);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 540);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(368, 84);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(829, 40);
            label1.TabIndex = 3;
            label1.Text = "Найдите и нажмите на кнопку \"Добавить\". После нажатия кнопки \"Добавить\" откроется новое окно. В этом окне Вы \r\nувидите файлы с другими фирмами-производителями. \r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 214);
            label2.Name = "label2";
            label2.Size = new Size(840, 20);
            label2.TabIndex = 4;
            label2.Text = "Щелкните правой кнопкой мыши в пустом месте окна проводника. Выберите \"Создать\" и затем \"Лист Microsoft Excel\".";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 497);
            label3.Name = "label3";
            label3.Size = new Size(820, 40);
            label3.TabIndex = 5;
            label3.Text = "Назовите файл в формате \"название_брендаInPutFile\", например: \"XiaomiInPutFile\". Убедитесь, что файл сохранен с \r\nрасширением .cvs ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 636);
            label4.Name = "label4";
            label4.Size = new Size(858, 40);
            label4.TabIndex = 6;
            label4.Text = resources.GetString("label4.Text");
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 679);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(805, 53);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 745);
            label5.Name = "label5";
            label5.Size = new Size(824, 60);
            label5.TabIndex = 8;
            label5.Text = resources.GetString("label5.Text");
            // 
            // FormGuidCompany
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(875, 812);
            Controls.Add(label5);
            Controls.Add(pictureBox4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(893, 859);
            MinimumSize = new Size(893, 859);
            Name = "FormGuidCompany";
            Text = "Руководство";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox4;
        private Label label5;
    }
}