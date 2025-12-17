namespace Tyuiu.MedvedevDP.Sprint6.Task7.V13
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            groupBoxButtons_MDP = new GroupBox();
            buttonHelp_MDP = new Button();
            buttonSave_MDP = new Button();
            buttonFile_MDP = new Button();
            buttonOpenFile_MDP = new Button();
            groupBoxCon_MDP = new GroupBox();
            labelTask_MDP = new Label();
            groupBoxIn_MDP = new GroupBox();
            dataGridViewIn_MDP = new DataGridView();
            groupBoxOut_MDP = new GroupBox();
            dataGridViewOut_MDP = new DataGridView();
            toolTipButtons = new ToolTip(components);
            openFileDialogTask_MDP = new OpenFileDialog();
            saveFileDialogTask_MDP = new SaveFileDialog();
            groupBoxButtons_MDP.SuspendLayout();
            groupBoxCon_MDP.SuspendLayout();
            groupBoxIn_MDP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_MDP).BeginInit();
            groupBoxOut_MDP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_MDP).BeginInit();
            SuspendLayout();
            // 
            // groupBoxButtons_MDP
            // 
            groupBoxButtons_MDP.Controls.Add(buttonHelp_MDP);
            groupBoxButtons_MDP.Controls.Add(buttonSave_MDP);
            groupBoxButtons_MDP.Controls.Add(buttonFile_MDP);
            groupBoxButtons_MDP.Controls.Add(buttonOpenFile_MDP);
            groupBoxButtons_MDP.Dock = DockStyle.Top;
            groupBoxButtons_MDP.Location = new Point(0, 0);
            groupBoxButtons_MDP.Name = "groupBoxButtons_MDP";
            groupBoxButtons_MDP.Size = new Size(1148, 92);
            groupBoxButtons_MDP.TabIndex = 0;
            groupBoxButtons_MDP.TabStop = false;
            // 
            // buttonHelp_MDP
            // 
            buttonHelp_MDP.Anchor = AnchorStyles.Right;
            buttonHelp_MDP.BackColor = SystemColors.ButtonFace;
            buttonHelp_MDP.Location = new Point(1044, 9);
            buttonHelp_MDP.Name = "buttonHelp_MDP";
            buttonHelp_MDP.Size = new Size(98, 73);
            buttonHelp_MDP.TabIndex = 3;
            buttonHelp_MDP.Text = "О нас";
            toolTipButtons.SetToolTip(buttonHelp_MDP, "Сведения о программе\r\n");
            buttonHelp_MDP.UseVisualStyleBackColor = false;
            buttonHelp_MDP.Click += buttonHelp_MDP_Click;
            // 
            // buttonSave_MDP
            // 
            buttonSave_MDP.BackColor = SystemColors.ButtonFace;
            buttonSave_MDP.Enabled = false;
            buttonSave_MDP.Location = new Point(251, 9);
            buttonSave_MDP.Name = "buttonSave_MDP";
            buttonSave_MDP.Size = new Size(98, 73);
            buttonSave_MDP.TabIndex = 2;
            toolTipButtons.SetToolTip(buttonSave_MDP, "Сохранить обработанные данные в файл");
            buttonSave_MDP.UseVisualStyleBackColor = false;
            buttonSave_MDP.Click += buttonSave_MDP_Click;
            buttonSave_MDP.MouseEnter += buttonSave_MDP_MouseEnter;
            // 
            // buttonFile_MDP
            // 
            buttonFile_MDP.BackColor = SystemColors.ButtonFace;
            buttonFile_MDP.Enabled = false;
            buttonFile_MDP.Location = new Point(131, 9);
            buttonFile_MDP.Name = "buttonFile_MDP";
            buttonFile_MDP.Size = new Size(98, 73);
            buttonFile_MDP.TabIndex = 1;
            toolTipButtons.SetToolTip(buttonFile_MDP, "Выполнить обработку данных");
            buttonFile_MDP.UseVisualStyleBackColor = false;
            buttonFile_MDP.Click += buttonFile_MDP_Click;
            buttonFile_MDP.MouseEnter += buttonFile_MDP_MouseEnter;
            // 
            // buttonOpenFile_MDP
            // 
            buttonOpenFile_MDP.BackColor = SystemColors.ButtonFace;
            buttonOpenFile_MDP.Location = new Point(11, 9);
            buttonOpenFile_MDP.Name = "buttonOpenFile_MDP";
            buttonOpenFile_MDP.Size = new Size(98, 73);
            buttonOpenFile_MDP.TabIndex = 0;
            buttonOpenFile_MDP.Text = "Открыть";
            toolTipButtons.SetToolTip(buttonOpenFile_MDP, "Открыть файл для обработки");
            buttonOpenFile_MDP.UseVisualStyleBackColor = false;
            buttonOpenFile_MDP.Click += buttonOpenFile_MDP_Click;
            buttonOpenFile_MDP.MouseEnter += buttonOpenFile_MDP_MouseEnter;
            // 
            // groupBoxCon_MDP
            // 
            groupBoxCon_MDP.Controls.Add(labelTask_MDP);
            groupBoxCon_MDP.Dock = DockStyle.Top;
            groupBoxCon_MDP.Font = new Font("Segoe UI", 11F);
            groupBoxCon_MDP.Location = new Point(0, 92);
            groupBoxCon_MDP.Name = "groupBoxCon_MDP";
            groupBoxCon_MDP.Size = new Size(1148, 111);
            groupBoxCon_MDP.TabIndex = 1;
            groupBoxCon_MDP.TabStop = false;
            groupBoxCon_MDP.Text = "Условие:";
            // 
            // labelTask_MDP
            // 
            labelTask_MDP.Location = new Point(6, 23);
            labelTask_MDP.Name = "labelTask_MDP";
            labelTask_MDP.Size = new Size(909, 85);
            labelTask_MDP.TabIndex = 0;
            // 
            // groupBoxIn_MDP
            // 
            groupBoxIn_MDP.Controls.Add(dataGridViewIn_MDP);
            groupBoxIn_MDP.Dock = DockStyle.Left;
            groupBoxIn_MDP.Font = new Font("Segoe UI", 11F);
            groupBoxIn_MDP.Location = new Point(0, 203);
            groupBoxIn_MDP.MinimumSize = new Size(604, 370);
            groupBoxIn_MDP.Name = "groupBoxIn_MDP";
            groupBoxIn_MDP.Size = new Size(1148, 370);
            groupBoxIn_MDP.TabIndex = 3;
            groupBoxIn_MDP.TabStop = false;
            groupBoxIn_MDP.Text = "Ввод:";
            groupBoxIn_MDP.Enter += FormMain_Load;
            // 
            // dataGridViewIn_MDP
            // 
            dataGridViewIn_MDP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewIn_MDP.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewIn_MDP.Dock = DockStyle.Fill;
            dataGridViewIn_MDP.Location = new Point(3, 23);
            dataGridViewIn_MDP.Name = "dataGridViewIn_MDP";
            dataGridViewIn_MDP.Size = new Size(1142, 344);
            dataGridViewIn_MDP.TabIndex = 0;
            // 
            // groupBoxOut_MDP
            // 
            groupBoxOut_MDP.Controls.Add(dataGridViewOut_MDP);
            groupBoxOut_MDP.Dock = DockStyle.Right;
            groupBoxOut_MDP.Font = new Font("Segoe UI", 11F);
            groupBoxOut_MDP.Location = new Point(544, 203);
            groupBoxOut_MDP.MinimumSize = new Size(604, 390);
            groupBoxOut_MDP.Name = "groupBoxOut_MDP";
            groupBoxOut_MDP.Size = new Size(604, 390);
            groupBoxOut_MDP.TabIndex = 4;
            groupBoxOut_MDP.TabStop = false;
            groupBoxOut_MDP.Text = "Вывод:";
            // 
            // dataGridViewOut_MDP
            // 
            dataGridViewOut_MDP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewOut_MDP.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewOut_MDP.Dock = DockStyle.Fill;
            dataGridViewOut_MDP.Location = new Point(3, 23);
            dataGridViewOut_MDP.Name = "dataGridViewOut_MDP";
            dataGridViewOut_MDP.Size = new Size(598, 364);
            dataGridViewOut_MDP.TabIndex = 0;
            // 
            // toolTipButtons
            // 
            toolTipButtons.IsBalloon = true;
            toolTipButtons.ToolTipIcon = ToolTipIcon.Info;
            toolTipButtons.ToolTipTitle = "Подсказка";
            // 
            // openFileDialogTask_MDP
            // 
            openFileDialogTask_MDP.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 573);
            Controls.Add(groupBoxOut_MDP);
            Controls.Add(groupBoxIn_MDP);
            Controls.Add(groupBoxCon_MDP);
            Controls.Add(groupBoxButtons_MDP);
            MinimumSize = new Size(1164, 612);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 7 | Таск 7 | Вариант 13 | Медведев Д.П.";
            toolTipButtons.SetToolTip(this, "Сведения о программе");
            Load += FormMain_Load;
            groupBoxButtons_MDP.ResumeLayout(false);
            groupBoxCon_MDP.ResumeLayout(false);
            groupBoxIn_MDP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_MDP).EndInit();
            groupBoxOut_MDP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_MDP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxButtons_MDP;
        private Button buttonFile_MDP;
        private Button buttonOpenFile_MDP;
        private GroupBox groupBoxCon_MDP;
        private Button buttonHelp_MDP;
        private Button buttonSave_MDP;
        private Label labelTask_MDP;
        private GroupBox groupBoxIn_MDP;
        private DataGridView dataGridViewIn_MDP;
        private GroupBox groupBoxOut_MDP;
        private DataGridView dataGridViewOut_MDP;
        private ToolTip toolTipButtons;
        private OpenFileDialog openFileDialogTask_MDP;
        private SaveFileDialog saveFileDialogTask_MDP;
    }
}