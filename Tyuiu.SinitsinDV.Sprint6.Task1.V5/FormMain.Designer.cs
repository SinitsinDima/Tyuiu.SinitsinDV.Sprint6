using Tyuiu.SinitsinDV.Sprint6.Task1.V5.Lib;
namespace Tyuiu.SinitsinDV.Sprint6.Task1.V5
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
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            groupBoxResult = new GroupBox();
            textBoxRes = new TextBox();
            textBoxResult = new TextBox();
            groupBoxValue = new GroupBox();
            textBoxstop = new TextBox();
            textBoxstart = new TextBox();
            textBoxstopValue = new TextBox();
            textBoxstartValue = new TextBox();
            buttonOK = new Button();
            buttonQuestion = new Button();
            groupBoxTry = new GroupBox();
            groupBoxTask.SuspendLayout();
            groupBoxResult.SuspendLayout();
            groupBoxValue.SuspendLayout();
            groupBoxTry.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(0, 0);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(526, 251);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условия";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(18, 22);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(502, 223);
            textBoxTask.TabIndex = 1;
            textBoxTask.Text = "Протабулировать функцию на заданном диапозоне.\r\nПроизвести проверку деления на ноль.\r\nПри делении на ноль вернуть значение 0.\r\nЗначение округлить до двух знаков после запятой.";
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(textBoxRes);
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Location = new Point(532, 12);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(256, 426);
            groupBoxResult.TabIndex = 1;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод данных";
            // 
            // textBoxRes
            // 
            textBoxRes.Location = new Point(6, 24);
            textBoxRes.Multiline = true;
            textBoxRes.Name = "textBoxRes";
            textBoxRes.ReadOnly = true;
            textBoxRes.Size = new Size(100, 23);
            textBoxRes.TabIndex = 3;
            textBoxRes.Text = "Результат";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(6, 53);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(244, 367);
            textBoxResult.TabIndex = 2;
            // 
            // groupBoxValue
            // 
            groupBoxValue.Controls.Add(textBoxstop);
            groupBoxValue.Controls.Add(textBoxstart);
            groupBoxValue.Controls.Add(textBoxstopValue);
            groupBoxValue.Controls.Add(textBoxstartValue);
            groupBoxValue.Location = new Point(12, 328);
            groupBoxValue.Name = "groupBoxValue";
            groupBoxValue.Size = new Size(242, 104);
            groupBoxValue.TabIndex = 3;
            groupBoxValue.TabStop = false;
            groupBoxValue.Text = "Ввод данных ";
            // 
            // textBoxstop
            // 
            textBoxstop.Location = new Point(136, 22);
            textBoxstop.Multiline = true;
            textBoxstop.Name = "textBoxstop";
            textBoxstop.ReadOnly = true;
            textBoxstop.Size = new Size(100, 21);
            textBoxstop.TabIndex = 4;
            textBoxstop.Text = "Конец шага";
            // 
            // textBoxstart
            // 
            textBoxstart.Location = new Point(6, 22);
            textBoxstart.Multiline = true;
            textBoxstart.Name = "textBoxstart";
            textBoxstart.ReadOnly = true;
            textBoxstart.Size = new Size(100, 21);
            textBoxstart.TabIndex = 6;
            textBoxstart.Text = "Старт шага";
            // 
            // textBoxstopValue
            // 
            textBoxstopValue.Location = new Point(136, 49);
            textBoxstopValue.Name = "textBoxstopValue";
            textBoxstopValue.Size = new Size(100, 23);
            textBoxstopValue.TabIndex = 5;
            textBoxstopValue.KeyPress += textBoxstopValue_KeyPress;
            // 
            // textBoxstartValue
            // 
            textBoxstartValue.Location = new Point(6, 49);
            textBoxstartValue.Name = "textBoxstartValue";
            textBoxstartValue.Size = new Size(100, 23);
            textBoxstartValue.TabIndex = 4;
            
            textBoxstartValue.KeyPress += textBoxstartValue_KeyPress;
            // 
            // buttonOK
            // 
            buttonOK.BackColor = Color.Green;
            buttonOK.ForeColor = SystemColors.Desktop;
            buttonOK.Location = new Point(135, 18);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(106, 58);
            buttonOK.TabIndex = 4;
            buttonOK.Text = "Выполнить";
            buttonOK.UseVisualStyleBackColor = false;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonQuestion
            // 
            buttonQuestion.BackColor = Color.Cyan;
            buttonQuestion.Location = new Point(6, 18);
            buttonQuestion.Name = "buttonQuestion";
            buttonQuestion.Size = new Size(128, 48);
            buttonQuestion.TabIndex = 5;
            buttonQuestion.Text = "справка";
            buttonQuestion.UseVisualStyleBackColor = false;
            buttonQuestion.Click += buttonQuestion_Click;
            // 
            // groupBoxTry
            // 
            groupBoxTry.Controls.Add(buttonOK);
            groupBoxTry.Controls.Add(buttonQuestion);
            groupBoxTry.Location = new Point(273, 350);
            groupBoxTry.Name = "groupBoxTry";
            groupBoxTry.Size = new Size(247, 82);
            groupBoxTry.TabIndex = 6;
            groupBoxTry.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 451);
            Controls.Add(groupBoxTry);
            Controls.Add(groupBoxValue);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBoxTask);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 5 | Синицин Д.В";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            groupBoxValue.ResumeLayout(false);
            groupBoxValue.PerformLayout();
            groupBoxTry.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private GroupBox groupBoxResult;
        private TextBox textBoxResult;
        private GroupBox groupBoxValue;
        private TextBox textBoxstartValue;
        private TextBox textBoxstopValue;
        private TextBox textBoxstop;
        private TextBox textBoxstart;
        private Button buttonOK;
        private Button buttonQuestion;
        private TextBox textBoxRes;
        private GroupBox groupBoxTry;
    }
}
