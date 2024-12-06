using Tyuiu.SinitsinDV.Sprint6.Task2.V8.Lib;
namespace Tyuiu.SinitsinDV.Sprint6.Task2.V8
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

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartGraf.Titles.Add("График функции f(x)");

                this.chartGraf.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartGraf.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewTasks.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartGraf.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }



            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ПКТб-24-1 Синицин Дмитрий Владимирович", "Сообщение");
        }

        private void buttonOK_MouseEnter(object sender, EventArgs e)
        {
            buttonOK.BackColor = Color.Red;
        }

        private void buttonOK_MouseLeave(object sender, EventArgs e)
        {
            buttonOK.BackColor = Color.Blue;
        }

        private void buttonOK_MouseDown(object sender, MouseEventArgs e)
        {
            buttonOK.BackColor = Color.Purple;
        }
    }
}
