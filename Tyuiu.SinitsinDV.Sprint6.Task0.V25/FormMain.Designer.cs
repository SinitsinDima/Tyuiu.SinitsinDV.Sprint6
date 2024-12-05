using Tyuiu.SinitsinDV.Sprint6.Task0.V25.Lib;
namespace Tyuiu.SinitsinDV.Sprint6.Task0.V25
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
            groupBoxValue = new GroupBox();
            textBoxVarX = new TextBox();
            groupBoxTask = new GroupBox();
            textBoxCondition = new TextBox();
            pictureBoxPicture = new PictureBox();
            buttonOk = new Button();
            groupBoxResult = new GroupBox();
            textBoxResult = new TextBox();
            GroupBoxCalculate = new GroupBox();
            ButtonHelp = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBoxValue.SuspendLayout();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPicture).BeginInit();
            groupBoxResult.SuspendLayout();
            GroupBoxCalculate.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxValue
            // 
            groupBoxValue.Controls.Add(textBoxVarX);
            groupBoxValue.Location = new Point(12, 307);
            groupBoxValue.Name = "groupBoxValue";
            groupBoxValue.Size = new Size(501, 112);
            groupBoxValue.TabIndex = 0;
            groupBoxValue.TabStop = false;
            groupBoxValue.Text = "Ввод данных";
            // 
            // textBoxVarX
            // 
            textBoxVarX.Location = new Point(12, 34);
            textBoxVarX.Name = "textBoxVarX";
            textBoxVarX.Size = new Size(100, 23);
            textBoxVarX.TabIndex = 3;
            textBoxVarX.TextChanged += textBoxVarX_TextChanged;
            textBoxVarX.KeyPress += textBoxVarX_KeyPress;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxCondition);
            groupBoxTask.Controls.Add(pictureBoxPicture);
            groupBoxTask.Location = new Point(12, 13);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(776, 219);
            groupBoxTask.TabIndex = 1;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxCondition
            // 
            textBoxCondition.Location = new Point(6, 22);
            textBoxCondition.Multiline = true;
            textBoxCondition.Name = "textBoxCondition";
            textBoxCondition.ReadOnly = true;
            textBoxCondition.Size = new Size(570, 191);
            textBoxCondition.TabIndex = 1;
            textBoxCondition.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxPicture
            // 
            pictureBoxPicture.Image = (Image)resources.GetObject("pictureBoxPicture.Image");
            pictureBoxPicture.Location = new Point(605, 22);
            pictureBoxPicture.Name = "pictureBoxPicture";
            pictureBoxPicture.Size = new Size(154, 69);
            pictureBoxPicture.TabIndex = 0;
            pictureBoxPicture.TabStop = false;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(100, 22);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(94, 23);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "Выполнить";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Location = new Point(560, 289);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(228, 75);
            groupBoxResult.TabIndex = 2;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Результат";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(45, 31);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(129, 23);
            textBoxResult.TabIndex = 0;
            // 
            // GroupBoxCalculate
            // 
            GroupBoxCalculate.Controls.Add(ButtonHelp);
            GroupBoxCalculate.Controls.Add(buttonOk);
            GroupBoxCalculate.Location = new Point(571, 385);
            GroupBoxCalculate.Name = "GroupBoxCalculate";
            GroupBoxCalculate.Size = new Size(200, 57);
            GroupBoxCalculate.TabIndex = 0;
            GroupBoxCalculate.TabStop = false;
            GroupBoxCalculate.Text = "Решить";
            // 
            // ButtonHelp
            // 
            ButtonHelp.FlatStyle = FlatStyle.Flat;
            ButtonHelp.Location = new Point(6, 22);
            ButtonHelp.Name = "ButtonHelp";
            ButtonHelp.Size = new Size(75, 23);
            ButtonHelp.TabIndex = 1;
            ButtonHelp.Text = "?";
            ButtonHelp.UseVisualStyleBackColor = true;
            ButtonHelp.Click += buttonQuestion_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 463);
            Controls.Add(GroupBoxCalculate);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxTask);
            Controls.Add(groupBoxValue);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 25 | Синицин Д.В. |";
            groupBoxValue.ResumeLayout(false);
            groupBoxValue.PerformLayout();
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPicture).EndInit();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            GroupBoxCalculate.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxValue;
        private GroupBox groupBoxTask;
        private PictureBox pictureBoxPicture;
        private Button buttonOk;
        private GroupBox groupBoxResult;
        private TextBox textBoxVarX;
        private GroupBox GroupBoxCalculate;
        private TextBox textBoxCondition;
        private Button ButtonHelp;
        private TextBox textBoxResult;
        private ContextMenuStrip contextMenuStrip1;
    }
}
