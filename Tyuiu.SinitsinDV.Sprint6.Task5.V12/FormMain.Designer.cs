namespace Tyuiu.SinitsinDV.Sprint6.Task5.V12
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            dataGridViewResult = new DataGridView();
            groupBoxResult = new GroupBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonOK = new Button();
            buttonFile = new Button();
            buttonHelp = new Button();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(0, 0);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(515, 91);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(3, 19);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(506, 65);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.Location = new Point(6, 22);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.Size = new Size(174, 342);
            dataGridViewResult.TabIndex = 1;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(dataGridViewResult);
            groupBoxResult.Location = new Point(0, 97);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(186, 370);
            groupBoxResult.TabIndex = 2;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод данных";
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(192, 119);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(668, 342);
            chartFunction.TabIndex = 3;
            chartFunction.Text = "chart1";
            // 
            // buttonOK
            // 
            buttonOK.BackColor = Color.FromArgb(0, 192, 0);
            buttonOK.Location = new Point(521, 30);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(92, 48);
            buttonOK.TabIndex = 4;
            buttonOK.Text = "Выполнить";
            buttonOK.UseVisualStyleBackColor = false;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonFile
            // 
            buttonFile.BackColor = Color.Cyan;
            buttonFile.Location = new Point(629, 30);
            buttonFile.Name = "buttonFile";
            buttonFile.Size = new Size(111, 48);
            buttonFile.TabIndex = 5;
            buttonFile.Text = "Открыть файл";
            buttonFile.UseVisualStyleBackColor = false;
            buttonFile.Click += buttonFile_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.FromArgb(192, 0, 192);
            buttonHelp.Location = new Point(764, 24);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(75, 60);
            buttonHelp.TabIndex = 6;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 470);
            Controls.Add(buttonHelp);
            Controls.Add(buttonFile);
            Controls.Add(buttonOK);
            Controls.Add(chartFunction);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxTask);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 12 | Синицин Д.В.";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            groupBoxResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private DataGridView dataGridViewResult;
        private GroupBox groupBoxResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private Button buttonOK;
        private Button buttonFile;
        private Button buttonHelp;
        private TextBox textBoxTask;
    }
}
