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

                this.chartGraf.Titles.Add("������ ������� f(x)");

                this.chartGraf.ChartAreas[0].AxisX.Title = "��� X";
                this.chartGraf.ChartAreas[0].AxisY.Title = "��� Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewTasks.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartGraf.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }



            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 1 �������� ������� ������ ����-24-1 ������� ������� ������������", "���������");
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
