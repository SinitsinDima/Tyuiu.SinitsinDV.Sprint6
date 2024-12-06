using Tyuiu.SinitsinDV.Sprint6.Task3.V24.Lib;
namespace Tyuiu.SinitsinDV.Sprint6.Task3.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] matrix = new int[5, 5]
        {
                {-17, -6, 10, 5, 3},
                {-10, -14, 10, -7, -3},
                {-19, 9, 8, -17, -9},
                {-19, -5, -9, -18, 14},
                {17, 12, 11, 12, 2}
        };

        private void buttonResult_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = Convert.ToString(ds.Calculate(matrix));
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int colums = matrix.Length / rows;

            dataGridViewMatrix.ColumnCount = colums;
            dataGridViewMatrix.RowCount = rows;

            for (int i = 0; i < colums; i++)
            {
                dataGridViewMatrix.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }

            }


        }

        

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ПКТб-24-1 Синицин Дмитрий Владимирович", "Сообщение");
        }
    }
}
