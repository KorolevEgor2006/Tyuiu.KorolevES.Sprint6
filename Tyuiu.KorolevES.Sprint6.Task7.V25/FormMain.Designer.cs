namespace Tyuiu.KorolevES.Sprint6.Task7.V25
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelUp_KES = new Panel();
            buttonSaveFile_KES = new Button();
            buttonInfo_KES = new Button();
            buttonDone_KES = new Button();
            buttonOpenFile_KES = new Button();
            groupBoxTask_KES = new GroupBox();
            textBoxTask_KES = new TextBox();
            panelCenter_KES = new Panel();
            panelLeft_KES = new Panel();
            groupBoxIn_KES = new GroupBox();
            dataGridViewIn_KES = new DataGridView();
            splitterLeft_KES = new Splitter();
            panelRight_KES = new Panel();
            groupBoxOut_KES = new GroupBox();
            dataGridViewOut_KES = new DataGridView();
            toolTipButton_KES = new ToolTip(components);
            openFileDialogTask_KES = new OpenFileDialog();
            saveFileDialog_KES = new SaveFileDialog();
            panelUp_KES.SuspendLayout();
            groupBoxTask_KES.SuspendLayout();
            panelCenter_KES.SuspendLayout();
            panelLeft_KES.SuspendLayout();
            groupBoxIn_KES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_KES).BeginInit();
            panelRight_KES.SuspendLayout();
            groupBoxOut_KES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_KES).BeginInit();
            SuspendLayout();
            // 
            // panelUp_KES
            // 
            panelUp_KES.Controls.Add(buttonSaveFile_KES);
            panelUp_KES.Controls.Add(buttonInfo_KES);
            panelUp_KES.Controls.Add(buttonDone_KES);
            panelUp_KES.Controls.Add(buttonOpenFile_KES);
            panelUp_KES.Dock = DockStyle.Top;
            panelUp_KES.Location = new Point(0, 0);
            panelUp_KES.Name = "panelUp_KES";
            panelUp_KES.Size = new Size(800, 95);
            panelUp_KES.TabIndex = 1;
            // 
            // buttonSaveFile_KES
            // 
            buttonSaveFile_KES.BackgroundImage = Properties.Resources.Save_37110;
            buttonSaveFile_KES.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSaveFile_KES.Enabled = false;
            buttonSaveFile_KES.FlatStyle = FlatStyle.Flat;
            buttonSaveFile_KES.Location = new Point(187, 0);
            buttonSaveFile_KES.Name = "buttonSaveFile_KES";
            buttonSaveFile_KES.Size = new Size(99, 95);
            buttonSaveFile_KES.TabIndex = 6;
            toolTipButton_KES.SetToolTip(buttonSaveFile_KES, "Сохранить файл");
            buttonSaveFile_KES.UseVisualStyleBackColor = true;
            buttonSaveFile_KES.Click += buttonSaveFile_KES_Click;
            // 
            // buttonInfo_KES
            // 
            buttonInfo_KES.BackgroundImage = Properties.Resources.Info_Simple_svg;
            buttonInfo_KES.BackgroundImageLayout = ImageLayout.Zoom;
            buttonInfo_KES.Dock = DockStyle.Right;
            buttonInfo_KES.FlatStyle = FlatStyle.Flat;
            buttonInfo_KES.Location = new Point(707, 0);
            buttonInfo_KES.Name = "buttonInfo_KES";
            buttonInfo_KES.Size = new Size(93, 95);
            buttonInfo_KES.TabIndex = 5;
            toolTipButton_KES.SetToolTip(buttonInfo_KES, "Сведения о программе");
            buttonInfo_KES.UseVisualStyleBackColor = true;
            buttonInfo_KES.Click += buttonInfo_KES_Click;
            // 
            // buttonDone_KES
            // 
            buttonDone_KES.BackgroundImage = Properties.Resources._222_2225387_download_icon_png_export_transparent_file_export_icon;
            buttonDone_KES.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDone_KES.Enabled = false;
            buttonDone_KES.FlatStyle = FlatStyle.Flat;
            buttonDone_KES.Location = new Point(96, 0);
            buttonDone_KES.Name = "buttonDone_KES";
            buttonDone_KES.Size = new Size(94, 95);
            buttonDone_KES.TabIndex = 4;
            toolTipButton_KES.SetToolTip(buttonDone_KES, "Выполнить");
            buttonDone_KES.UseVisualStyleBackColor = true;
            buttonDone_KES.Click += buttonDone_KES_Click;
            // 
            // buttonOpenFile_KES
            // 
            buttonOpenFile_KES.BackgroundImage = Properties.Resources.folder;
            buttonOpenFile_KES.BackgroundImageLayout = ImageLayout.Zoom;
            buttonOpenFile_KES.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_KES.Location = new Point(0, 0);
            buttonOpenFile_KES.Name = "buttonOpenFile_KES";
            buttonOpenFile_KES.Size = new Size(99, 95);
            buttonOpenFile_KES.TabIndex = 3;
            toolTipButton_KES.SetToolTip(buttonOpenFile_KES, "Открыть файл");
            buttonOpenFile_KES.UseVisualStyleBackColor = true;
            buttonOpenFile_KES.Click += buttonOpenFile_KES_Click;
            // 
            // groupBoxTask_KES
            // 
            groupBoxTask_KES.Controls.Add(textBoxTask_KES);
            groupBoxTask_KES.Dock = DockStyle.Fill;
            groupBoxTask_KES.Location = new Point(0, 0);
            groupBoxTask_KES.Name = "groupBoxTask_KES";
            groupBoxTask_KES.Size = new Size(800, 73);
            groupBoxTask_KES.TabIndex = 2;
            groupBoxTask_KES.TabStop = false;
            groupBoxTask_KES.Text = "Условие";
            // 
            // textBoxTask_KES
            // 
            textBoxTask_KES.Dock = DockStyle.Fill;
            textBoxTask_KES.Location = new Point(3, 19);
            textBoxTask_KES.Multiline = true;
            textBoxTask_KES.Name = "textBoxTask_KES";
            textBoxTask_KES.ReadOnly = true;
            textBoxTask_KES.Size = new Size(794, 51);
            textBoxTask_KES.TabIndex = 0;
            textBoxTask_KES.TabStop = false;
            textBoxTask_KES.Text = resources.GetString("textBoxTask_KES.Text");
            // 
            // panelCenter_KES
            // 
            panelCenter_KES.Controls.Add(groupBoxTask_KES);
            panelCenter_KES.Dock = DockStyle.Top;
            panelCenter_KES.Location = new Point(0, 95);
            panelCenter_KES.Name = "panelCenter_KES";
            panelCenter_KES.Size = new Size(800, 73);
            panelCenter_KES.TabIndex = 3;
            // 
            // panelLeft_KES
            // 
            panelLeft_KES.Controls.Add(groupBoxIn_KES);
            panelLeft_KES.Dock = DockStyle.Left;
            panelLeft_KES.Location = new Point(0, 168);
            panelLeft_KES.Name = "panelLeft_KES";
            panelLeft_KES.Size = new Size(384, 282);
            panelLeft_KES.TabIndex = 4;
            // 
            // groupBoxIn_KES
            // 
            groupBoxIn_KES.Controls.Add(dataGridViewIn_KES);
            groupBoxIn_KES.Dock = DockStyle.Fill;
            groupBoxIn_KES.Location = new Point(0, 0);
            groupBoxIn_KES.Name = "groupBoxIn_KES";
            groupBoxIn_KES.Padding = new Padding(5);
            groupBoxIn_KES.Size = new Size(384, 282);
            groupBoxIn_KES.TabIndex = 0;
            groupBoxIn_KES.TabStop = false;
            groupBoxIn_KES.Text = "Ввод:";
            // 
            // dataGridViewIn_KES
            // 
            dataGridViewIn_KES.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_KES.ColumnHeadersVisible = false;
            dataGridViewIn_KES.Dock = DockStyle.Fill;
            dataGridViewIn_KES.Location = new Point(5, 21);
            dataGridViewIn_KES.Name = "dataGridViewIn_KES";
            dataGridViewIn_KES.RowHeadersVisible = false;
            dataGridViewIn_KES.Size = new Size(374, 256);
            dataGridViewIn_KES.TabIndex = 0;
            // 
            // splitterLeft_KES
            // 
            splitterLeft_KES.Location = new Point(384, 168);
            splitterLeft_KES.Name = "splitterLeft_KES";
            splitterLeft_KES.Size = new Size(3, 282);
            splitterLeft_KES.TabIndex = 5;
            splitterLeft_KES.TabStop = false;
            // 
            // panelRight_KES
            // 
            panelRight_KES.Controls.Add(groupBoxOut_KES);
            panelRight_KES.Dock = DockStyle.Fill;
            panelRight_KES.Location = new Point(387, 168);
            panelRight_KES.Name = "panelRight_KES";
            panelRight_KES.Size = new Size(413, 282);
            panelRight_KES.TabIndex = 6;
            // 
            // groupBoxOut_KES
            // 
            groupBoxOut_KES.Controls.Add(dataGridViewOut_KES);
            groupBoxOut_KES.Dock = DockStyle.Fill;
            groupBoxOut_KES.Location = new Point(0, 0);
            groupBoxOut_KES.Name = "groupBoxOut_KES";
            groupBoxOut_KES.Padding = new Padding(5);
            groupBoxOut_KES.Size = new Size(413, 282);
            groupBoxOut_KES.TabIndex = 1;
            groupBoxOut_KES.TabStop = false;
            groupBoxOut_KES.Text = "Вывод:";
            // 
            // dataGridViewOut_KES
            // 
            dataGridViewOut_KES.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_KES.ColumnHeadersVisible = false;
            dataGridViewOut_KES.Dock = DockStyle.Fill;
            dataGridViewOut_KES.Location = new Point(5, 21);
            dataGridViewOut_KES.Name = "dataGridViewOut_KES";
            dataGridViewOut_KES.RowHeadersVisible = false;
            dataGridViewOut_KES.Size = new Size(403, 256);
            dataGridViewOut_KES.TabIndex = 1;
            // 
            // toolTipButton_KES
            // 
            toolTipButton_KES.ToolTipIcon = ToolTipIcon.Info;
            toolTipButton_KES.ToolTipTitle = "Подсказка";
            // 
            // openFileDialogTask_KES
            // 
            openFileDialogTask_KES.FileName = "openFileDialogTask";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelRight_KES);
            Controls.Add(splitterLeft_KES);
            Controls.Add(panelLeft_KES);
            Controls.Add(panelCenter_KES);
            Controls.Add(panelUp_KES);
            MinimumSize = new Size(816, 489);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 25 | Королев Е.С.";
            panelUp_KES.ResumeLayout(false);
            groupBoxTask_KES.ResumeLayout(false);
            groupBoxTask_KES.PerformLayout();
            panelCenter_KES.ResumeLayout(false);
            panelLeft_KES.ResumeLayout(false);
            groupBoxIn_KES.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_KES).EndInit();
            panelRight_KES.ResumeLayout(false);
            groupBoxOut_KES.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_KES).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUp_KES;
        private Button buttonInfo_KES;
        private Button buttonDone_KES;
        private Button buttonOpenFile_KES;
        private GroupBox groupBoxTask_KES;
        private TextBox textBoxTask_KES;
        private Panel panelCenter_KES;
        private Panel panelLeft_KES;
        private GroupBox groupBoxIn_KES;
        private Splitter splitterLeft_KES;
        private Panel panelRight_KES;
        private Button buttonSaveFile_KES;
        private DataGridView dataGridViewIn_KES;
        private GroupBox groupBoxOut_KES;
        private DataGridView dataGridViewOut_KES;
        private ToolTip toolTipButton_KES;
        private OpenFileDialog openFileDialogTask_KES;
        private SaveFileDialog saveFileDialog_KES;
    }
}
