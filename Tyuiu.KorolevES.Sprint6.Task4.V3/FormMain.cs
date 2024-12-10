using Tyuiu.KorolevES.Sprint6.Task4.V3.Lib;
using System.IO;
using System.Xml.Schema;
namespace Tyuiu.KorolevES.Sprint6.Task4.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonResult_KES_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxVarStart_KES.Text);
                int end = Convert.ToInt32(textBoxVarEnd_KES.Text);
                DataService ds = new DataService();
                double[] mass = new double[ds.GetMassFunction(start, end).Length];
                mass = ds.GetMassFunction(start, end);
                this.chartGraphick_KES.Series[0].Points.Clear();
                this.chartGraphick_KES.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartGraphick_KES.ChartAreas[0].AxisY.Title = "Ось Y";
                chartGraphick_KES.Refresh();
                textBoxResult_KES.Text = "";
                int s = start;
                for (int i = 0; i < mass.Length; i++)
                {
                    textBoxResult_KES.AppendText(mass[i].ToString() + Environment.NewLine);
                    this.chartGraphick_KES.Series[0].Points.AddXY(s, mass[i]);
                    s++;
                }
            }
            catch
            {
                MessageBox.Show("Неверно введены данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_KES_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4V3.txt");
                File.WriteAllText(path, textBoxResult_KES.Text);
                DialogResult dr = MessageBox.Show("Файл " + path + " сохранен успешно!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_KES_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы АСОиУб-24-1 Королев Е.С.", "Справка");
        }
    }
}
