
using Tyuiu.MedvedevDP.Sprint6.Task0.V16.Lib;

namespace Tyuiu.MedvedevDP.Sprint6.Task0.V16
{
    public partial class FormMain : Form
    {
        private DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            try
            {
                int x = 3;
                double result = ds.Calculate(x);
                textBoxResult.Text = $"Результат x = {x}: {result:F3}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ответ: " + ex.Message);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ТЕСТ",
                "ТЕст", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}