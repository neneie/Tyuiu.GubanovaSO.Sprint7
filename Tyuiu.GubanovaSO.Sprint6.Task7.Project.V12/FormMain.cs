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
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                // Очистка комбобокса перед заполнением
                comboBoxModel_GSO.Items.Clear();

                for (int i = 1; i < rows; i++)
                {
                    // Получаем модель из файла и добавляем в комбобокс
                    string model = ds.CollectTextFromFileInt(path, i, 0);
                    comboBoxModel_GSO.Items.Add(model); // Добавляем модель в комбобокс
                    textBoxShowModels_GSO.Text += model + Environment.NewLine;
                }

                textBoxShowModels_GSO.Text += "--------------------" + Environment.NewLine;
                buttonDone_GSO.Enabled = true;
                comboBoxModel_GSO.Enabled = true; // Включаем комбобокс
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonDone_GSO_Click(object sender, EventArgs e)
        {
            string name = Convert.ToString(comboBoxName_GSO.Text);
            try
            {
                string path = $@"C:\DataSprint7\{name}InPutFile.csv";

                // Получаем выбранную модель из комбобокса
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
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void перейтиКПапкеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\DataSprint7";

            try
            {
                Process.Start("explorer.exe", folderPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при открытии проводника: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void руководствомодельToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGuideModel formGuideModel = new FormGuideModel();
            formGuideModel.Show();
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
                MessageBox.Show($"Ошибка при открытии проводника: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void руководствофирмуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormGuidCompany formGuidCompany = new FormGuidCompany();
            formGuidCompany.Show();
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
                MessageBox.Show($"Ошибка при открытии проводника: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToolStripMenuAbout_GSO_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.Show();
        }

        private void LoadData()
        {
            string name = Convert.ToString(comboBoxName_GSO.Text); // Получаем имя из comboBox
            string path = $@"C:\DataSprint7\{name}Price.csv"; // Формируем путь к файлу

            try
            {
                if (!File.Exists(path))
                {
                    MessageBox.Show("Файл с данными о ценах не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Чтение данных из файла
                var models = new List<ComputerModel>();
                string[] lines = File.ReadAllLines(path);

                for (int i = 1; i < lines.Length; i++) // Начинаем с 1 для пропуска заголовка
                {
                    var columns = lines[i].Split(';');
                    if (columns.Length >= 2)
                    {
                        string modelName = columns[0]; // Название модели
                        double price = Convert.ToDouble(columns[1]); // Цена модели
                        models.Add(new ComputerModel { Name = modelName, Price = price });
                    }
                }

                bindingSourcePrice_GSO.DataSource = models; // Устанавливаем источник данных
                dataGridViewPrice_GSO.DataSource = bindingSourcePrice_GSO; // Связываем с DataGridView
                dataGridViewPrice_GSO.Columns["Name"].Width = 258; // Установите ширину колонки для названия модели
                dataGridViewPrice_GSO.Columns["Price"].Width = 50; // Установите ширину колонки для цены
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
