namespace Tyuiu.KorolevES.Sprint6.Task5.V16
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
            panelUp_KES = new Panel();
            buttonHelp_KES = new Button();
            groupBoxTask_KES = new GroupBox();
            textBoxTask_KES = new TextBox();
            buttonOpen_KES = new Button();
            buttonResult_KES = new Button();
            groupBoxResult_KES = new GroupBox();
            dataGridViewResult_KES = new DataGridView();
            panelLeft_KES = new Panel();
            splitterLeftAndFill_KES = new Splitter();
            panelFill_KES = new Panel();
            chartResult_KES = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelUp_KES.SuspendLayout();
            groupBoxTask_KES.SuspendLayout();
            groupBoxResult_KES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_KES).BeginInit();
            panelLeft_KES.SuspendLayout();
            panelFill_KES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult_KES).BeginInit();
            SuspendLayout();
            // 
            // panelUp_KES
            // 
            panelUp_KES.Controls.Add(buttonHelp_KES);
            panelUp_KES.Controls.Add(groupBoxTask_KES);
            panelUp_KES.Controls.Add(buttonOpen_KES);
            panelUp_KES.Controls.Add(buttonResult_KES);
            panelUp_KES.Dock = DockStyle.Top;
            panelUp_KES.Location = new Point(0, 0);
            panelUp_KES.Name = "panelUp_KES";
            panelUp_KES.Padding = new Padding(30);
            panelUp_KES.Size = new Size(736, 124);
            panelUp_KES.TabIndex = 14;
            // 
            // buttonHelp_KES
            // 
            buttonHelp_KES.BackColor = Color.CornflowerBlue;
            buttonHelp_KES.Dock = DockStyle.Right;
            buttonHelp_KES.ForeColor = SystemColors.ControlText;
            buttonHelp_KES.Location = new Point(628, 30);
            buttonHelp_KES.Name = "buttonHelp_KES";
            buttonHelp_KES.Size = new Size(78, 64);
            buttonHelp_KES.TabIndex = 9;
            buttonHelp_KES.Text = "Справка";
            buttonHelp_KES.UseVisualStyleBackColor = false;
            buttonHelp_KES.Click += buttonHelp_KES_Click;
            // 
            // groupBoxTask_KES
            // 
            groupBoxTask_KES.Controls.Add(textBoxTask_KES);
            groupBoxTask_KES.Location = new Point(8, 6);
            groupBoxTask_KES.Name = "groupBoxTask_KES";
            groupBoxTask_KES.Size = new Size(414, 100);
            groupBoxTask_KES.TabIndex = 1;
            groupBoxTask_KES.TabStop = false;
            groupBoxTask_KES.Text = "Условие";
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
            textBoxTask_KES.Text = "Прочитать данные из файла InPutFileTask5V16.txt. Вывести в dataGridView. Вывести все положительные числа.Построить диаграмму по этим значениям.";
            // 
            // buttonOpen_KES
            // 
            buttonOpen_KES.BackColor = Color.RoyalBlue;
            buttonOpen_KES.Location = new Point(524, 30);
            buttonOpen_KES.Name = "buttonOpen_KES";
            buttonOpen_KES.Size = new Size(96, 57);
            buttonOpen_KES.TabIndex = 10;
            buttonOpen_KES.Text = "Открыть";
            buttonOpen_KES.UseVisualStyleBackColor = false;
            buttonOpen_KES.Click += buttonOpen_KES_Click;
            // 
            // buttonResult_KES
            // 
            buttonResult_KES.BackColor = Color.Green;
            buttonResult_KES.Location = new Point(428, 30);
            buttonResult_KES.Name = "buttonResult_KES";
            buttonResult_KES.Size = new Size(90, 54);
            buttonResult_KES.TabIndex = 8;
            buttonResult_KES.Text = "Выполнить";
            buttonResult_KES.UseVisualStyleBackColor = false;
            buttonResult_KES.Click += buttonResult_KES_Click;
            // 
            // groupBoxResult_KES
            // 
            groupBoxResult_KES.BackColor = SystemColors.Control;
            groupBoxResult_KES.Controls.Add(dataGridViewResult_KES);
            groupBoxResult_KES.Dock = DockStyle.Fill;
            groupBoxResult_KES.Location = new Point(10, 10);
            groupBoxResult_KES.Name = "groupBoxResult_KES";
            groupBoxResult_KES.Size = new Size(203, 427);
            groupBoxResult_KES.TabIndex = 15;
            groupBoxResult_KES.TabStop = false;
            groupBoxResult_KES.Text = "Вывод:";
            // 
            // dataGridViewResult_KES
            // 
            dataGridViewResult_KES.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_KES.ColumnHeadersVisible = false;
            dataGridViewResult_KES.Dock = DockStyle.Fill;
            dataGridViewResult_KES.Location = new Point(3, 19);
            dataGridViewResult_KES.Name = "dataGridViewResult_KES";
            dataGridViewResult_KES.RowHeadersVisible = false;
            dataGridViewResult_KES.Size = new Size(197, 405);
            dataGridViewResult_KES.TabIndex = 0;
            // 
            // panelLeft_KES
            // 
            panelLeft_KES.Controls.Add(groupBoxResult_KES);
            panelLeft_KES.Dock = DockStyle.Left;
            panelLeft_KES.Location = new Point(0, 124);
            panelLeft_KES.Name = "panelLeft_KES";
            panelLeft_KES.Padding = new Padding(10);
            panelLeft_KES.Size = new Size(223, 447);
            panelLeft_KES.TabIndex = 16;
            // 
            // splitterLeftAndFill_KES
            // 
            splitterLeftAndFill_KES.Location = new Point(223, 124);
            splitterLeftAndFill_KES.Name = "splitterLeftAndFill_KES";
            splitterLeftAndFill_KES.Size = new Size(3, 447);
            splitterLeftAndFill_KES.TabIndex = 17;
            splitterLeftAndFill_KES.TabStop = false;
            // 
            // panelFill_KES
            // 
            panelFill_KES.Controls.Add(chartResult_KES);
            panelFill_KES.Dock = DockStyle.Fill;
            panelFill_KES.Location = new Point(226, 124);
            panelFill_KES.Name = "panelFill_KES";
            panelFill_KES.Size = new Size(510, 447);
            panelFill_KES.TabIndex = 18;
            // 
            // chartResult_KES
            // 
            chartArea1.Name = "ChartArea1";
            chartResult_KES.ChartAreas.Add(chartArea1);
            chartResult_KES.Dock = DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartResult_KES.Legends.Add(legend1);
            chartResult_KES.Location = new Point(0, 0);
            chartResult_KES.Name = "chartResult_KES";
            chartResult_KES.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartResult_KES.Series.Add(series1);
            chartResult_KES.Size = new Size(510, 447);
            chartResult_KES.TabIndex = 0;
            chartResult_KES.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 571);
            Controls.Add(panelFill_KES);
            Controls.Add(splitterLeftAndFill_KES);
            Controls.Add(panelLeft_KES);
            Controls.Add(panelUp_KES);
            MinimumSize = new Size(752, 610);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 Таск 5 Вариант 16 Королев Е.С.";
            panelUp_KES.ResumeLayout(false);
            groupBoxTask_KES.ResumeLayout(false);
            groupBoxTask_KES.PerformLayout();
            groupBoxResult_KES.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_KES).EndInit();
            panelLeft_KES.ResumeLayout(false);
            panelFill_KES.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartResult_KES).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUp_KES;
        private Button buttonHelp_KES;
        private GroupBox groupBoxTask_KES;
        private TextBox textBoxTask_KES;
        private Button buttonOpen_KES;
        private Button buttonResult_KES;
        private GroupBox groupBoxResult_KES;
        private Panel panelLeft_KES;
        private Splitter splitterLeftAndFill_KES;
        private Panel panelFill_KES;
        private DataGridView dataGridViewResult_KES;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_KES;
    }
}
