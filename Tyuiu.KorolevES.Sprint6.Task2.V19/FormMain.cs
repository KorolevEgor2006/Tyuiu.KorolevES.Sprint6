using Tyuiu.KorolevES.Sprint6.Task2.V19.Lib;
namespace Tyuiu.KorolevES.Sprint6.Task2.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonResult_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxVarStart_KES.Text);
                int stopStep = Convert.ToInt32(textBoxVarEnd_KES.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                double[] xData = new double[len];
                double[] yData = new double[len];

                for (int i = 0; i < len; i++)
                {
                    xData[i] = startStep + i;
                    yData[i] = valueArray[i];
                }
                
                this.chartResult_KES.Titles.Clear();
                this.chartResult_KES.Series[0].Points.Clear();
                this.chartResult_KES.Titles.Add("График функции F(x)");
                this.chartResult_KES.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_KES.ChartAreas[0].AxisY.Title = "Ось Y";
                chartResult_KES.Refresh();
                this.dataGridViewResult_KES.Rows.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewResult_KES.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartResult_KES.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }

            catch
            {
                MessageBox.Show("Неверно введены данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы АСОиУб-24-1 Королев Е.С.", "Справка");
        }
        private void buttonResult_MouseDown(object sender, MouseEventArgs e)
        {
            buttonResult_KES.BackColor = Color.Blue;
        }

        private void buttonResult_MouseEnter(object sender, EventArgs e)
        {
            buttonResult_KES.BackColor = Color.Red;
        }

        private void buttonResult_MouseLeave(object sender, EventArgs e)
        {
            buttonResult_KES.BackColor = Color.Green;
        }
    }
}
