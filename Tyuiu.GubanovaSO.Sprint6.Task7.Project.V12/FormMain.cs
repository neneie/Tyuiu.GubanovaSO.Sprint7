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
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void InitializeChart()
        {
            // Настройка графика
            chartPrice_GSO.Series.Clear();
            chartPrice_GSO.ChartAreas.Clear();
            ChartArea chartArea = new ChartArea("MainArea");
            chartPrice_GSO.ChartAreas.Add(chartArea);
        }


        private void buttonPrice_GSO_Click(object sender, EventArgs e)
        {
            string manufacturer = Convert.ToString(comboBoxName_GSO.Text);
            LoadPriceData(manufacturer);
        }

        private void LoadPriceData(string manufacturer)
        {
            try
            {
                // Путь к файлу CSV с данными о ценах моделей
                string path = $@"C:\DataSprint7\{manufacturer}Price.csv";
                if (!File.Exists(path))
                {
                    MessageBox.Show("Файл с данными о ценах не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Чтение данных из файла
                string[] lines = File.ReadAllLines(path);
                double[] priceValues = new double[lines.Length - 1]; // Первый элемент - заголовок
                string[] modelNames = new string[lines.Length - 1];

                for (int i = 1; i < lines.Length; i++) // Начинаем с 1 для пропуска заголовка
                {
                    var columns = lines[i].Split(';');
                    modelNames[i - 1] = columns[0]; // Название модели
                    priceValues[i - 1] = Convert.ToDouble(columns[1]); // Цена модели
                }

                // Настройка графика
                chartPrice_GSO.Series.Clear();
                Series series = chartPrice_GSO.Series.Add("Цена");
                series.ChartType = SeriesChartType.Column;

                for (int i = 0; i < modelNames.Length; i++)
                {
                    series.Points.AddXY(modelNames[i], priceValues[i]);
                }

                chartPrice_GSO.ChartAreas[0].AxisX.Title = "Модели";
                chartPrice_GSO.ChartAreas[0].AxisY.Title = "Цена ($)";
                chartPrice_GSO.Titles.Clear();
                chartPrice_GSO.Titles.Add("Цены моделей персональных ЭВМ");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

    


