using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.GubanovaSO.Sprint7.Project.V12.Lib;
namespace Tyuiu.GubanovaSO.Sprint6.Task7.Project.V12
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonShowShopInfo_GSO_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\DataSprint7\ShopsInPutFile.csv";
                textBoxShopInfo_GSO.Text = ds.CollectTextFromFile(path, Convert.ToString(comboBoxName_GSO.Text), 1) + Environment.NewLine + ds.CollectTextFromFile(path, Convert.ToString(comboBoxName_GSO.Text), 2) + Environment.NewLine + ds.CollectTextFromFile(path, Convert.ToString(comboBoxName_GSO.Text), 3) + Environment.NewLine + ds.CollectTextFromFile(path, Convert.ToString(comboBoxName_GSO.Text), 4);
            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonShowModels_GSO_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(comboBoxName_GSO.Text);
            try
            {
                string path = $@"C:\DataSprint7\{name}InPutFile.csv";
                string fileData = File.ReadAllText(path);
                fileData = fileData.Replace('\n', '\r');
                string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

                int rows = lines.Length;
                int columns = lines[0].Split(';').Length;

                for (int i = 1; i < rows; i++)
                {
                    textBoxShowModels_GSO.Text += ds.CollectTextFromFileInt(path, i, 0) + Environment.NewLine;
                }
                textBoxShowModels_GSO.Text += "--------------------" + Environment.NewLine;
                buttonDone_GSO.Enabled = true;
                textBoxModel_GSO.Enabled = true;
            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonDone_GSO_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(comboBoxName_GSO.Text);
            try
            {
                string path = $@"C:\DataSprint7\{name}InPutFile.csv";
                if (radioButtonDiagonal_GSO.Checked)
                {
                    textBoxRes_GSO.Text = ds.CollectTextFromFile(path, Convert.ToString(textBoxModel_GSO.Text), 1);
                }
                if (radioButtonScreenSize_GSO.Checked)
                {
                    textBoxRes_GSO.Text = ds.CollectTextFromFile(path, Convert.ToString(textBoxModel_GSO.Text), 2);
                }
                if (radioButtonRAM_GSO.Checked)
                {
                    textBoxRes_GSO.Text = ds.CollectTextFromFile(path, Convert.ToString(textBoxModel_GSO.Text), 3);
                }
                if (radioButtonSSD_GSO.Checked)
                {
                    textBoxRes_GSO.Text = ds.CollectTextFromFile(path, Convert.ToString(textBoxModel_GSO.Text), 4);
                }
                if (radioButtonProcessor_GSO.Checked)
                {
                    textBoxRes_GSO.Text = ds.CollectTextFromFile(path, Convert.ToString(textBoxModel_GSO.Text), 5);
                }
                if (radioButtonProcessorFrequency_GSO.Checked)
                {
                    textBoxRes_GSO.Text = ds.CollectTextFromFile(path, Convert.ToString(textBoxModel_GSO.Text), 6);
                }
            }
            catch
            {
                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonInfo_GSO_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormWelcome formWelcome = new FormWelcome();
            formWelcome.Show();
        }
        private void graphBox_Click(object sender, EventArgs e)
        {
            //
        }

        private void оѕрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void перейти ѕапкеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\DataSprint7";

            try
            {
                Process.Start("explorer.exe", folderPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ќшибка при открытии проводника: {ex.Message}", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void руководствомодельToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGuideModel formGuideModel = new FormGuideModel();
            formGuideModel.ShowDialog();
        }

        private void добавитьмодельToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\DataSprint7";

            try
            {
                Process.Start("explorer.exe", folderPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ќшибка при открытии проводника: {ex.Message}", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void руководствофирмуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormGuidCompany formGuidCompany = new FormGuidCompany();
            formGuidCompany.ShowDialog();
        }

        private void добавитьфирмуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\DataSprint7";

            try
            {
                Process.Start("explorer.exe", folderPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"ќшибка при открытии проводника: {ex.Message}", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToolStripMenuAbout_GSO_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}