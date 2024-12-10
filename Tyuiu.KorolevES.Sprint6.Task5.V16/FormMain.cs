using Tyuiu.KorolevES.Sprint6.Task5.V16.Lib;
namespace Tyuiu.KorolevES.Sprint6.Task5.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string path = $@"C:\DataSprint6\InPutDataFileTask5V16.txt";
        DataService ds = new DataService();

        private void buttonResult_KES_Click(object sender, EventArgs e)
        {
            dataGridViewResult_KES.ColumnCount = 2;
            dataGridViewResult_KES.Columns[0].Width = 20;
            dataGridViewResult_KES.Columns[1].Width = 50;

            this.chartResult_KES.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResult_KES.ChartAreas[0].AxisY.Title = "Ось Y";
            chartResult_KES.Series[0].Points.Clear();
            double[] nums = new double[ds.len];
            nums = ds.LoadFromDataFile(path);
            for (int i = 0; i < nums.Length; i++)
            {
                dataGridViewResult_KES.Rows.Add(Convert.ToString(i), Convert.ToString(nums[i]));
                chartResult_KES.Series[0].Points.AddXY(i, nums[i]);
            }
        }

        private void buttonOpen_KES_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_KES_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУб-24-1 Королев Е.С.", "Справка");
        }
    }
}
