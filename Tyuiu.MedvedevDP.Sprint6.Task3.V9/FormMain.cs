using Tyuiu.MedvedevDP.Sprint6.Task3.V9.Lib;
namespace Tyuiu.MedvedevDP.Sprint6.Task3.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = { { -14,  25,  26 , 18 , 17 },
                        {28,  10 ,  6  ,-2,   4},
                        { 30,  25 , -3 , 11 ,-10 },
                        { 11 , 32 , -5 ,-20,  25 },
                        { 2, -18,  11 ,  8, -20} };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;
            dataGridViewData_TAV.ColumnCount = columns;
            dataGridViewData_TAV.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewData_TAV.Columns[i].Width = 35;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewData_TAV.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonData_TAV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("asd", "asd", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(mtrx);

            int rows = res.GetUpperBound(0) + 1;
            int columns = res.Length / rows;

            dataGridViewDone.ColumnCount = columns;
            dataGridViewDone.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewDone.Columns[i].Width = 35;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewDone.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }

        private void dataGridViewDone_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}