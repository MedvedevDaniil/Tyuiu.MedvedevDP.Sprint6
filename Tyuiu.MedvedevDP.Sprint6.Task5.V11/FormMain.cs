using Tyuiu.MedvedevDP.Sprint6.Task5.V11.Lib;
namespace Tyuiu.MedvedevDP.Sprint6.Task5.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\DataSprint6\InPutFileTask5V11.txt";

        private void buttonDone_ZAA_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewData_ZAA.ColumnCount = 2;
                dataGridViewData_ZAA.Columns[0].Width = 20;
                dataGridViewData_ZAA.Columns[1].Width = 90;

                this.chartDiagram_ZAA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartDiagram_ZAA.ChartAreas[0].AxisY.Title = "Ось Y";

                chartDiagram_ZAA.Series[0].Points.Clear();

                double[] numsMass = new double[ds.len];

                numsMass = ds.LoadFromDataFile(path);
                this.dataGridViewData_ZAA.Rows.Clear();
                for (int i = 0; i < numsMass.Length; i++)
                {
                    this.chartDiagram_ZAA.Series[0].Points.AddXY(i, numsMass[i]);
                    dataGridViewData_ZAA.Rows.Add(i.ToString(), numsMass[i].ToString());
                    dataGridViewData_ZAA.Columns[i].Width = 40;
                    dataGridViewData_ZAA.Rows[i].Height = 40;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOpenFile_ZAA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = @"C:\DataSprint6\InPutFileTask5V11.txt";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_ZAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент Медведев Даниил Петрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}