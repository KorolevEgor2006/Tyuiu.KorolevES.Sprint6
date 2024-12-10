namespace Tyuiu.KorolevES.Sprint6.Task3.V29
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
            groupBoxTask_KES = new GroupBox();
            textBoxTask_KES = new TextBox();
            dataGridViewResult_KES = new DataGridView();
            buttonResult_KES = new Button();
            groupBoxResult_KES = new GroupBox();
            buttonHelp_KES = new Button();
            groupBoxTask_KES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_KES).BeginInit();
            groupBoxResult_KES.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_KES
            // 
            groupBoxTask_KES.Controls.Add(textBoxTask_KES);
            groupBoxTask_KES.Location = new Point(12, 12);
            groupBoxTask_KES.Name = "groupBoxTask_KES";
            groupBoxTask_KES.Size = new Size(200, 276);
            groupBoxTask_KES.TabIndex = 0;
            groupBoxTask_KES.TabStop = false;
            groupBoxTask_KES.Text = "Условие";
            // 
            // textBoxTask_KES
            // 
            textBoxTask_KES.Location = new Point(6, 22);
            textBoxTask_KES.Multiline = true;
            textBoxTask_KES.Name = "textBoxTask_KES";
            textBoxTask_KES.ReadOnly = true;
            textBoxTask_KES.Size = new Size(178, 237);
            textBoxTask_KES.TabIndex = 0;
            textBoxTask_KES.TabStop = false;
            textBoxTask_KES.Text = resources.GetString("textBoxTask_KES.Text");
            // 
            // dataGridViewResult_KES
            // 
            dataGridViewResult_KES.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_KES.ColumnHeadersVisible = false;
            dataGridViewResult_KES.Location = new Point(21, 22);
            dataGridViewResult_KES.Name = "dataGridViewResult_KES";
            dataGridViewResult_KES.ReadOnly = true;
            dataGridViewResult_KES.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewResult_KES.RowHeadersVisible = false;
            dataGridViewResult_KES.Size = new Size(231, 201);
            dataGridViewResult_KES.TabIndex = 1;
            // 
            // buttonResult_KES
            // 
            buttonResult_KES.Location = new Point(413, 265);
            buttonResult_KES.Name = "buttonResult_KES";
            buttonResult_KES.Size = new Size(97, 23);
            buttonResult_KES.TabIndex = 2;
            buttonResult_KES.Text = "Вычислить";
            buttonResult_KES.UseVisualStyleBackColor = true;
            buttonResult_KES.Click += buttonResult_KES_Click;
            // 
            // groupBoxResult_KES
            // 
            groupBoxResult_KES.Controls.Add(dataGridViewResult_KES);
            groupBoxResult_KES.Location = new Point(235, 12);
            groupBoxResult_KES.Name = "groupBoxResult_KES";
            groupBoxResult_KES.Size = new Size(275, 226);
            groupBoxResult_KES.TabIndex = 3;
            groupBoxResult_KES.TabStop = false;
            groupBoxResult_KES.Text = "Вывод данных";
            // 
            // buttonHelp_KES
            // 
            buttonHelp_KES.FlatStyle = FlatStyle.Flat;
            buttonHelp_KES.Location = new Point(373, 265);
            buttonHelp_KES.Name = "buttonHelp_KES";
            buttonHelp_KES.Size = new Size(34, 23);
            buttonHelp_KES.TabIndex = 4;
            buttonHelp_KES.Text = "?";
            buttonHelp_KES.UseVisualStyleBackColor = true;
            buttonHelp_KES.Click += buttonHelp_KES_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 300);
            Controls.Add(buttonHelp_KES);
            Controls.Add(groupBoxResult_KES);
            Controls.Add(buttonResult_KES);
            Controls.Add(groupBoxTask_KES);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 29 | Королев Е.С.";
            Load += FormMain_Load;
            groupBoxTask_KES.ResumeLayout(false);
            groupBoxTask_KES.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_KES).EndInit();
            groupBoxResult_KES.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_KES;
        private TextBox textBoxTask_KES;
        private DataGridView dataGridViewResult_KES;
        private Button buttonResult_KES;
        private GroupBox groupBoxResult_KES;
        private Button buttonHelp_KES;
    }
}
