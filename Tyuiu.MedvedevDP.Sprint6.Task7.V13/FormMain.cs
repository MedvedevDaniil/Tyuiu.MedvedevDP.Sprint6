using Tyuiu.MedvedevDP.Sprint6.Task7.V13.Lib;
namespace Tyuiu.MedvedevDP.Sprint6.Task7.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        static int rows;
        static int columns;
        static string openFilePath;

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxIn_MDP_Enter(object sender, EventArgs e)
        {

        }
        public static int[,] LoadFromData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            int[,] result = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return result;
        }
        private void buttonOpenFile_MDP_Click(object sender, EventArgs e)
        {
            openFileDialogTask_MDP.ShowDialog();
            openFilePath = openFileDialogTask_MDP.FileName;
            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromData(openFilePath);
            dataGridViewIn_MDP.ColumnCount = columns;
            dataGridViewIn_MDP.RowCount = rows;
            dataGridViewOut_MDP.ColumnCount = columns;
            dataGridViewOut_MDP.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_MDP.Columns[i].Width = 25;
                dataGridViewOut_MDP.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewIn_MDP.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonFile_MDP.Enabled = true;
        }

        private void buttonFile_MDP_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOut_MDP.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            buttonSave_MDP.Enabled = true;
        }

        private void buttonSave_MDP_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_MDP.FileName = "OutPutFileTask7V13.csv";
            saveFileDialogTask_MDP.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask_MDP.ShowDialog();
            string path = saveFileDialogTask_MDP.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExzist = fileInfo.Exists;
            if (fileExzist)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOut_MDP.RowCount;
            int col = dataGridViewOut_MDP.ColumnCount;
            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != col - 1)
                    {
                        str += dataGridViewOut_MDP.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOut_MDP.Rows[i].Cells[j].Value;
                    }
                }
            }
            File.AppendAllText(path, str + Environment.NewLine);
            str = "";
        }

        private void buttonHelp_MDP_Click(object sender, EventArgs e)
        {
            toolTipButtons.ToolTipTitle = "Ñïðàâêà";

            FormAbout_MDP form = new FormAbout_MDP();
            form.ShowDialog();
        }

        private void buttonOpenFile_MDP_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons.ToolTipTitle = "Îòêðûòü ôàéë";
        }

        private void buttonFile_MDP_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons.ToolTipTitle = "Âûïîëíèòü";
        }

        private void buttonSave_MDP_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons.ToolTipTitle = "Ñîõðàíèòü â ôàéë";
        }
    }
}