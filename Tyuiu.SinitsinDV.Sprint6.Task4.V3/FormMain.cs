using Tyuiu.SinitsinDV.Sprint6.Task4.V3.Lib;
namespace Tyuiu.SinitsinDV.Sprint6.Task4.V3
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
                int startStep = Convert.ToInt32(textBoxStartValue.Text);
                int stopStep = Convert.ToInt32(textBoxStopValue.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;


                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction.ChartAreas[0].AxisX.Title = "��� X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "��� Y";

                textBoxResult.Text = "";

                chartFunction.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;

                }



            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void buttonFAQ_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 3 �������� ������� ������ ����-24-1 ������� ������� ������������", "���������");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxResult.Text);

                DialogResult dialogResult = MessageBox.Show("����" + path + "�������� �������:\n ������� ��� � ��������?", "���������", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("���� ��� ���������� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
