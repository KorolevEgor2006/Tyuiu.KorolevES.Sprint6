namespace Tyuiu.KorolevES.Sprint6.Task4.V3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxTask_KES = new GroupBox();
            pictureBoxFormula_KES = new PictureBox();
            textBoxTask_KES = new TextBox();
            buttonHelp_KES = new Button();
            buttonResult_KES = new Button();
            groupBoxEnter_KES = new GroupBox();
            labelVarEnd_KES = new Label();
            labelVarStart_KES = new Label();
            textBoxVarEnd_KES = new TextBox();
            textBoxVarStart_KES = new TextBox();
            buttonSave_KES = new Button();
            textBoxResult_KES = new TextBox();
            groupBoxResult_KES = new GroupBox();
            chartGraphick_KES = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelUp_KES = new Panel();
            panelLeft_KES = new Panel();
            splitterLeftAndFill_KES = new Splitter();
            panelFill_KES = new Panel();
            groupBoxTask_KES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_KES).BeginInit();
            groupBoxEnter_KES.SuspendLayout();
            groupBoxResult_KES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartGraphick_KES).BeginInit();
            panelUp_KES.SuspendLayout();
            panelLeft_KES.SuspendLayout();
            panelFill_KES.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_KES
            // 
            groupBoxTask_KES.Controls.Add(pictureBoxFormula_KES);
            groupBoxTask_KES.Controls.Add(textBoxTask_KES);
            groupBoxTask_KES.Location = new Point(8, 6);
            groupBoxTask_KES.Name = "groupBoxTask_KES";
            groupBoxTask_KES.Size = new Size(622, 100);
            groupBoxTask_KES.TabIndex = 1;
            groupBoxTask_KES.TabStop = false;
            groupBoxTask_KES.Text = "Условие";
            // 
            // pictureBoxFormula_KES
            // 
            pictureBoxFormula_KES.Image = Properties.Resources.FormulaTask4V3;
            pictureBoxFormula_KES.Location = new Point(400, 22);
            pictureBoxFormula_KES.Name = "pictureBoxFormula_KES";
            pictureBoxFormula_KES.Size = new Size(214, 36);
            pictureBoxFormula_KES.TabIndex = 1;
            pictureBoxFormula_KES.TabStop = false;
            // 
            // textBoxTask_KES
            // 
            textBoxTask_KES.Location = new Point(16, 22);
            textBoxTask_KES.Multiline = true;
            textBoxTask_KES.Name = "textBoxTask_KES";
            textBoxTask_KES.ReadOnly = true;
            textBoxTask_KES.Size = new Size(378, 57);
            textBoxTask_KES.TabIndex = 0;
            textBoxTask_KES.TabStop = false;
            textBoxTask_KES.Text = "Протабулировать функцию f(x) на заданном промежутке [-5,5].\r\nРезультат вывести в textBox, построить график функции и сохранить в файл OutPutFileTask4V3.txt по нажатию кнопки.";
            // 
            // buttonHelp_KES
            // 
            buttonHelp_KES.BackColor = Color.CornflowerBlue;
            buttonHelp_KES.Dock = DockStyle.Right;
            buttonHelp_KES.ForeColor = SystemColors.ControlText;
            buttonHelp_KES.Location = new Point(1126, 30);
            buttonHelp_KES.Name = "buttonHelp_KES";
            buttonHelp_KES.Size = new Size(78, 57);
            buttonHelp_KES.TabIndex = 9;
            buttonHelp_KES.Text = "Справка";
            buttonHelp_KES.UseVisualStyleBackColor = false;
            buttonHelp_KES.Click += buttonHelp_KES_Click;
            // 
            // buttonResult_KES
            // 
            buttonResult_KES.BackColor = Color.Green;
            buttonResult_KES.Location = new Point(930, 32);
            buttonResult_KES.Name = "buttonResult_KES";
            buttonResult_KES.Size = new Size(90, 53);
            buttonResult_KES.TabIndex = 8;
            buttonResult_KES.Text = "Выполнить";
            buttonResult_KES.UseVisualStyleBackColor = false;
            buttonResult_KES.Click += buttonResult_KES_Click;
            // 
            // groupBoxEnter_KES
            // 
            groupBoxEnter_KES.Controls.Add(labelVarEnd_KES);
            groupBoxEnter_KES.Controls.Add(labelVarStart_KES);
            groupBoxEnter_KES.Controls.Add(textBoxVarEnd_KES);
            groupBoxEnter_KES.Controls.Add(textBoxVarStart_KES);
            groupBoxEnter_KES.Location = new Point(650, 6);
            groupBoxEnter_KES.Name = "groupBoxEnter_KES";
            groupBoxEnter_KES.Size = new Size(273, 100);
            groupBoxEnter_KES.TabIndex = 7;
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
            // buttonSave_KES
            // 
            buttonSave_KES.BackColor = Color.RoyalBlue;
            buttonSave_KES.Location = new Point(1026, 32);
            buttonSave_KES.Name = "buttonSave_KES";
            buttonSave_KES.Size = new Size(90, 53);
            buttonSave_KES.TabIndex = 10;
            buttonSave_KES.Text = "Сохранить";
            buttonSave_KES.UseVisualStyleBackColor = false;
            buttonSave_KES.Click += buttonSave_KES_Click;
            // 
            // textBoxResult_KES
            // 
            textBoxResult_KES.Dock = DockStyle.Fill;
            textBoxResult_KES.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_KES.Location = new Point(3, 19);
            textBoxResult_KES.Multiline = true;
            textBoxResult_KES.Name = "textBoxResult_KES";
            textBoxResult_KES.ReadOnly = true;
            textBoxResult_KES.ScrollBars = ScrollBars.Vertical;
            textBoxResult_KES.Size = new Size(268, 477);
            textBoxResult_KES.TabIndex = 1;
            textBoxResult_KES.TabStop = false;
            // 
            // groupBoxResult_KES
            // 
            groupBoxResult_KES.BackColor = SystemColors.Control;
            groupBoxResult_KES.Controls.Add(textBoxResult_KES);
            groupBoxResult_KES.Dock = DockStyle.Fill;
            groupBoxResult_KES.Location = new Point(0, 0);
            groupBoxResult_KES.Name = "groupBoxResult_KES";
            groupBoxResult_KES.Size = new Size(274, 499);
            groupBoxResult_KES.TabIndex = 11;
            groupBoxResult_KES.TabStop = false;
            groupBoxResult_KES.Text = "Вывод:";
            // 
            // chartGraphick_KES
            // 
            chartArea1.Name = "ChartArea1";
            chartGraphick_KES.ChartAreas.Add(chartArea1);
            chartGraphick_KES.Dock = DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartGraphick_KES.Legends.Add(legend1);
            chartGraphick_KES.Location = new Point(0, 0);
            chartGraphick_KES.Name = "chartGraphick_KES";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series_KES";
            chartGraphick_KES.Series.Add(series1);
            chartGraphick_KES.Size = new Size(957, 499);
            chartGraphick_KES.TabIndex = 12;
            chartGraphick_KES.Text = "График функции f(x)";
            title1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title1.ForeColor = Color.DodgerBlue;
            title1.Name = "TitleGraph";
            title1.Text = "График функции F(x)";
            chartGraphick_KES.Titles.Add(title1);
            // 
            // panelUp_KES
            // 
            panelUp_KES.Controls.Add(buttonHelp_KES);
            panelUp_KES.Controls.Add(groupBoxTask_KES);
            panelUp_KES.Controls.Add(buttonSave_KES);
            panelUp_KES.Controls.Add(buttonResult_KES);
            panelUp_KES.Controls.Add(groupBoxEnter_KES);
            panelUp_KES.Dock = DockStyle.Top;
            panelUp_KES.Location = new Point(0, 0);
            panelUp_KES.Name = "panelUp_KES";
            panelUp_KES.Padding = new Padding(30);
            panelUp_KES.Size = new Size(1234, 117);
            panelUp_KES.TabIndex = 13;
            // 
            // panelLeft_KES
            // 
            panelLeft_KES.BackColor = SystemColors.ButtonShadow;
            panelLeft_KES.Controls.Add(groupBoxResult_KES);
            panelLeft_KES.Dock = DockStyle.Left;
            panelLeft_KES.Location = new Point(0, 117);
            panelLeft_KES.Name = "panelLeft_KES";
            panelLeft_KES.Size = new Size(274, 499);
            panelLeft_KES.TabIndex = 14;
            // 
            // splitterLeftAndFill_KES
            // 
            splitterLeftAndFill_KES.Location = new Point(274, 117);
            splitterLeftAndFill_KES.Name = "splitterLeftAndFill_KES";
            splitterLeftAndFill_KES.Size = new Size(3, 499);
            splitterLeftAndFill_KES.TabIndex = 15;
            splitterLeftAndFill_KES.TabStop = false;
            // 
            // panelFill_KES
            // 
            panelFill_KES.Controls.Add(chartGraphick_KES);
            panelFill_KES.Dock = DockStyle.Fill;
            panelFill_KES.Location = new Point(277, 117);
            panelFill_KES.Name = "panelFill_KES";
            panelFill_KES.Size = new Size(957, 499);
            panelFill_KES.TabIndex = 16;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 616);
            Controls.Add(panelFill_KES);
            Controls.Add(splitterLeftAndFill_KES);
            Controls.Add(panelLeft_KES);
            Controls.Add(panelUp_KES);
            MinimumSize = new Size(1250, 655);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 |Таск 4 |Вариант 3 |Королев Е.С";
            groupBoxTask_KES.ResumeLayout(false);
            groupBoxTask_KES.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_KES).EndInit();
            groupBoxEnter_KES.ResumeLayout(false);
            groupBoxEnter_KES.PerformLayout();
            groupBoxResult_KES.ResumeLayout(false);
            groupBoxResult_KES.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartGraphick_KES).EndInit();
            panelUp_KES.ResumeLayout(false);
            panelLeft_KES.ResumeLayout(false);
            panelFill_KES.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_KES;
        private PictureBox pictureBoxFormula_KES;
        private TextBox textBoxTask_KES;
        private Button buttonHelp_KES;
        private Button buttonResult_KES;
        private GroupBox groupBoxEnter_KES;
        private Label labelVarEnd_KES;
        private Label labelVarStart_KES;
        private TextBox textBoxVarEnd_KES;
        private TextBox textBoxVarStart_KES;
        private Button buttonSave_KES;
        private TextBox textBoxResult_KES;
        private GroupBox groupBoxResult_KES;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraphick_KES;
        private Panel panelUp_KES;
        private Panel panelLeft_KES;
        private Splitter splitterLeftAndFill_KES;
        private Panel panelFill_KES;
    }
}
