namespace Tyuiu.GubanovaSO.Sprint6.Task7.Project.V12
{
    partial class FormWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWelcome));
            labelWelcome_GSO = new Label();
            labelPress_GSO = new Label();
            buttonInfo_GSO = new Button();
            buttonNext_GSO = new Button();
            pictureBoxKitty_GSO = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxKitty_GSO).BeginInit();
            SuspendLayout();
            // 
            // labelWelcome_GSO
            // 
            labelWelcome_GSO.AutoSize = true;
            labelWelcome_GSO.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelWelcome_GSO.Location = new Point(12, 113);
            labelWelcome_GSO.Name = "labelWelcome_GSO";
            labelWelcome_GSO.Size = new Size(868, 38);
            labelWelcome_GSO.TabIndex = 0;
            labelWelcome_GSO.Text = "Добро пожаловать в навигатор по персональным ЭВМ\r\n";
            // 
            // labelPress_GSO
            // 
            labelPress_GSO.AutoSize = true;
            labelPress_GSO.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPress_GSO.Location = new Point(107, 166);
            labelPress_GSO.Name = "labelPress_GSO";
            labelPress_GSO.Size = new Size(657, 33);
            labelPress_GSO.TabIndex = 1;
            labelPress_GSO.Text = "Нажмите 'Далее', чтобы начать работу с приложением.";
            // 
            // buttonInfo_GSO
            // 
            buttonInfo_GSO.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonInfo_GSO.BackColor = Color.LightCoral;
            buttonInfo_GSO.BackgroundImageLayout = ImageLayout.Center;
            buttonInfo_GSO.Location = new Point(443, 252);
            buttonInfo_GSO.Margin = new Padding(3, 4, 3, 4);
            buttonInfo_GSO.Name = "buttonInfo_GSO";
            buttonInfo_GSO.Size = new Size(160, 62);
            buttonInfo_GSO.TabIndex = 2;
            buttonInfo_GSO.Text = "Информация о разработчиках";
            buttonInfo_GSO.UseVisualStyleBackColor = false;
            buttonInfo_GSO.Click += buttonInfo_GSO_Click;
            // 
            // buttonNext_GSO
            // 
            buttonNext_GSO.BackColor = Color.LightCoral;
            buttonNext_GSO.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonNext_GSO.Location = new Point(277, 252);
            buttonNext_GSO.Name = "buttonNext_GSO";
            buttonNext_GSO.Size = new Size(160, 62);
            buttonNext_GSO.TabIndex = 3;
            buttonNext_GSO.Text = "Далее";
            buttonNext_GSO.UseVisualStyleBackColor = false;
            buttonNext_GSO.Click += buttonNext_GSO_Click;
            // 
            // pictureBoxKitty_GSO
            // 
            pictureBoxKitty_GSO.Image = (Image)resources.GetObject("pictureBoxKitty_GSO.Image");
            pictureBoxKitty_GSO.Location = new Point(717, 252);
            pictureBoxKitty_GSO.Name = "pictureBoxKitty_GSO";
            pictureBoxKitty_GSO.Size = new Size(142, 157);
            pictureBoxKitty_GSO.TabIndex = 4;
            pictureBoxKitty_GSO.TabStop = false;
            // 
            // FormWelcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(904, 440);
            Controls.Add(pictureBoxKitty_GSO);
            Controls.Add(buttonNext_GSO);
            Controls.Add(buttonInfo_GSO);
            Controls.Add(labelPress_GSO);
            Controls.Add(labelWelcome_GSO);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(922, 487);
            MinimumSize = new Size(922, 487);
            Name = "FormWelcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добро Пожаловать";
            ((System.ComponentModel.ISupportInitialize)pictureBoxKitty_GSO).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWelcome_GSO;
        private Label labelPress_GSO;
        private Button buttonInfo_GSO;
        private Button buttonNext_GSO;
        private PictureBox pictureBoxKitty_GSO;
    }
}