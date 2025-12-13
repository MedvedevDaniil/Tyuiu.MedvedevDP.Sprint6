namespace Tyuiu.MedvedevDP.Sprint6.Task1.V18
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
            textBoxStart = new TextBox();
            textBoxEnd = new TextBox();
            buttonInfo = new Button();
            buttonResult = new Button();
            labelStart = new Label();
            labelEnd = new Label();
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            groupBoxResult = new GroupBox();
            textBoxResult = new TextBox();
            groupBoxTask.SuspendLayout();
            groupBoxResult.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(56, 353);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(160, 23);
            textBoxStart.TabIndex = 0;
            // 
            // textBoxEnd
            // 
            textBoxEnd.Location = new Point(273, 353);
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.Size = new Size(160, 23);
            textBoxEnd.TabIndex = 1;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(498, 370);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(75, 56);
            buttonInfo.TabIndex = 2;
            buttonInfo.Text = "?";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += button1_Click;
            // 
            // buttonResult
            // 
            buttonResult.BackColor = Color.YellowGreen;
            buttonResult.Location = new Point(580, 356);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(184, 79);
            buttonResult.TabIndex = 3;
            buttonResult.Text = "Выполнить";
            buttonResult.UseVisualStyleBackColor = false;
            buttonResult.Click += buttonResult_Click;
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(82, 335);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(101, 15);
            labelStart.TabIndex = 4;
            labelStart.Text = "Начальная точка";
            labelStart.Click += label1_Click;
            // 
            // labelEnd
            // 
            labelEnd.AutoSize = true;
            labelEnd.Location = new Point(302, 335);
            labelEnd.Name = "labelEnd";
            labelEnd.Size = new Size(94, 15);
            labelEnd.TabIndex = 5;
            labelEnd.Text = "Конечная точка";
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(56, 26);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(377, 283);
            groupBoxTask.TabIndex = 6;
            groupBoxTask.TabStop = false;
            groupBoxTask.Tag = "";
            groupBoxTask.Text = "Условие";
            groupBoxTask.Enter += groupBox1_Enter;
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(6, 22);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(365, 255);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Протабулировать функцию sin(x) на заданном диапазоне.\r\nРезультат вывести в виде таблицы.";
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Location = new Point(481, 26);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(310, 306);
            groupBoxResult.TabIndex = 7;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult.Location = new Point(6, 22);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(298, 278);
            textBoxResult.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 450);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxTask);
            Controls.Add(labelEnd);
            Controls.Add(labelStart);
            Controls.Add(buttonResult);
            Controls.Add(buttonInfo);
            Controls.Add(textBoxEnd);
            Controls.Add(textBoxStart);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxStart;
        private TextBox textBoxEnd;
        private Button buttonInfo;
        private Button buttonResult;
        private Label labelStart;
        private Label labelEnd;
        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private GroupBox groupBoxResult;
        private TextBox textBoxResult;
    }
}
