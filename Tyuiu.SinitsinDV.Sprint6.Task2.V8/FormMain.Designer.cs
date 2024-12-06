namespace Tyuiu.SinitsinDV.Sprint6.Task2.V8
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
            groupBoxValue = new GroupBox();
            textBoxstopValue = new TextBox();
            textBoxstartValue = new TextBox();
            groupBoxButtons = new GroupBox();
            buttonHelp = new Button();
            buttonOK = new Button();
            groupBoxResult = new GroupBox();
            chartGraf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewTasks = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            function = new DataGridViewTextBoxColumn();
            groupBoxTask.SuspendLayout();
            groupBoxValue.SuspendLayout();
            groupBoxButtons.SuspendLayout();
            groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartGraf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(560, 333);
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
            textBoxTask.Size = new Size(551, 308);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // groupBoxValue
            // 
            groupBoxValue.Controls.Add(textBoxstopValue);
            groupBoxValue.Controls.Add(textBoxstartValue);
            groupBoxValue.Location = new Point(12, 351);
            groupBoxValue.Name = "groupBoxValue";
            groupBoxValue.Size = new Size(306, 125);
            groupBoxValue.TabIndex = 1;
            groupBoxValue.TabStop = false;
            groupBoxValue.Text = "Вывод данных";
            // 
            // textBoxstopValue
            // 
            textBoxstopValue.Location = new Point(171, 66);
            textBoxstopValue.Name = "textBoxstopValue";
            textBoxstopValue.Size = new Size(129, 23);
            textBoxstopValue.TabIndex = 1;
            // 
            // textBoxstartValue
            // 
            textBoxstartValue.Location = new Point(6, 66);
            textBoxstartValue.Name = "textBoxstartValue";
            textBoxstartValue.Size = new Size(127, 23);
            textBoxstartValue.TabIndex = 0;
            // 
            // groupBoxButtons
            // 
            groupBoxButtons.Controls.Add(buttonHelp);
            groupBoxButtons.Controls.Add(buttonOK);
            groupBoxButtons.Location = new Point(324, 351);
            groupBoxButtons.Name = "groupBoxButtons";
            groupBoxButtons.Size = new Size(248, 125);
            groupBoxButtons.TabIndex = 2;
            groupBoxButtons.TabStop = false;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.FromArgb(0, 192, 0);
            buttonHelp.Location = new Point(6, 31);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(75, 68);
            buttonHelp.TabIndex = 1;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonOK
            // 
            buttonOK.BackColor = Color.Blue;
            buttonOK.Location = new Point(82, 31);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(160, 68);
            buttonOK.TabIndex = 0;
            buttonOK.Text = "Выполнить";
            buttonOK.UseVisualStyleBackColor = false;
            buttonOK.Click += buttonOK_Click;
            buttonOK.MouseDown += buttonOK_MouseDown;
            buttonOK.MouseEnter += buttonOK_MouseEnter;
            buttonOK.MouseLeave += buttonOK_MouseLeave;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(chartGraf);
            groupBoxResult.Controls.Add(dataGridViewTasks);
            groupBoxResult.Location = new Point(578, 31);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(578, 445);
            groupBoxResult.TabIndex = 2;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод данных";
            // 
            // chartGraf
            // 
            chartArea1.Name = "ChartArea1";
            chartGraf.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartGraf.Legends.Add(legend1);
            chartGraf.Location = new Point(226, 105);
            chartGraf.Name = "chartGraf";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartGraf.Series.Add(series1);
            chartGraf.Size = new Size(346, 209);
            chartGraf.TabIndex = 1;
            chartGraf.Text = "chart1";
            // 
            // dataGridViewTasks
            // 
            dataGridViewTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTasks.Columns.AddRange(new DataGridViewColumn[] { X, function });
            dataGridViewTasks.Location = new Point(3, 19);
            dataGridViewTasks.Name = "dataGridViewTasks";
            dataGridViewTasks.RowHeadersVisible = false;
            dataGridViewTasks.Size = new Size(208, 420);
            dataGridViewTasks.TabIndex = 0;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.ReadOnly = true;
            // 
            // function
            // 
            function.HeaderText = "F(x)";
            function.Name = "function";
            function.ReadOnly = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 488);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxButtons);
            Controls.Add(groupBoxValue);
            Controls.Add(groupBoxTask);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 8 | Синицин Д.В.";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxValue.ResumeLayout(false);
            groupBoxValue.PerformLayout();
            groupBoxButtons.ResumeLayout(false);
            groupBoxResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartGraf).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private GroupBox groupBoxValue;
        private TextBox textBoxTask;
        private TextBox textBoxstopValue;
        private TextBox textBoxstartValue;
        private GroupBox groupBoxButtons;
        private Button buttonHelp;
        private Button buttonOK;
        private GroupBox groupBoxResult;
        private DataGridView dataGridViewTasks;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraf;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn function;
    }
}
