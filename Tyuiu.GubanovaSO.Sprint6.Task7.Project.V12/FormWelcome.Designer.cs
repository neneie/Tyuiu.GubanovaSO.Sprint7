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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWelcome));
            labelWelcome_GSO = new Label();
            labelPress_GSO = new Label();
            buttonInfo_GSO = new Button();
            buttonNext_GSO = new Button();
            pictureBoxKitty_GSO = new PictureBox();
            toolTip_GSO = new ToolTip(components);
            labelWhat_GSO = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxKitty_GSO).BeginInit();
            SuspendLayout();
            // 
            // labelWelcome_GSO
            // 
            resources.ApplyResources(labelWelcome_GSO, "labelWelcome_GSO");
            labelWelcome_GSO.Name = "labelWelcome_GSO";
            // 
            // labelPress_GSO
            // 
            resources.ApplyResources(labelPress_GSO, "labelPress_GSO");
            labelPress_GSO.Name = "labelPress_GSO";
            // 
            // buttonInfo_GSO
            // 
            resources.ApplyResources(buttonInfo_GSO, "buttonInfo_GSO");
            buttonInfo_GSO.BackColor = Color.LightCoral;
            buttonInfo_GSO.Name = "buttonInfo_GSO";
            toolTip_GSO.SetToolTip(buttonInfo_GSO, resources.GetString("buttonInfo_GSO.ToolTip"));
            buttonInfo_GSO.UseVisualStyleBackColor = false;
            buttonInfo_GSO.Click += buttonInfo_GSO_Click;
            // 
            // buttonNext_GSO
            // 
            resources.ApplyResources(buttonNext_GSO, "buttonNext_GSO");
            buttonNext_GSO.BackColor = Color.LightCoral;
            buttonNext_GSO.Name = "buttonNext_GSO";
            buttonNext_GSO.UseVisualStyleBackColor = false;
            buttonNext_GSO.Click += buttonNext_GSO_Click;
            // 
            // pictureBoxKitty_GSO
            // 
            resources.ApplyResources(pictureBoxKitty_GSO, "pictureBoxKitty_GSO");
            pictureBoxKitty_GSO.Name = "pictureBoxKitty_GSO";
            pictureBoxKitty_GSO.TabStop = false;
            // 
            // toolTip_GSO
            // 
            toolTip_GSO.ToolTipTitle = "Подсказка";
            // 
            // labelWhat_GSO
            // 
            resources.ApplyResources(labelWhat_GSO, "labelWhat_GSO");
            labelWhat_GSO.Name = "labelWhat_GSO";
            // 
            // FormWelcome
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            Controls.Add(labelWhat_GSO);
            Controls.Add(buttonNext_GSO);
            Controls.Add(buttonInfo_GSO);
            Controls.Add(labelPress_GSO);
            Controls.Add(labelWelcome_GSO);
            Controls.Add(pictureBoxKitty_GSO);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormWelcome";
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
        private ToolTip toolTip_GSO;
        private Label labelWhat_GSO;
    }
}