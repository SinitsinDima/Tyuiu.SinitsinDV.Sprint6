namespace Tyuiu.SinitsinDV.Sprint6.Task7.V28
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            buttonClose_SDV = new Button();
            pictureBoxMe_SDV = new PictureBox();
            labelInfo_SDV = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMe_SDV).BeginInit();
            SuspendLayout();
            // 
            // buttonClose_SDV
            // 
            buttonClose_SDV.Location = new Point(633, 330);
            buttonClose_SDV.Name = "buttonClose_SDV";
            buttonClose_SDV.Size = new Size(92, 40);
            buttonClose_SDV.TabIndex = 0;
            buttonClose_SDV.Text = "ОК";
            buttonClose_SDV.UseVisualStyleBackColor = true;
            buttonClose_SDV.Click += button1_Click;
            // 
            // pictureBoxMe_SDV
            // 
            pictureBoxMe_SDV.Image = (Image)resources.GetObject("pictureBoxMe_SDV.Image");
            pictureBoxMe_SDV.Location = new Point(24, 12);
            pictureBoxMe_SDV.Name = "pictureBoxMe_SDV";
            pictureBoxMe_SDV.Size = new Size(202, 359);
            pictureBoxMe_SDV.TabIndex = 1;
            pictureBoxMe_SDV.TabStop = false;
            // 
            // labelInfo_SDV
            // 
            labelInfo_SDV.AutoSize = true;
            labelInfo_SDV.BackColor = Color.Transparent;
            labelInfo_SDV.FlatStyle = FlatStyle.Flat;
            labelInfo_SDV.Location = new Point(259, 36);
            labelInfo_SDV.Name = "labelInfo_SDV";
            labelInfo_SDV.Size = new Size(279, 165);
            labelInfo_SDV.TabIndex = 3;
            labelInfo_SDV.Text = resources.GetString("labelInfo_SDV.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 382);
            Controls.Add(labelInfo_SDV);
            Controls.Add(pictureBoxMe_SDV);
            Controls.Add(buttonClose_SDV);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxMe_SDV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClose_SDV;
        private PictureBox pictureBoxMe_SDV;
        private Label labelInfo_SDV;
    }
}