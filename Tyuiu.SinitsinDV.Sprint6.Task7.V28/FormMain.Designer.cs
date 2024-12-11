namespace Tyuiu.SinitsinDV.Sprint6.Task7.V28
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelone_SDV = new Panel();
            buttonHelp_SDV = new Button();
            buttonSave_SDV = new Button();
            buttonDone_SDV = new Button();
            buttonOpen_SDV = new Button();
            splitter3 = new Splitter();
            panel2 = new Panel();
            groupBoxTask_SDV = new GroupBox();
            textBoxTask_SDV = new TextBox();
            panelthree_SDV = new Panel();
            groupBoxInPutFile_SDV = new GroupBox();
            dataGridViewInPutFile_SDV = new DataGridView();
            panelfour_SDV = new Panel();
            groupBoxResult_SDV = new GroupBox();
            dataGridViewResult_SDV = new DataGridView();
            splitter1 = new Splitter();
            openFileDialogTask_SDV = new OpenFileDialog();
            toolTip_SDV = new ToolTip(components);
            saveFileDialogTask_SDV = new SaveFileDialog();
            panelone_SDV.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxTask_SDV.SuspendLayout();
            panelthree_SDV.SuspendLayout();
            groupBoxInPutFile_SDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPutFile_SDV).BeginInit();
            panelfour_SDV.SuspendLayout();
            groupBoxResult_SDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_SDV).BeginInit();
            SuspendLayout();
            // 
            // panelone_SDV
            // 
            panelone_SDV.Controls.Add(buttonHelp_SDV);
            panelone_SDV.Controls.Add(buttonSave_SDV);
            panelone_SDV.Controls.Add(buttonDone_SDV);
            panelone_SDV.Controls.Add(buttonOpen_SDV);
            panelone_SDV.Controls.Add(splitter3);
            panelone_SDV.Dock = DockStyle.Top;
            panelone_SDV.Location = new Point(0, 0);
            panelone_SDV.Name = "panelone_SDV";
            panelone_SDV.Size = new Size(1052, 74);
            panelone_SDV.TabIndex = 0;
            // 
            // buttonHelp_SDV
            // 
            buttonHelp_SDV.Image = (Image)resources.GetObject("buttonHelp_SDV.Image");
            buttonHelp_SDV.Location = new Point(990, 12);
            buttonHelp_SDV.Name = "buttonHelp_SDV";
            buttonHelp_SDV.Size = new Size(50, 50);
            buttonHelp_SDV.TabIndex = 4;
            toolTip_SDV.SetToolTip(buttonHelp_SDV, "О программе");
            buttonHelp_SDV.UseVisualStyleBackColor = true;
            buttonHelp_SDV.Click += buttonHelp_SDV_Click;
            // 
            // buttonSave_SDV
            // 
            buttonSave_SDV.FlatStyle = FlatStyle.Flat;
            buttonSave_SDV.Image = (Image)resources.GetObject("buttonSave_SDV.Image");
            buttonSave_SDV.Location = new Point(196, 26);
            buttonSave_SDV.Name = "buttonSave_SDV";
            buttonSave_SDV.Size = new Size(53, 38);
            buttonSave_SDV.TabIndex = 3;
            toolTip_SDV.SetToolTip(buttonSave_SDV, "Сохранить файл");
            buttonSave_SDV.UseVisualStyleBackColor = true;
            buttonSave_SDV.Click += buttonSave_SDV_Click;
            // 
            // buttonDone_SDV
            // 
            buttonDone_SDV.FlatStyle = FlatStyle.Flat;
            buttonDone_SDV.Image = (Image)resources.GetObject("buttonDone_SDV.Image");
            buttonDone_SDV.Location = new Point(110, 28);
            buttonDone_SDV.Name = "buttonDone_SDV";
            buttonDone_SDV.Size = new Size(54, 36);
            buttonDone_SDV.TabIndex = 2;
            toolTip_SDV.SetToolTip(buttonDone_SDV, "Изменить в седьмой строке числа не равные 13 на 0");
            buttonDone_SDV.UseVisualStyleBackColor = true;
            buttonDone_SDV.Click += buttonDone_SDV_Click;
            // 
            // buttonOpen_SDV
            // 
            buttonOpen_SDV.FlatStyle = FlatStyle.Flat;
            buttonOpen_SDV.Image = (Image)resources.GetObject("buttonOpen_SDV.Image");
            buttonOpen_SDV.Location = new Point(27, 28);
            buttonOpen_SDV.Name = "buttonOpen_SDV";
            buttonOpen_SDV.Size = new Size(51, 36);
            buttonOpen_SDV.TabIndex = 1;
            toolTip_SDV.SetToolTip(buttonOpen_SDV, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpen_SDV.UseVisualStyleBackColor = true;
            buttonOpen_SDV.Click += buttonOpen_SDV_Click;
            // 
            // splitter3
            // 
            splitter3.Location = new Point(0, 0);
            splitter3.Name = "splitter3";
            splitter3.Size = new Size(3, 74);
            splitter3.TabIndex = 0;
            splitter3.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxTask_SDV);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(1052, 100);
            panel2.TabIndex = 1;
            // 
            // groupBoxTask_SDV
            // 
            groupBoxTask_SDV.Controls.Add(textBoxTask_SDV);
            groupBoxTask_SDV.Location = new Point(0, 0);
            groupBoxTask_SDV.Name = "groupBoxTask_SDV";
            groupBoxTask_SDV.Size = new Size(1049, 100);
            groupBoxTask_SDV.TabIndex = 0;
            groupBoxTask_SDV.TabStop = false;
            groupBoxTask_SDV.Text = "Условие";
            // 
            // textBoxTask_SDV
            // 
            textBoxTask_SDV.Location = new Point(3, 19);
            textBoxTask_SDV.Multiline = true;
            textBoxTask_SDV.Name = "textBoxTask_SDV";
            textBoxTask_SDV.ReadOnly = true;
            textBoxTask_SDV.Size = new Size(1046, 75);
            textBoxTask_SDV.TabIndex = 0;
            textBoxTask_SDV.Text = resources.GetString("textBoxTask_SDV.Text");
            // 
            // panelthree_SDV
            // 
            panelthree_SDV.Controls.Add(groupBoxInPutFile_SDV);
            panelthree_SDV.Dock = DockStyle.Left;
            panelthree_SDV.Location = new Point(0, 174);
            panelthree_SDV.Name = "panelthree_SDV";
            panelthree_SDV.Size = new Size(496, 372);
            panelthree_SDV.TabIndex = 0;
            // 
            // groupBoxInPutFile_SDV
            // 
            groupBoxInPutFile_SDV.Controls.Add(dataGridViewInPutFile_SDV);
            groupBoxInPutFile_SDV.Dock = DockStyle.Left;
            groupBoxInPutFile_SDV.Location = new Point(0, 0);
            groupBoxInPutFile_SDV.Name = "groupBoxInPutFile_SDV";
            groupBoxInPutFile_SDV.Size = new Size(493, 372);
            groupBoxInPutFile_SDV.TabIndex = 0;
            groupBoxInPutFile_SDV.TabStop = false;
            groupBoxInPutFile_SDV.Text = "Ввод";
            // 
            // dataGridViewInPutFile_SDV
            // 
            dataGridViewInPutFile_SDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInPutFile_SDV.Location = new Point(3, 19);
            dataGridViewInPutFile_SDV.Name = "dataGridViewInPutFile_SDV";
            dataGridViewInPutFile_SDV.RowHeadersVisible = false;
            dataGridViewInPutFile_SDV.Size = new Size(484, 349);
            dataGridViewInPutFile_SDV.TabIndex = 0;
            // 
            // panelfour_SDV
            // 
            panelfour_SDV.Controls.Add(groupBoxResult_SDV);
            panelfour_SDV.Dock = DockStyle.Right;
            panelfour_SDV.Location = new Point(502, 174);
            panelfour_SDV.Name = "panelfour_SDV";
            panelfour_SDV.Size = new Size(550, 372);
            panelfour_SDV.TabIndex = 0;
            // 
            // groupBoxResult_SDV
            // 
            groupBoxResult_SDV.Controls.Add(dataGridViewResult_SDV);
            groupBoxResult_SDV.Dock = DockStyle.Right;
            groupBoxResult_SDV.Location = new Point(3, 0);
            groupBoxResult_SDV.Name = "groupBoxResult_SDV";
            groupBoxResult_SDV.Size = new Size(547, 372);
            groupBoxResult_SDV.TabIndex = 0;
            groupBoxResult_SDV.TabStop = false;
            groupBoxResult_SDV.Text = "Вывод";
            // 
            // dataGridViewResult_SDV
            // 
            dataGridViewResult_SDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_SDV.Dock = DockStyle.Right;
            dataGridViewResult_SDV.Location = new Point(6, 19);
            dataGridViewResult_SDV.Name = "dataGridViewResult_SDV";
            dataGridViewResult_SDV.RowHeadersVisible = false;
            dataGridViewResult_SDV.Size = new Size(538, 350);
            dataGridViewResult_SDV.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(496, 174);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 372);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // openFileDialogTask_SDV
            // 
            openFileDialogTask_SDV.FileName = "openFileDialog1";
            // 
            // toolTip_SDV
            // 
            toolTip_SDV.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 546);
            Controls.Add(splitter1);
            Controls.Add(panelfour_SDV);
            Controls.Add(panelthree_SDV);
            Controls.Add(panel2);
            Controls.Add(panelone_SDV);
            MinimumSize = new Size(1068, 573);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 28 | Синицин Д.В.";
            panelone_SDV.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBoxTask_SDV.ResumeLayout(false);
            groupBoxTask_SDV.PerformLayout();
            panelthree_SDV.ResumeLayout(false);
            groupBoxInPutFile_SDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPutFile_SDV).EndInit();
            panelfour_SDV.ResumeLayout(false);
            groupBoxResult_SDV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_SDV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelone_SDV;
        private Splitter splitter3;
        private Panel panel2;
        private Panel panelthree_SDV;
        private Panel panelfour_SDV;
        private GroupBox groupBoxInPutFile_SDV;
        private GroupBox groupBoxResult_SDV;
        private DataGridView dataGridViewInPutFile_SDV;
        private DataGridView dataGridViewResult_SDV;
        private GroupBox groupBoxTask_SDV;
        private Button buttonOpen_SDV;
        private TextBox textBoxTask_SDV;
        private Button buttonHelp_SDV;
        private Button buttonSave_SDV;
        private Button buttonDone_SDV;
        private Splitter splitter1;
        private ToolTip toolTip_SDV;
        private OpenFileDialog openFileDialogTask_SDV;
        private SaveFileDialog saveFileDialogTask_SDV;
    }
}
