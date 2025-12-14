namespace Tyuiu.MedvedevDP.Sprint6.Task3.V9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxCondition_TAV = new GroupBox();
            textBox1 = new TextBox();
            dataGridViewData_TAV = new DataGridView();
            groupBoxDataOutPut_TAV = new GroupBox();
            dataGridViewDone = new DataGridView();
            buttonData_TAV = new Button();
            buttonDone = new Button();
            groupBoxCondition_TAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData_TAV).BeginInit();
            groupBoxDataOutPut_TAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDone).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCondition_TAV
            // 
            groupBoxCondition_TAV.Controls.Add(textBox1);
            groupBoxCondition_TAV.Location = new Point(15, 13);
            groupBoxCondition_TAV.Name = "groupBoxCondition_TAV";
            groupBoxCondition_TAV.Size = new Size(244, 187);
            groupBoxCondition_TAV.TabIndex = 0;
            groupBoxCondition_TAV.TabStop = false;
            groupBoxCondition_TAV.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(6, 18);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 153);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // dataGridViewData_TAV
            // 
            dataGridViewData_TAV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData_TAV.ColumnHeadersVisible = false;
            dataGridViewData_TAV.Location = new Point(286, 31);
            dataGridViewData_TAV.Name = "dataGridViewData_TAV";
            dataGridViewData_TAV.ReadOnly = true;
            dataGridViewData_TAV.RowHeadersVisible = false;
            dataGridViewData_TAV.Size = new Size(241, 243);
            dataGridViewData_TAV.TabIndex = 1;
            // 
            // groupBoxDataOutPut_TAV
            // 
            groupBoxDataOutPut_TAV.Controls.Add(dataGridViewDone);
            groupBoxDataOutPut_TAV.Location = new Point(533, 12);
            groupBoxDataOutPut_TAV.Name = "groupBoxDataOutPut_TAV";
            groupBoxDataOutPut_TAV.Size = new Size(259, 268);
            groupBoxDataOutPut_TAV.TabIndex = 2;
            groupBoxDataOutPut_TAV.TabStop = false;
            groupBoxDataOutPut_TAV.Text = "Результат";
            // 
            // dataGridViewDone
            // 
            dataGridViewDone.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDone.ColumnHeadersVisible = false;
            dataGridViewDone.Location = new Point(9, 19);
            dataGridViewDone.Name = "dataGridViewDone";
            dataGridViewDone.ReadOnly = true;
            dataGridViewDone.RowHeadersVisible = false;
            dataGridViewDone.Size = new Size(244, 243);
            dataGridViewDone.TabIndex = 0;
            dataGridViewDone.CellContentClick += dataGridViewDone_CellContentClick;
            // 
            // buttonData_TAV
            // 
            buttonData_TAV.BackColor = SystemColors.ActiveBorder;
            buttonData_TAV.FlatStyle = FlatStyle.Flat;
            buttonData_TAV.Location = new Point(20, 218);
            buttonData_TAV.Name = "buttonData_TAV";
            buttonData_TAV.Size = new Size(56, 49);
            buttonData_TAV.TabIndex = 3;
            buttonData_TAV.Text = "?";
            buttonData_TAV.UseVisualStyleBackColor = false;
            buttonData_TAV.Click += buttonData_TAV_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(100, 218);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(140, 49);
            buttonDone.TabIndex = 4;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 301);
            Controls.Add(buttonDone);
            Controls.Add(buttonData_TAV);
            Controls.Add(groupBoxDataOutPut_TAV);
            Controls.Add(dataGridViewData_TAV);
            Controls.Add(groupBoxCondition_TAV);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 9 | Медведев Д.П.";
            Load += FormMain_Load;
            groupBoxCondition_TAV.ResumeLayout(false);
            groupBoxCondition_TAV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData_TAV).EndInit();
            groupBoxDataOutPut_TAV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDone).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCondition_TAV;
        private TextBox textBox1;
        private DataGridView dataGridViewData_TAV;
        private GroupBox groupBoxDataOutPut_TAV;
        private DataGridView dataGridViewDone;
        private Button buttonData_TAV;
        private Button buttonDone;
    }
}