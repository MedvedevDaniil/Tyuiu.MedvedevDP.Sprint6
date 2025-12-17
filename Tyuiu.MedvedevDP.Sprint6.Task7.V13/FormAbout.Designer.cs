namespace Tyuiu.MedvedevDP.Sprint6.Task7.V13
{
    partial class FormAbout_MDP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelForm_MDP = new Label();
            buttonOK = new Button();
            SuspendLayout();
            // 
            // labelForm_MDP
            // 
            labelForm_MDP.Font = new Font("Segoe UI", 11F);
            labelForm_MDP.Location = new Point(225, 12);
            labelForm_MDP.Name = "labelForm_MDP";
            labelForm_MDP.Size = new Size(272, 230);
            labelForm_MDP.TabIndex = 1;
            labelForm_MDP.Text = "Медведев Даниил Петрович\r\n\r\nЭта программа создана кем-то\r\n\r\n2025\r\n";
            // 
            // buttonOK
            // 
            buttonOK.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOK.Location = new Point(388, 207);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(109, 35);
            buttonOK.TabIndex = 2;
            buttonOK.Text = "ОК";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // FormAbout_MDP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 251);
            Controls.Add(buttonOK);
            Controls.Add(labelForm_MDP);
            MaximumSize = new Size(525, 290);
            MinimumSize = new Size(525, 290);
            Name = "FormAbout_MDP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Label labelForm_MDP;
        private Button buttonOK;
    }
}