namespace Tyuiu.SinitsinDV.Sprint6.Task3.V24
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
            groupBoxTask = new GroupBox();
            dataGridViewMatrix = new DataGridView();
            textBoxTask = new TextBox();
            groupBoxResult = new GroupBox();
            buttonHelp = new Button();
            buttonResult = new Button();
            textBoxResult = new TextBox();
            textBoxRes = new TextBox();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            groupBoxResult.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(dataGridViewMatrix);
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(737, 413);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix.Location = new Point(389, 19);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.RowHeadersVisible = false;
            dataGridViewMatrix.Size = new Size(342, 388);
            dataGridViewMatrix.TabIndex = 0;
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(3, 19);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(380, 388);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(buttonHelp);
            groupBoxResult.Controls.Add(buttonResult);
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Controls.Add(textBoxRes);
            groupBoxResult.Location = new Point(755, 12);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(244, 426);
            groupBoxResult.TabIndex = 1;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод данных";
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(6, 357);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(112, 50);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonResult
            // 
            buttonResult.Location = new Point(124, 336);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(114, 84);
            buttonResult.TabIndex = 2;
            buttonResult.Text = "Выполнить";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(6, 65);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(232, 23);
            textBoxResult.TabIndex = 1;
            // 
            // textBoxRes
            // 
            textBoxRes.Location = new Point(6, 22);
            textBoxRes.Name = "textBoxRes";
            textBoxRes.ReadOnly = true;
            textBoxRes.Size = new Size(100, 23);
            textBoxRes.TabIndex = 0;
            textBoxRes.Text = "Результат";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 450);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxTask);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 24 | Синицин Д.В.";
            Load += FormMain_Load;
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private DataGridView dataGridViewMatrix;
        private GroupBox groupBoxResult;
        private TextBox textBoxTask;
        private TextBox textBoxResult;
        private TextBox textBoxRes;
        private Button buttonHelp;
        private Button buttonResult;
    }
}
