namespace Tyuiu.MedvedevDP.Sprint6.Task6.V10
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelTitle_Medvedev = new Label();
            textBoxInput_Medvedev = new TextBox();
            textBoxOutput_Medvedev = new TextBox();
            buttonOpenFile_Medvedev = new Button();
            buttonProcess_Medvedev = new Button();
            buttonHelp_Medvedev = new Button();
            SuspendLayout();
            // 
            // labelTitle_Medvedev
            // 
            labelTitle_Medvedev.AutoSize = true;
            labelTitle_Medvedev.Location = new Point(20, 20);
            labelTitle_Medvedev.Name = "labelTitle_Medvedev";
            labelTitle_Medvedev.Size = new Size(524, 15);
            labelTitle_Medvedev.TabIndex = 0;
            labelTitle_Medvedev.Text = "Вариант 10. Слова, содержащие 'w' / 'W', из файла InPutFileTask6V10.txt (через OpenFileDialog)";
            // 
            // textBoxInput_Medvedev
            // 
            textBoxInput_Medvedev.Location = new Point(23, 50);
            textBoxInput_Medvedev.Multiline = true;
            textBoxInput_Medvedev.Name = "textBoxInput_Medvedev";
            textBoxInput_Medvedev.ReadOnly = true;
            textBoxInput_Medvedev.ScrollBars = ScrollBars.Vertical;
            textBoxInput_Medvedev.Size = new Size(420, 100);
            textBoxInput_Medvedev.TabIndex = 1;
            // 
            // textBoxOutput_Medvedev
            // 
            textBoxOutput_Medvedev.Location = new Point(23, 180);
            textBoxOutput_Medvedev.Multiline = true;
            textBoxOutput_Medvedev.Name = "textBoxOutput_Medvedev";
            textBoxOutput_Medvedev.ReadOnly = true;
            textBoxOutput_Medvedev.ScrollBars = ScrollBars.Vertical;
            textBoxOutput_Medvedev.Size = new Size(420, 80);
            textBoxOutput_Medvedev.TabIndex = 2;
            // 
            // buttonOpenFile_Medvedev
            // 
            buttonOpenFile_Medvedev.Location = new Point(460, 50);
            buttonOpenFile_Medvedev.Name = "buttonOpenFile_Medvedev";
            buttonOpenFile_Medvedev.Size = new Size(110, 25);
            buttonOpenFile_Medvedev.TabIndex = 3;
            buttonOpenFile_Medvedev.Text = "Открыть файл";
            buttonOpenFile_Medvedev.UseVisualStyleBackColor = true;
            buttonOpenFile_Medvedev.Click += buttonOpenFile_Medvedev_Click;
            // 
            // buttonProcess_Medvedev
            // 
            buttonProcess_Medvedev.Location = new Point(460, 90);
            buttonProcess_Medvedev.Name = "buttonProcess_Medvedev";
            buttonProcess_Medvedev.Size = new Size(110, 25);
            buttonProcess_Medvedev.TabIndex = 4;
            buttonProcess_Medvedev.Text = "Выполнить";
            buttonProcess_Medvedev.UseVisualStyleBackColor = true;
            buttonProcess_Medvedev.Click += buttonProcess_Medvedev_Click;
            // 
            // buttonHelp_Medvedev
            // 
            buttonHelp_Medvedev.Location = new Point(520, 235);
            buttonHelp_Medvedev.Name = "buttonHelp_Medvedev";
            buttonHelp_Medvedev.Size = new Size(30, 25);
            buttonHelp_Medvedev.TabIndex = 5;
            buttonHelp_Medvedev.Text = "?";
            buttonHelp_Medvedev.UseVisualStyleBackColor = true;
            buttonHelp_Medvedev.Click += buttonHelp_Medvedev_Click;
            // 
            // FormMain
            // 
            ClientSize = new Size(600, 290);
            Controls.Add(buttonHelp_Medvedev);
            Controls.Add(buttonProcess_Medvedev);
            Controls.Add(buttonOpenFile_Medvedev);
            Controls.Add(textBoxOutput_Medvedev);
            Controls.Add(textBoxInput_Medvedev);
            Controls.Add(labelTitle_Medvedev);
            Name = "FormMain";
            Text = "Спринт 6 | Task 6 | Вариант 10 | Медведев Д.П.";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label labelTitle_Medvedev;
        private System.Windows.Forms.TextBox textBoxInput_Medvedev;
        private System.Windows.Forms.TextBox textBoxOutput_Medvedev;
        private System.Windows.Forms.Button buttonOpenFile_Medvedev;
        private System.Windows.Forms.Button buttonProcess_Medvedev;
        private System.Windows.Forms.Button buttonHelp_Medvedev;
    }
}