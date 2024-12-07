namespace Tyuiu.SinitsinDV.Sprint6.Task4.V3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            groupBoxValue = new GroupBox();
            buttonSave = new Button();
            buttonOK = new Button();
            buttonFAQ = new Button();
            textBoxValueText = new TextBox();
            textBoxStopValue = new TextBox();
            textBoxStartValue = new TextBox();
            groupBoxResult = new GroupBox();
            textBoxResult = new TextBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxTask.SuspendLayout();
            groupBoxValue.SuspendLayout();
            groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(0, 3);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(485, 111);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(12, 22);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(467, 83);
            textBoxTask.TabIndex = 3;
            textBoxTask.Text = "Написать программу, которая выводит таблицу значений функции\r\n(произвести табулирование) f(x) на заданном диапазоне [-5; 5] с шагом 1.\r\nЗначения округлить до двух знаков после запятой.";
            // 
            // groupBoxValue
            // 
            groupBoxValue.Controls.Add(buttonSave);
            groupBoxValue.Controls.Add(buttonOK);
            groupBoxValue.Controls.Add(buttonFAQ);
            groupBoxValue.Controls.Add(textBoxValueText);
            groupBoxValue.Controls.Add(textBoxStopValue);
            groupBoxValue.Controls.Add(textBoxStartValue);
            groupBoxValue.Location = new Point(491, 12);
            groupBoxValue.Name = "groupBoxValue";
            groupBoxValue.Size = new Size(643, 102);
            groupBoxValue.TabIndex = 0;
            groupBoxValue.TabStop = false;
            groupBoxValue.Text = "Ввод данных";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(128, 128, 255);
            buttonSave.Location = new Point(378, 21);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(95, 51);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonOK
            // 
            buttonOK.BackColor = Color.FromArgb(0, 192, 0);
            buttonOK.Location = new Point(273, 23);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(99, 49);
            buttonOK.TabIndex = 3;
            buttonOK.Text = "Выполнить";
            buttonOK.UseVisualStyleBackColor = false;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonFAQ
            // 
            buttonFAQ.BackColor = Color.Cyan;
            buttonFAQ.Location = new Point(479, 18);
            buttonFAQ.Name = "buttonFAQ";
            buttonFAQ.Size = new Size(93, 59);
            buttonFAQ.TabIndex = 2;
            buttonFAQ.Text = "Справка";
            buttonFAQ.UseVisualStyleBackColor = false;
            buttonFAQ.Click += buttonFAQ_Click;
            // 
            // textBoxValueText
            // 
            textBoxValueText.Location = new Point(6, 22);
            textBoxValueText.Name = "textBoxValueText";
            textBoxValueText.ReadOnly = true;
            textBoxValueText.Size = new Size(248, 23);
            textBoxValueText.TabIndex = 2;
            textBoxValueText.Text = "Старт шага                        Конец шага";
            // 
            // textBoxStopValue
            // 
            textBoxStopValue.Location = new Point(142, 49);
            textBoxStopValue.Name = "textBoxStopValue";
            textBoxStopValue.Size = new Size(112, 23);
            textBoxStopValue.TabIndex = 1;
            // 
            // textBoxStartValue
            // 
            textBoxStartValue.Location = new Point(6, 49);
            textBoxStartValue.Name = "textBoxStartValue";
            textBoxStartValue.Size = new Size(114, 23);
            textBoxStartValue.TabIndex = 0;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Location = new Point(0, 120);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(268, 422);
            groupBoxResult.TabIndex = 1;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(6, 22);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(256, 394);
            textBoxResult.TabIndex = 2;
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(274, 131);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(860, 405);
            chartFunction.TabIndex = 0;
            chartFunction.Text = "chart1";
            title1.ForeColor = Color.FromArgb(192, 0, 192);
            title1.Name = "TitleSin";
            title1.Text = "График функции sin(x)";
            chartFunction.Titles.Add(title1);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 554);
            Controls.Add(chartFunction);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxValue);
            Controls.Add(groupBoxTask);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 4| Вариант 3| Синицин Д.В |";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxValue.ResumeLayout(false);
            groupBoxValue.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private GroupBox groupBoxValue;
        private TextBox textBoxTask;
        private GroupBox groupBoxResult;
        private TextBox textBoxResult;
        private Button buttonSave;
        private Button buttonOK;
        private Button buttonFAQ;
        private TextBox textBoxValueText;
        private TextBox textBoxStopValue;
        private TextBox textBoxStartValue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}
