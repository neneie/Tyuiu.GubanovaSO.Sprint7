using System.Diagnostics;
using System.Windows.Forms;
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
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                // ������� ���������� ����� �����������
                comboBoxModel_GSO.Items.Clear();

                for (int i = 1; i < rows; i++)
                {
                    // �������� ������ �� ����� � ��������� � ���������
                    string model = ds.CollectTextFromFileInt(path, i, 0);
                    comboBoxModel_GSO.Items.Add(model); // ��������� ������ � ���������
                    textBoxShowModels_GSO.Text += model + Environment.NewLine;
                }

                textBoxShowModels_GSO.Text += "--------------------" + Environment.NewLine;
                buttonDone_GSO.Enabled = true;
                comboBoxModel_GSO.Enabled = true; // �������� ���������
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonDone_GSO_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(comboBoxName_GSO.Text);
            try
            {
                string path = $@"C:\DataSprint7\{name}InPutFile.csv";

                // �������� ��������� ������ �� ����������
                string selectedModel = Convert.ToString(comboBoxModel_GSO.SelectedItem);

                if (radioButtonDiagonal_GSO.Checked)
                {
                    textBoxRes_GSO.Text = ds.CollectTextFromFile(path, selectedModel, 1);
                }
                else if (radioButtonScreenSize_GSO.Checked)
                {
                    textBoxRes_GSO.Text = ds.CollectTextFromFile(path, selectedModel, 2);
                }
                else if (radioButtonRAM_GSO.Checked)
                {
                    textBoxRes_GSO.Text = ds.CollectTextFromFile(path, selectedModel, 3);
                }
                else if (radioButtonSSD_GSO.Checked)
                {
                    textBoxRes_GSO.Text = ds.CollectTextFromFile(path, selectedModel, 4);
                }
                else if (radioButtonProcessor_GSO.Checked)
                {
                    textBoxRes_GSO.Text = ds.CollectTextFromFile(path, selectedModel, 5);
                }
                else if (radioButtonProcessorFrequency_GSO.Checked)
                {
                    textBoxRes_GSO.Text = ds.CollectTextFromFile(path, selectedModel, 6);
                }
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void �������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\DataSprint7";

            try
            {
                Process.Start("explorer.exe", folderPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��� �������� ����������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void �����������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGuideModel formGuideModel = new FormGuideModel();
            formGuideModel.Show();
        }

        private void ��������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\DataSprint7";

            try
            {
                Process.Start("explorer.exe", folderPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��� �������� ����������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ����������������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormGuidCompany formGuidCompany = new FormGuidCompany();
            formGuidCompany.Show();
        }

        private void �������������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\DataSprint7";

            try
            {
                Process.Start("explorer.exe", folderPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��� �������� ����������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToolStripMenuAbout_GSO_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.Show();
        }

        private void LoadData()
        {
            string name = Convert.ToString(comboBoxName_GSO.Text); // �������� ��� �� comboBox
            string path = $@"C:\DataSprint7\{name}Price.csv"; // ��������� ���� � �����

            try
            {
                if (!File.Exists(path))
                {
                    MessageBox.Show("���� � ������� � ����� �� ������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // ������ ������ �� �����
                var models = new List<ComputerModel>();
                string[] lines = File.ReadAllLines(path);

                for (int i = 1; i < lines.Length; i++) // �������� � 1 ��� �������� ���������
                {
                    var columns = lines[i].Split(';');
                    if (columns.Length >= 2)
                    {
                        string modelName = columns[0]; // �������� ������
                        double price = Convert.ToDouble(columns[1]); // ���� ������
                        models.Add(new ComputerModel { Name = modelName, Price = price });
                    }
                }

                bindingSourcePrice_GSO.DataSource = models; // ������������� �������� ������
                dataGridViewPrice_GSO.DataSource = bindingSourcePrice_GSO; // ��������� � DataGridView
                dataGridViewPrice_GSO.Columns["Name"].Width = 258; // ���������� ������ ������� ��� �������� ������
                dataGridViewPrice_GSO.Columns["Price"].Width = 50; // ���������� ������ ������� ��� ����
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��� �������� ������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void buttonLoadData_GSO_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoadData_GSO_Click_1(object sender, EventArgs e)
        {
            LoadData();
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //
        }
        
    }

    public class ComputerModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }


}
