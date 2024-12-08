using System.Linq.Expressions;
using Tyuiu.KorolevES.Sprint6.Task1.V2.Lib;
namespace Tyuiu.KorolevES.Sprint6.Task1.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonResultClick(object sender, EventArgs e)
        {
            try 
            {
                int len = ds.GetMassFunction(Convert.ToInt32(textBoxVarStart_KES.Text), Convert.ToInt32(textBoxVarEnd_KES.Text)).Length;
                int s = Convert.ToInt32(textBoxVarStart_KES.Text);
                double[] mass = new double[len];
                mass = ds.GetMassFunction(Convert.ToInt32(textBoxVarStart_KES.Text), Convert.ToInt32(textBoxVarEnd_KES.Text));
                textBoxResult_KES.Text = "";
                textBoxResult_KES.AppendText("+---------+----------+" + Environment.NewLine);
                textBoxResult_KES.AppendText("|    X    |    f(x)  |" + Environment.NewLine);
                textBoxResult_KES.AppendText("+---------+----------+" + Environment.NewLine);
                string str;
                for (int i = 0; i < len; i++) 
                {
                    str = String.Format("|{0,5:d}    |  {1,6:f2}  |", s, mass[i]);
                    textBoxResult_KES.AppendText(str+Environment.NewLine);
                    s++;
                }
                textBoxResult_KES.AppendText("+---------+----------+" + Environment.NewLine);
            }
            catch 
            {
                MessageBox.Show("Введены некоректные данные","Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelpClick(object sender, EventArgs e)  
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУб-24-1 Королев Е.С.", "Справка");
        }
    }
}
