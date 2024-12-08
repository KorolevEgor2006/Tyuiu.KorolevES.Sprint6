using Tyuiu.KorolevES.Sprint6.Task0.V7.Lib;
namespace Tyuiu.KorolevES.Sprint6.Task0.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try 
            {
                textBoxResult_KES.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_KES.Text)));
            }
            catch
            {
                MessageBox.Show("Неверные данные","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void textBoxVarX_KeyPressed(object sender, KeyPressEventArgs e) 
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar!=',')&&(e.KeyChar!=8)) e.Handled=true;
        }
    }
}
