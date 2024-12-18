namespace Tyuiu.GubanovaSO.Sprint6.Task7.Project.V12
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelButtonsInPut_VAA = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            labelAllName_GSO = new Label();
            pictureBox1 = new PictureBox();
            buttonShowShopInfo_GSO = new Button();
            buttonShowModels_GSO = new Button();
            groupBoxInfo_GSO = new GroupBox();
            radioButtonProcessorFrequency_GSO = new RadioButton();
            radioButtonRAM_GSO = new RadioButton();
            radioButtonProcessor_GSO = new RadioButton();
            radioButtonScreenSize_GSO = new RadioButton();
            radioButtonSSD_GSO = new RadioButton();
            labelModel_GSO = new Label();
            textBoxModel_GSO = new TextBox();
            radioButtonDiagonal_GSO = new RadioButton();
            labelName_GSO = new Label();
            textBoxName_GSO = new TextBox();
            buttonDone_GSO = new Button();
            buttonInfo_GSO = new Button();
            panelRes_GSO = new Panel();
            labelShopInfo_GSO = new Label();
            labelShowModels_GSO = new Label();
            labelRes_GSO = new Label();
            textBoxShowModels_GSO = new TextBox();
            textBoxRes_GSO = new TextBox();
            textBoxShopInfo_GSO = new TextBox();
            toolTip_GSO = new ToolTip(components);
            panelButtonsInPut_VAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxInfo_GSO.SuspendLayout();
            panelRes_GSO.SuspendLayout();
            SuspendLayout();
            // 
            // panelButtonsInPut_VAA
            // 
            panelButtonsInPut_VAA.BackColor = Color.FromArgb(255, 192, 192);
            panelButtonsInPut_VAA.Controls.Add(textBox2);
            panelButtonsInPut_VAA.Controls.Add(textBox1);
            panelButtonsInPut_VAA.Controls.Add(labelAllName_GSO);
            panelButtonsInPut_VAA.Controls.Add(pictureBox1);
            panelButtonsInPut_VAA.Controls.Add(buttonShowShopInfo_GSO);
            panelButtonsInPut_VAA.Controls.Add(buttonShowModels_GSO);
            panelButtonsInPut_VAA.Controls.Add(groupBoxInfo_GSO);
            panelButtonsInPut_VAA.Controls.Add(buttonDone_GSO);
            panelButtonsInPut_VAA.Controls.Add(buttonInfo_GSO);
            panelButtonsInPut_VAA.Dock = DockStyle.Top;
            panelButtonsInPut_VAA.Location = new Point(0, 0);
            panelButtonsInPut_VAA.Margin = new Padding(3, 4, 3, 4);
            panelButtonsInPut_VAA.Name = "panelButtonsInPut_VAA";
            panelButtonsInPut_VAA.Size = new Size(1069, 268);
            panelButtonsInPut_VAA.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.MistyRose;
            textBox2.Location = new Point(985, 74);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(81, 134);
            textBox2.TabIndex = 8;
            textBox2.Text = "LG\r\nMicrosoft\r\nSamsung\r\nSony\r\nToshiba\r\nXiaomi";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.MistyRose;
            textBox1.Location = new Point(912, 74);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(72, 134);
            textBox1.TabIndex = 7;
            textBox1.Text = "Acer\r\nAsus\r\nDell\r\nHP\r\nHUAWEI\r\nLenovo";
            // 
            // labelAllName_GSO
            // 
            labelAllName_GSO.AutoSize = true;
            labelAllName_GSO.Location = new Point(912, 31);
            labelAllName_GSO.Name = "labelAllName_GSO";
            labelAllName_GSO.Size = new Size(145, 40);
            labelAllName_GSO.TabIndex = 6;
            labelAllName_GSO.Text = "Бренды доступные \r\nдля поиска";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(774, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // buttonShowShopInfo_GSO
            // 
            buttonShowShopInfo_GSO.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonShowShopInfo_GSO.BackColor = Color.LightCoral;
            buttonShowShopInfo_GSO.BackgroundImage = (Image)resources.GetObject("buttonShowShopInfo_GSO.BackgroundImage");
            buttonShowShopInfo_GSO.BackgroundImageLayout = ImageLayout.Center;
            buttonShowShopInfo_GSO.ForeColor = SystemColors.ControlText;
            buttonShowShopInfo_GSO.Location = new Point(698, 198);
            buttonShowShopInfo_GSO.Margin = new Padding(3, 4, 3, 4);
            buttonShowShopInfo_GSO.Name = "buttonShowShopInfo_GSO";
            buttonShowShopInfo_GSO.Size = new Size(100, 62);
            buttonShowShopInfo_GSO.TabIndex = 4;
            toolTip_GSO.SetToolTip(buttonShowShopInfo_GSO, "Выводит информацию о фирме-реализаторе.");
            buttonShowShopInfo_GSO.UseVisualStyleBackColor = false;
            buttonShowShopInfo_GSO.Click += buttonShowShopInfo_GSO_Click;
            // 
            // buttonShowModels_GSO
            // 
            buttonShowModels_GSO.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonShowModels_GSO.BackColor = Color.LightCoral;
            buttonShowModels_GSO.BackgroundImage = Properties.Resources.accept;
            buttonShowModels_GSO.BackgroundImageLayout = ImageLayout.Center;
            buttonShowModels_GSO.ForeColor = SystemColors.ControlText;
            buttonShowModels_GSO.Location = new Point(698, 54);
            buttonShowModels_GSO.Margin = new Padding(3, 4, 3, 4);
            buttonShowModels_GSO.Name = "buttonShowModels_GSO";
            buttonShowModels_GSO.Size = new Size(59, 52);
            buttonShowModels_GSO.TabIndex = 3;
            toolTip_GSO.SetToolTip(buttonShowModels_GSO, "Выводит модели ноутбуков, которые есть в базе данных.");
            buttonShowModels_GSO.UseVisualStyleBackColor = false;
            buttonShowModels_GSO.Click += buttonShowModels_GSO_Click;
            // 
            // groupBoxInfo_GSO
            // 
            groupBoxInfo_GSO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxInfo_GSO.Controls.Add(radioButtonProcessorFrequency_GSO);
            groupBoxInfo_GSO.Controls.Add(radioButtonRAM_GSO);
            groupBoxInfo_GSO.Controls.Add(radioButtonProcessor_GSO);
            groupBoxInfo_GSO.Controls.Add(radioButtonScreenSize_GSO);
            groupBoxInfo_GSO.Controls.Add(radioButtonSSD_GSO);
            groupBoxInfo_GSO.Controls.Add(labelModel_GSO);
            groupBoxInfo_GSO.Controls.Add(textBoxModel_GSO);
            groupBoxInfo_GSO.Controls.Add(radioButtonDiagonal_GSO);
            groupBoxInfo_GSO.Controls.Add(labelName_GSO);
            groupBoxInfo_GSO.Controls.Add(textBoxName_GSO);
            groupBoxInfo_GSO.ForeColor = SystemColors.ControlText;
            groupBoxInfo_GSO.Location = new Point(13, 16);
            groupBoxInfo_GSO.Margin = new Padding(3, 4, 3, 4);
            groupBoxInfo_GSO.Name = "groupBoxInfo_GSO";
            groupBoxInfo_GSO.Padding = new Padding(3, 4, 3, 4);
            groupBoxInfo_GSO.Size = new Size(679, 244);
            groupBoxInfo_GSO.TabIndex = 2;
            groupBoxInfo_GSO.TabStop = false;
            groupBoxInfo_GSO.Text = "Ввод данных:";
            // 
            // radioButtonProcessorFrequency_GSO
            // 
            radioButtonProcessorFrequency_GSO.AutoSize = true;
            radioButtonProcessorFrequency_GSO.Location = new Point(474, 201);
            radioButtonProcessorFrequency_GSO.Margin = new Padding(3, 4, 3, 4);
            radioButtonProcessorFrequency_GSO.Name = "radioButtonProcessorFrequency_GSO";
            radioButtonProcessorFrequency_GSO.Size = new Size(167, 24);
            radioButtonProcessorFrequency_GSO.TabIndex = 9;
            radioButtonProcessorFrequency_GSO.TabStop = true;
            radioButtonProcessorFrequency_GSO.Text = "Процессор, частота";
            radioButtonProcessorFrequency_GSO.UseVisualStyleBackColor = true;
            // 
            // radioButtonRAM_GSO
            // 
            radioButtonRAM_GSO.AutoSize = true;
            radioButtonRAM_GSO.Location = new Point(474, 168);
            radioButtonRAM_GSO.Margin = new Padding(3, 4, 3, 4);
            radioButtonRAM_GSO.Name = "radioButtonRAM_GSO";
            radioButtonRAM_GSO.Size = new Size(177, 24);
            radioButtonRAM_GSO.TabIndex = 8;
            radioButtonRAM_GSO.TabStop = true;
            radioButtonRAM_GSO.Text = "Оперативная память";
            radioButtonRAM_GSO.UseVisualStyleBackColor = true;
            // 
            // radioButtonProcessor_GSO
            // 
            radioButtonProcessor_GSO.AutoSize = true;
            radioButtonProcessor_GSO.Location = new Point(240, 201);
            radioButtonProcessor_GSO.Margin = new Padding(3, 4, 3, 4);
            radioButtonProcessor_GSO.Name = "radioButtonProcessor_GSO";
            radioButtonProcessor_GSO.Size = new Size(108, 24);
            radioButtonProcessor_GSO.TabIndex = 7;
            radioButtonProcessor_GSO.TabStop = true;
            radioButtonProcessor_GSO.Text = "Процессор";
            radioButtonProcessor_GSO.UseVisualStyleBackColor = true;
            // 
            // radioButtonScreenSize_GSO
            // 
            radioButtonScreenSize_GSO.AutoSize = true;
            radioButtonScreenSize_GSO.Location = new Point(240, 168);
            radioButtonScreenSize_GSO.Margin = new Padding(3, 4, 3, 4);
            radioButtonScreenSize_GSO.Name = "radioButtonScreenSize_GSO";
            radioButtonScreenSize_GSO.Size = new Size(168, 24);
            radioButtonScreenSize_GSO.TabIndex = 6;
            radioButtonScreenSize_GSO.TabStop = true;
            radioButtonScreenSize_GSO.Text = "Разрешение экрана";
            radioButtonScreenSize_GSO.UseVisualStyleBackColor = true;
            // 
            // radioButtonSSD_GSO
            // 
            radioButtonSSD_GSO.AutoSize = true;
            radioButtonSSD_GSO.Location = new Point(6, 201);
            radioButtonSSD_GSO.Margin = new Padding(3, 4, 3, 4);
            radioButtonSSD_GSO.Name = "radioButtonSSD_GSO";
            radioButtonSSD_GSO.Size = new Size(109, 24);
            radioButtonSSD_GSO.TabIndex = 5;
            radioButtonSSD_GSO.TabStop = true;
            radioButtonSSD_GSO.Text = "Объем SSD";
            radioButtonSSD_GSO.UseVisualStyleBackColor = true;
            radioButtonSSD_GSO.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // labelModel_GSO
            // 
            labelModel_GSO.AutoSize = true;
            labelModel_GSO.Location = new Point(7, 95);
            labelModel_GSO.Name = "labelModel_GSO";
            labelModel_GSO.Size = new Size(192, 20);
            labelModel_GSO.TabIndex = 4;
            labelModel_GSO.Text = "Введите название модели";
            // 
            // textBoxModel_GSO
            // 
            textBoxModel_GSO.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxModel_GSO.BackColor = Color.MistyRose;
            textBoxModel_GSO.Enabled = false;
            textBoxModel_GSO.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxModel_GSO.Location = new Point(6, 120);
            textBoxModel_GSO.Margin = new Padding(3, 4, 3, 4);
            textBoxModel_GSO.Name = "textBoxModel_GSO";
            textBoxModel_GSO.Size = new Size(665, 27);
            textBoxModel_GSO.TabIndex = 3;
            // 
            // radioButtonDiagonal_GSO
            // 
            radioButtonDiagonal_GSO.AutoSize = true;
            radioButtonDiagonal_GSO.Location = new Point(6, 168);
            radioButtonDiagonal_GSO.Margin = new Padding(3, 4, 3, 4);
            radioButtonDiagonal_GSO.Name = "radioButtonDiagonal_GSO";
            radioButtonDiagonal_GSO.Size = new Size(228, 24);
            radioButtonDiagonal_GSO.TabIndex = 2;
            radioButtonDiagonal_GSO.TabStop = true;
            radioButtonDiagonal_GSO.Text = "Диагональ экрана в дюймах";
            radioButtonDiagonal_GSO.UseVisualStyleBackColor = true;
            // 
            // labelName_GSO
            // 
            labelName_GSO.AutoSize = true;
            labelName_GSO.Location = new Point(7, 24);
            labelName_GSO.Name = "labelName_GSO";
            labelName_GSO.Size = new Size(190, 20);
            labelName_GSO.TabIndex = 1;
            labelName_GSO.Text = "Введите название бренда";
            // 
            // textBoxName_GSO
            // 
            textBoxName_GSO.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxName_GSO.BackColor = Color.MistyRose;
            textBoxName_GSO.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxName_GSO.Location = new Point(6, 52);
            textBoxName_GSO.Margin = new Padding(3, 4, 3, 4);
            textBoxName_GSO.Name = "textBoxName_GSO";
            textBoxName_GSO.Size = new Size(666, 27);
            textBoxName_GSO.TabIndex = 0;
            // 
            // buttonDone_GSO
            // 
            buttonDone_GSO.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDone_GSO.BackColor = Color.LightCoral;
            buttonDone_GSO.BackgroundImage = Properties.Resources.accept;
            buttonDone_GSO.BackgroundImageLayout = ImageLayout.Center;
            buttonDone_GSO.Enabled = false;
            buttonDone_GSO.Location = new Point(698, 122);
            buttonDone_GSO.Margin = new Padding(3, 4, 3, 4);
            buttonDone_GSO.Name = "buttonDone_GSO";
            buttonDone_GSO.Size = new Size(59, 52);
            buttonDone_GSO.TabIndex = 1;
            buttonDone_GSO.UseVisualStyleBackColor = false;
            buttonDone_GSO.Click += buttonDone_GSO_Click;
            // 
            // buttonInfo_GSO
            // 
            buttonInfo_GSO.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonInfo_GSO.BackColor = Color.LightCoral;
            buttonInfo_GSO.BackgroundImage = Properties.Resources.cog;
            buttonInfo_GSO.BackgroundImageLayout = ImageLayout.Center;
            buttonInfo_GSO.Location = new Point(804, 198);
            buttonInfo_GSO.Margin = new Padding(3, 4, 3, 4);
            buttonInfo_GSO.Name = "buttonInfo_GSO";
            buttonInfo_GSO.Size = new Size(100, 62);
            buttonInfo_GSO.TabIndex = 0;
            toolTip_GSO.SetToolTip(buttonInfo_GSO, "Информация о разработчике.");
            buttonInfo_GSO.UseVisualStyleBackColor = false;
            buttonInfo_GSO.Click += buttonInfo_GSO_Click;
            // 
            // panelRes_GSO
            // 
            panelRes_GSO.BackColor = Color.FromArgb(255, 192, 192);
            panelRes_GSO.Controls.Add(labelShopInfo_GSO);
            panelRes_GSO.Controls.Add(labelShowModels_GSO);
            panelRes_GSO.Controls.Add(labelRes_GSO);
            panelRes_GSO.Controls.Add(textBoxShowModels_GSO);
            panelRes_GSO.Controls.Add(textBoxRes_GSO);
            panelRes_GSO.Controls.Add(textBoxShopInfo_GSO);
            panelRes_GSO.Dock = DockStyle.Fill;
            panelRes_GSO.Location = new Point(0, 268);
            panelRes_GSO.Margin = new Padding(3, 4, 3, 4);
            panelRes_GSO.Name = "panelRes_GSO";
            panelRes_GSO.Size = new Size(1069, 382);
            panelRes_GSO.TabIndex = 2;
            // 
            // labelShopInfo_GSO
            // 
            labelShopInfo_GSO.AutoSize = true;
            labelShopInfo_GSO.Location = new Point(487, 71);
            labelShopInfo_GSO.Name = "labelShopInfo_GSO";
            labelShopInfo_GSO.Size = new Size(200, 20);
            labelShopInfo_GSO.TabIndex = 6;
            labelShopInfo_GSO.Text = "Сведения о производителе";
            // 
            // labelShowModels_GSO
            // 
            labelShowModels_GSO.AutoSize = true;
            labelShowModels_GSO.Location = new Point(13, 71);
            labelShowModels_GSO.Name = "labelShowModels_GSO";
            labelShowModels_GSO.Size = new Size(64, 20);
            labelShowModels_GSO.TabIndex = 5;
            labelShowModels_GSO.Text = "Модели";
            // 
            // labelRes_GSO
            // 
            labelRes_GSO.AutoSize = true;
            labelRes_GSO.Location = new Point(13, 9);
            labelRes_GSO.Name = "labelRes_GSO";
            labelRes_GSO.Size = new Size(128, 20);
            labelRes_GSO.TabIndex = 4;
            labelRes_GSO.Text = "Результат поиска";
            labelRes_GSO.Click += labelRes_GSO_Click;
            // 
            // textBoxShowModels_GSO
            // 
            textBoxShowModels_GSO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxShowModels_GSO.BackColor = Color.MistyRose;
            textBoxShowModels_GSO.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxShowModels_GSO.Location = new Point(13, 96);
            textBoxShowModels_GSO.Margin = new Padding(3, 4, 3, 4);
            textBoxShowModels_GSO.Multiline = true;
            textBoxShowModels_GSO.Name = "textBoxShowModels_GSO";
            textBoxShowModels_GSO.ReadOnly = true;
            textBoxShowModels_GSO.ScrollBars = ScrollBars.Vertical;
            textBoxShowModels_GSO.Size = new Size(468, 270);
            textBoxShowModels_GSO.TabIndex = 3;
            // 
            // textBoxRes_GSO
            // 
            textBoxRes_GSO.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxRes_GSO.BackColor = Color.MistyRose;
            textBoxRes_GSO.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxRes_GSO.Location = new Point(13, 35);
            textBoxRes_GSO.Margin = new Padding(3, 4, 3, 4);
            textBoxRes_GSO.Name = "textBoxRes_GSO";
            textBoxRes_GSO.ReadOnly = true;
            textBoxRes_GSO.Size = new Size(1044, 27);
            textBoxRes_GSO.TabIndex = 2;
            // 
            // textBoxShopInfo_GSO
            // 
            textBoxShopInfo_GSO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxShopInfo_GSO.BackColor = Color.MistyRose;
            textBoxShopInfo_GSO.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxShopInfo_GSO.Location = new Point(487, 96);
            textBoxShopInfo_GSO.Margin = new Padding(3, 4, 3, 4);
            textBoxShopInfo_GSO.Multiline = true;
            textBoxShopInfo_GSO.Name = "textBoxShopInfo_GSO";
            textBoxShopInfo_GSO.ReadOnly = true;
            textBoxShopInfo_GSO.Size = new Size(570, 270);
            textBoxShopInfo_GSO.TabIndex = 1;
            textBoxShopInfo_GSO.TextChanged += textBoxShopInfo_GSO_TextChanged;
            // 
            // toolTip_GSO
            // 
            toolTip_GSO.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 650);
            Controls.Add(panelRes_GSO);
            Controls.Add(panelButtonsInPut_VAA);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(1087, 697);
            MinimumSize = new Size(1087, 697);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главная";
            Load += FormMain_Load;
            panelButtonsInPut_VAA.ResumeLayout(false);
            panelButtonsInPut_VAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxInfo_GSO.ResumeLayout(false);
            groupBoxInfo_GSO.PerformLayout();
            panelRes_GSO.ResumeLayout(false);
            panelRes_GSO.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelButtonsInPut_VAA;
        private System.Windows.Forms.GroupBox groupBoxInfo_GSO;
        private System.Windows.Forms.RadioButton radioButtonDiagonal_GSO;
        private System.Windows.Forms.Label labelName_GSO;
        private System.Windows.Forms.TextBox textBoxName_GSO;
        private System.Windows.Forms.Button buttonDone_GSO;
        private System.Windows.Forms.Button buttonInfo_GSO;
        private System.Windows.Forms.Panel panelRes_GSO;
        private System.Windows.Forms.Label labelModel_GSO;
        private System.Windows.Forms.TextBox textBoxModel_GSO;
        private System.Windows.Forms.Button buttonShowModels_GSO;
        private System.Windows.Forms.RadioButton radioButtonProcessorFrequency_GSO;
        private System.Windows.Forms.RadioButton radioButtonRAM_GSO;
        private System.Windows.Forms.RadioButton radioButtonProcessor_GSO;
        private System.Windows.Forms.RadioButton radioButtonScreenSize_GSO;
        private System.Windows.Forms.RadioButton radioButtonSSD_GSO;
        private System.Windows.Forms.TextBox textBoxShowModels_GSO;
        private System.Windows.Forms.TextBox textBoxRes_GSO;
        private System.Windows.Forms.TextBox textBoxShopInfo_GSO;
        private System.Windows.Forms.Button buttonShowShopInfo_GSO;
        private System.Windows.Forms.Label labelShopInfo_GSO;
        private System.Windows.Forms.Label labelShowModels_GSO;
        private System.Windows.Forms.Label labelRes_GSO;
        private System.Windows.Forms.ToolTip toolTip_GSO;
        private PictureBox pictureBox1;
        private Label labelAllName_GSO;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}