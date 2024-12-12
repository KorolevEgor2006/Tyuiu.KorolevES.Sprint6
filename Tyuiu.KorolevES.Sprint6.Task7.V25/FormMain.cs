using System.Drawing.Drawing2D;
using System.IO;
using Tyuiu.KorolevES.Sprint6.Task7.V25.Lib;

namespace Tyuiu.KorolevES.Sprint6.Task7.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_KES.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_KES.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        DataService ds = new DataService();
        string openFilePath;
        int[,] matrixres;
        private void buttonOpenFile_KES_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogTask_KES.ShowDialog();
                openFilePath = openFileDialogTask_KES.FileName;
                string fileData = File.ReadAllText(openFilePath);

                fileData = fileData.Replace("\n", "\r");
                string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

                int rows = lines.Length;
                int columns = lines[0].Split(';').Length;

                int[,] matrix = new int[rows, columns];

                for (int r = 0; r < rows; r++)
                {
                    string[] line = lines[r].Split(';');
                    for (int c = 0; c < columns; c++)
                    {
                        matrix[r, c] = Convert.ToInt32(line[c]);
                    }
                }
                dataGridViewIn_KES.ColumnCount = matrix.GetLength(1);
                dataGridViewIn_KES.RowCount = matrix.GetLength(0);
                dataGridViewOut_KES.ColumnCount = matrix.GetLength(1);
                dataGridViewOut_KES.RowCount = matrix.GetLength(0);
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    dataGridViewIn_KES.Columns[i].Width = 25;
                    dataGridViewOut_KES.Columns[i].Width = 25;
                    for (int j = 0; j < matrix.GetLength(0); j++)
                    {
                        dataGridViewIn_KES.Rows[j].Cells[i].Value = matrix[j, i];
                    }
                }
                buttonDone_KES.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Неудалось открыть файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_KES_Click(object sender, EventArgs e)
        {
            matrixres = new int[ds.GetMatrix(openFilePath).GetLength(0), ds.GetMatrix(openFilePath).GetLength(1)];
            matrixres = ds.GetMatrix(openFilePath);
            for (int i = 0; i < matrixres.GetLength(1); i++)
            {
                for (int j = 0; j < matrixres.GetLength(0); j++)
                {
                    dataGridViewOut_KES.Rows[j].Cells[i].Value = matrixres[j, i];
                }
            }
            buttonSaveFile_KES.Enabled = true;
        }

        private void buttonSaveFile_KES_Click(object sender, EventArgs e)
        {
            saveFileDialog_KES.FileName = "OutPutFileTask7.csv";
            saveFileDialog_KES.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_KES.ShowDialog();

            string path = saveFileDialog_KES.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_KES.RowCount;
            int columns = dataGridViewOut_KES.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_KES.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_KES.Rows[i].Cells[j].Value;
                    }
                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonInfo_KES_Click(object sender, EventArgs e)
        {
            FormAbout f = new FormAbout();
            f.ShowDialog();
        }
    }
}
