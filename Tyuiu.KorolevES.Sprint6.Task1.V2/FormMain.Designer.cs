namespace Tyuiu.KorolevES.Sprint6.Task1.V2
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
            groupBoxTask_KES = new GroupBox();
            pictureBoxFormula_KES = new PictureBox();
            textBoxTask_KES = new TextBox();
            groupBoxEnter_KES = new GroupBox();
            labelVarEnd_KES = new Label();
            labelVarStart_KES = new Label();
            textBoxVarEnd_KES = new TextBox();
            textBoxVarStart_KES = new TextBox();
            groupBoxResult_KES = new GroupBox();
            textBoxResult_KES = new TextBox();
            labelResult_KES = new Label();
            buttonResult_KES = new Button();
            buttonHelp_KES = new Button();
            groupBoxTask_KES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_KES).BeginInit();
            groupBoxEnter_KES.SuspendLayout();
            groupBoxResult_KES.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_KES
            // 
            groupBoxTask_KES.Controls.Add(pictureBoxFormula_KES);
            groupBoxTask_KES.Controls.Add(textBoxTask_KES);
            groupBoxTask_KES.Location = new Point(12, 12);
            groupBoxTask_KES.Name = "groupBoxTask_KES";
            groupBoxTask_KES.Size = new Size(556, 199);
            groupBoxTask_KES.TabIndex = 0;
            groupBoxTask_KES.TabStop = false;
            groupBoxTask_KES.Text = "Условие";
            // 
            // pictureBoxFormula_KES
            // 
            pictureBoxFormula_KES.Image = Properties.Resources.FormulaTask1V2;
            pictureBoxFormula_KES.Location = new Point(279, 31);
            pictureBoxFormula_KES.Name = "pictureBoxFormula_KES";
            pictureBoxFormula_KES.Size = new Size(269, 45);
            pictureBoxFormula_KES.TabIndex = 1;
            pictureBoxFormula_KES.TabStop = false;
            // 
            // textBoxTask_KES
            // 
            textBoxTask_KES.Location = new Point(16, 31);
            textBoxTask_KES.Multiline = true;
            textBoxTask_KES.Name = "textBoxTask_KES";
            textBoxTask_KES.ReadOnly = true;
            textBoxTask_KES.Size = new Size(257, 138);
            textBoxTask_KES.TabIndex = 0;
            textBoxTask_KES.TabStop = false;
            textBoxTask_KES.Text = "Протабулировать функцию f(x) на заданном промежутке [-5,5].\r\nРезультат вывести в виде таблицы.";
            // 
            // groupBoxEnter_KES
            // 
            groupBoxEnter_KES.Controls.Add(labelVarEnd_KES);
            groupBoxEnter_KES.Controls.Add(labelVarStart_KES);
            groupBoxEnter_KES.Controls.Add(textBoxVarEnd_KES);
            groupBoxEnter_KES.Controls.Add(textBoxVarStart_KES);
            groupBoxEnter_KES.Location = new Point(12, 231);
            groupBoxEnter_KES.Name = "groupBoxEnter_KES";
            groupBoxEnter_KES.Size = new Size(273, 100);
            groupBoxEnter_KES.TabIndex = 1;
            groupBoxEnter_KES.TabStop = false;
            groupBoxEnter_KES.Text = "Ввод данных";
            // 
            // labelVarEnd_KES
            // 
            labelVarEnd_KES.AutoSize = true;
            labelVarEnd_KES.Location = new Point(140, 30);
            labelVarEnd_KES.Name = "labelVarEnd_KES";
            labelVarEnd_KES.Size = new Size(75, 15);
            labelVarEnd_KES.TabIndex = 3;
            labelVarEnd_KES.Text = "Конец шага:";
            // 
            // labelVarStart_KES
            // 
            labelVarStart_KES.AutoSize = true;
            labelVarStart_KES.Location = new Point(16, 30);
            labelVarStart_KES.Name = "labelVarStart_KES";
            labelVarStart_KES.Size = new Size(72, 15);
            labelVarStart_KES.TabIndex = 2;
            labelVarStart_KES.Text = "Старт шага:";
            // 
            // textBoxVarEnd_KES
            // 
            textBoxVarEnd_KES.Location = new Point(140, 61);
            textBoxVarEnd_KES.Name = "textBoxVarEnd_KES";
            textBoxVarEnd_KES.Size = new Size(100, 23);
            textBoxVarEnd_KES.TabIndex = 1;
            textBoxVarEnd_KES.Text = "5";
            // 
            // textBoxVarStart_KES
            // 
            textBoxVarStart_KES.Location = new Point(16, 61);
            textBoxVarStart_KES.Name = "textBoxVarStart_KES";
            textBoxVarStart_KES.Size = new Size(100, 23);
            textBoxVarStart_KES.TabIndex = 0;
            textBoxVarStart_KES.Text = "-5";
            // 
            // groupBoxResult_KES
            // 
            groupBoxResult_KES.Controls.Add(textBoxResult_KES);
            groupBoxResult_KES.Controls.Add(labelResult_KES);
            groupBoxResult_KES.Location = new Point(574, 12);
            groupBoxResult_KES.Name = "groupBoxResult_KES";
            groupBoxResult_KES.Size = new Size(232, 323);
            groupBoxResult_KES.TabIndex = 2;
            groupBoxResult_KES.TabStop = false;
            groupBoxResult_KES.Text = "Вывод данных";
            // 
            // textBoxResult_KES
            // 
            textBoxResult_KES.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_KES.Location = new Point(21, 37);
            textBoxResult_KES.Multiline = true;
            textBoxResult_KES.Name = "textBoxResult_KES";
            textBoxResult_KES.ReadOnly = true;
            textBoxResult_KES.ScrollBars = ScrollBars.Vertical;
            textBoxResult_KES.Size = new Size(205, 266);
            textBoxResult_KES.TabIndex = 1;
            textBoxResult_KES.TabStop = false;
            // 
            // labelResult_KES
            // 
            labelResult_KES.AutoSize = true;
            labelResult_KES.Location = new Point(6, 19);
            labelResult_KES.Name = "labelResult_KES";
            labelResult_KES.Size = new Size(63, 15);
            labelResult_KES.TabIndex = 0;
            labelResult_KES.Text = "Результат:";
            // 
            // buttonResult_KES
            // 
            buttonResult_KES.BackColor = Color.Green;
            buttonResult_KES.Location = new Point(418, 276);
            buttonResult_KES.Name = "buttonResult_KES";
            buttonResult_KES.Size = new Size(135, 53);
            buttonResult_KES.TabIndex = 3;
            buttonResult_KES.Text = "Выполнить";
            buttonResult_KES.UseVisualStyleBackColor = false;
            buttonResult_KES.Click += buttonResultClick;
            // 
            // buttonHelp_KES
            // 
            buttonHelp_KES.BackColor = Color.CornflowerBlue;
            buttonHelp_KES.ForeColor = SystemColors.ControlText;
            buttonHelp_KES.Location = new Point(301, 276);
            buttonHelp_KES.Name = "buttonHelp_KES";
            buttonHelp_KES.Size = new Size(102, 53);
            buttonHelp_KES.TabIndex = 4;
            buttonHelp_KES.Text = "Справка";
            buttonHelp_KES.UseVisualStyleBackColor = false;
            buttonHelp_KES.Click += buttonHelpClick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 347);
            Controls.Add(buttonHelp_KES);
            Controls.Add(buttonResult_KES);
            Controls.Add(groupBoxResult_KES);
            Controls.Add(groupBoxEnter_KES);
            Controls.Add(groupBoxTask_KES);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 |Таск 1 |Вариант 2 |Королев Е.С.";
            groupBoxTask_KES.ResumeLayout(false);
            groupBoxTask_KES.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_KES).EndInit();
            groupBoxEnter_KES.ResumeLayout(false);
            groupBoxEnter_KES.PerformLayout();
            groupBoxResult_KES.ResumeLayout(false);
            groupBoxResult_KES.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_KES;
        private TextBox textBoxTask_KES;
        private PictureBox pictureBoxFormula_KES;
        private GroupBox groupBoxEnter_KES;
        private TextBox textBoxVarEnd_KES;
        private TextBox textBoxVarStart_KES;
        private Label labelVarEnd_KES;
        private Label labelVarStart_KES;
        private GroupBox groupBoxResult_KES;
        private Label labelResult_KES;
        private TextBox textBoxResult_KES;
        private Button buttonResult_KES;
        private Button buttonHelp_KES;
    }
}
