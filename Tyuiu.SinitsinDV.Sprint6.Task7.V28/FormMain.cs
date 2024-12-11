using System.Windows.Forms;
using Tyuiu.SinitsinDV.Sprint6.Task7.V28.Lib;
namespace Tyuiu.SinitsinDV.Sprint6.Task7.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_SDV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogTask_SDV.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";

            buttonOpen_SDV.FlatAppearance.BorderSize = 0;
            buttonOpen_SDV.FlatStyle = FlatStyle.Flat;
            buttonSave_SDV.FlatAppearance.BorderSize = 0;
            buttonSave_SDV.FlatStyle = FlatStyle.Flat;
            buttonDone_SDV.FlatAppearance.BorderSize = 0;
            buttonDone_SDV.FlatStyle = FlatStyle.Flat;
            buttonHelp_SDV.FlatAppearance.BorderSize = 0;
            buttonHelp_SDV.FlatStyle = FlatStyle.Flat;
            

        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public int[,] LoadFromFileData(string path)
        {
            string fileData = File.ReadAllText(path);


            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_i = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_i[j]);
                }
            }
            return arrayValues;

        }
        private void buttonOpen_SDV_Click(object sender, EventArgs e)
        {

            openFileDialogTask_SDV.ShowDialog();
            openFilePath = openFileDialogTask_SDV.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);


            dataGridViewInPutFile_SDV.ColumnCount = columns;
            dataGridViewInPutFile_SDV.RowCount = rows;
            dataGridViewResult_SDV.ColumnCount = columns;
            dataGridViewResult_SDV.RowCount = rows;


            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_SDV.Columns[i].Width = 25;
                dataGridViewInPutFile_SDV.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInPutFile_SDV.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_SDV.Enabled = true;
            

        }

        private void buttonDone_SDV_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_SDV.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            buttonSave_SDV.Enabled = true;
        }

        private void buttonSave_SDV_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_SDV.FileName = "OutPutFileTask7V28.csv";
            saveFileDialogTask_SDV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask_SDV.ShowDialog();

            string path = saveFileDialogTask_SDV.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewResult_SDV.RowCount;
            int columns = dataGridViewResult_SDV.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewResult_SDV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewResult_SDV.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonHelp_SDV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}



       