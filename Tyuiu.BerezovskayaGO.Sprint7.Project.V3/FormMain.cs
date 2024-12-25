using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.BerezovskayaGO.Sprint7.Project.V3.Lib;

namespace Tyuiu.BerezovskayaGO.Sprint7.Project.V3
{
    public partial class FormMain_BGO : Form
    {
        private DataService dataService;
        private string[,] dataMatrix;

        public FormMain_BGO()
        {
            InitializeComponent();
            dataService = new DataService();
            string filePath = @"C:\Users\Admin\source\repos\Tyuiu.BerezovskayaGO.Sprint7\Tyuiu.BerezovskayaGO.Sprint7.Project.V3\bin\Debug\net8.0-windows\DataSprint7\Inform.csv";
            try
            {
                if (File.Exists(filePath))
                {
                    dataMatrix = dataService.LoadFromDataFile(filePath);
                    MessageBox.Show("Файл загружен успешно.");
                }
                else
                {
                    MessageBox.Show("Файл не найден.");
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Ошибка доступа к файлу: {ex.Message}");
            }
        }

        private void buttonMain_BGO_Click(object sender, EventArgs e)
        {
            FormAbout_BGO formAbout_BGO = new FormAbout_BGO();
            formAbout_BGO.ShowDialog();
        }

        private void buttonSearch_BGO_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxInput_BGO.Text;

            if (dataMatrix != null)
            {
                string result = dataService.GetStatisticsBySurname(dataMatrix, searchTerm);
                listBoxResult_BGO.Items.Clear();
                listBoxResult_BGO.Items.Add(result);

                // Create chart for the searched teacher
                CreateChart(searchTerm, result);
            }
            else
            {
                listBoxResult_BGO.Items.Clear();
                listBoxResult_BGO.Items.Add("Файл не загружен.");
            }
        }

        private void CreateChart(string surname, string statistics)
        {
            // Parse statistics
            string[] stats = statistics.Split(',');
            if (stats.Length >= 3)
            {
                string experience = stats[1].Trim();
                string teachingStats = stats[2].Trim();

                // Clear previous data
                chartStatistics.Series.Clear();
                chartStatistics.ChartAreas.Clear();

                // Add new chart area
                ChartArea area = new ChartArea();
                chartStatistics.ChartAreas.Add(area);

                // Add new series
                Series series = new Series
                {
                    Name = "Statistics",
                    ChartType = SeriesChartType.Bar,
                    IsValueShownAsLabel = true
                };

                // Add data points
                series.Points.AddXY("Стаж", int.Parse(experience));
                series.Points.AddXY("Статистика", teachingStats.Contains("высшей") ? 1 : 0);

                // Add series to chart
                chartStatistics.Series.Add(series);
            }
        }

        private void listBoxResult_BGO_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Обработчик события, если необходимо
        }
    }
}