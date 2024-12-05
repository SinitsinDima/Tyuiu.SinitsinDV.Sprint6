using Tyuiu.SinitsinDV.Sprint6.Task1.V5.Lib;
namespace Tyuiu.SinitsinDV.Sprint6.Task1.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonOK_Click(object sender, EventArgs e)
        {

            try
            {
                int startStep = Convert.ToInt32(textBoxstartValue.Text);
                int stopStep = Convert.ToInt32(textBoxstopValue.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                textBoxResult.Text = "";
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult.AppendText("|    X     |   f(x)                 |" + Environment.NewLine);
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 5:f2}               | ", startStep, valueArray[i]);
                    textBoxResult.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);



            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






        }

        private void buttonQuestion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ПКТб-24-1 Синицин Дмитрий Владимирович", "Сообщение");
        }

        private void textBoxstartValue_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxstopValue_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxstartValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
