namespace Tyuiu.KorolevES.Sprint6.Task0.V7
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
            textBoxTask_KES = new TextBox();
            pictureBoxFormula_KES = new PictureBox();
            groupBoxTask_KES = new GroupBox();
            groupBoxEnter_KES = new GroupBox();
            labelVarX_KES = new Label();
            textBoxVarX_KES = new TextBox();
            groupBoxResult_KES = new GroupBox();
            labelResult_KES = new Label();
            textBoxResult_KES = new TextBox();
            buttonResult_KES = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_KES).BeginInit();
            groupBoxTask_KES.SuspendLayout();
            groupBoxEnter_KES.SuspendLayout();
            groupBoxResult_KES.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxTask_KES
            // 
            textBoxTask_KES.Location = new Point(25, 22);
            textBoxTask_KES.Multiline = true;
            textBoxTask_KES.Name = "textBoxTask_KES";
            textBoxTask_KES.ReadOnly = true;
            textBoxTask_KES.Size = new Size(232, 167);
            textBoxTask_KES.TabIndex = 0;
            textBoxTask_KES.TabStop = false;
            textBoxTask_KES.Text = "Вычислить выражение по формуле\r\n";
            // 
            // pictureBoxFormula_KES
            // 
            pictureBoxFormula_KES.Image = Properties.Resources.FormulaTask0V7;
            pictureBoxFormula_KES.InitialImage = null;
            pictureBoxFormula_KES.Location = new Point(281, 22);
            pictureBoxFormula_KES.Name = "pictureBoxFormula_KES";
            pictureBoxFormula_KES.Size = new Size(129, 70);
            pictureBoxFormula_KES.TabIndex = 1;
            pictureBoxFormula_KES.TabStop = false;
            // 
            // groupBoxTask_KES
            // 
            groupBoxTask_KES.Controls.Add(textBoxTask_KES);
            groupBoxTask_KES.Controls.Add(pictureBoxFormula_KES);
            groupBoxTask_KES.Location = new Point(23, 24);
            groupBoxTask_KES.Name = "groupBoxTask_KES";
            groupBoxTask_KES.Size = new Size(431, 216);
            groupBoxTask_KES.TabIndex = 2;
            groupBoxTask_KES.TabStop = false;
            groupBoxTask_KES.Text = "Условие:";
            // 
            // groupBoxEnter_KES
            // 
            groupBoxEnter_KES.Controls.Add(labelVarX_KES);
            groupBoxEnter_KES.Controls.Add(textBoxVarX_KES);
            groupBoxEnter_KES.Location = new Point(23, 257);
            groupBoxEnter_KES.Name = "groupBoxEnter_KES";
            groupBoxEnter_KES.Size = new Size(200, 131);
            groupBoxEnter_KES.TabIndex = 3;
            groupBoxEnter_KES.TabStop = false;
            groupBoxEnter_KES.Text = "Ввод данные";
            // 
            // labelVarX_KES
            // 
            labelVarX_KES.AutoSize = true;
            labelVarX_KES.Location = new Point(40, 45);
            labelVarX_KES.Name = "labelVarX_KES";
            labelVarX_KES.Size = new Size(89, 15);
            labelVarX_KES.TabIndex = 1;
            labelVarX_KES.Text = "Переменная X:";
            // 
            // textBoxVarX_KES
            // 
            textBoxVarX_KES.Location = new Point(40, 79);
            textBoxVarX_KES.Name = "textBoxVarX_KES";
            textBoxVarX_KES.Size = new Size(100, 23);
            textBoxVarX_KES.TabIndex = 0;
            textBoxVarX_KES.KeyPress += textBoxVarX_KeyPressed;
            // 
            // groupBoxResult_KES
            // 
            groupBoxResult_KES.Controls.Add(labelResult_KES);
            groupBoxResult_KES.Controls.Add(textBoxResult_KES);
            groupBoxResult_KES.Location = new Point(254, 257);
            groupBoxResult_KES.Name = "groupBoxResult_KES";
            groupBoxResult_KES.Size = new Size(200, 133);
            groupBoxResult_KES.TabIndex = 4;
            groupBoxResult_KES.TabStop = false;
            groupBoxResult_KES.Text = "Вывод данных";
            // 
            // labelResult_KES
            // 
            labelResult_KES.AutoSize = true;
            labelResult_KES.Location = new Point(64, 45);
            labelResult_KES.Name = "labelResult_KES";
            labelResult_KES.Size = new Size(63, 15);
            labelResult_KES.TabIndex = 1;
            labelResult_KES.Text = "Результат:";
            // 
            // textBoxResult_KES
            // 
            textBoxResult_KES.Location = new Point(50, 79);
            textBoxResult_KES.Name = "textBoxResult_KES";
            textBoxResult_KES.ReadOnly = true;
            textBoxResult_KES.Size = new Size(100, 23);
            textBoxResult_KES.TabIndex = 0;
            textBoxResult_KES.TextChanged += buttonResult_Click;
            // 
            // buttonResult_KES
            // 
            buttonResult_KES.Location = new Point(347, 405);
            buttonResult_KES.Name = "buttonResult_KES";
            buttonResult_KES.Size = new Size(107, 37);
            buttonResult_KES.TabIndex = 5;
            buttonResult_KES.Text = "Вычислить";
            buttonResult_KES.UseVisualStyleBackColor = true;
            buttonResult_KES.Click += buttonResult_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(490, 463);
            Controls.Add(buttonResult_KES);
            Controls.Add(groupBoxResult_KES);
            Controls.Add(groupBoxEnter_KES);
            Controls.Add(groupBoxTask_KES);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 7| Королев Е. С.";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_KES).EndInit();
            groupBoxTask_KES.ResumeLayout(false);
            groupBoxTask_KES.PerformLayout();
            groupBoxEnter_KES.ResumeLayout(false);
            groupBoxEnter_KES.PerformLayout();
            groupBoxResult_KES.ResumeLayout(false);
            groupBoxResult_KES.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxTask_KES;
        private PictureBox pictureBoxFormula_KES;
        private GroupBox groupBoxTask_KES;
        private GroupBox groupBoxEnter_KES;
        private TextBox textBoxVarX_KES;
        private Label labelVarX_KES;
        private GroupBox groupBoxResult_KES;
        private TextBox textBoxResult_KES;
        private Label labelResult_KES;
        private Button buttonResult_KES;
    }
}
