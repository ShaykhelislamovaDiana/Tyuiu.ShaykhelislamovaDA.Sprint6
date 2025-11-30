namespace Tyuiu.ShaykhelislamovaDA.Sprint6.Task0.V2
{
    partial class FormMain_SDA
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_SDA));
            this.groupBoxCondition_SDA = new System.Windows.Forms.GroupBox();
            this.pictureBoxEquation_SDA = new System.Windows.Forms.PictureBox();
            this.textBoxCondition_SDA = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_SDA = new System.Windows.Forms.GroupBox();
            this.textBoxInPut_SDA = new System.Windows.Forms.TextBox();
            this.labelX_SDA = new System.Windows.Forms.Label();
            this.groupBoxOutPut_SDA = new System.Windows.Forms.GroupBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelResult_SDA = new System.Windows.Forms.Label();
            this.buttonHelp_SDA = new System.Windows.Forms.Button();
            this.buttonDone_SDA = new System.Windows.Forms.Button();
            this.groupBoxCondition_SDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEquation_SDA)).BeginInit();
            this.groupBoxInPut_SDA.SuspendLayout();
            this.groupBoxOutPut_SDA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_SDA
            // 
            this.groupBoxCondition_SDA.Controls.Add(this.pictureBoxEquation_SDA);
            this.groupBoxCondition_SDA.Controls.Add(this.textBoxCondition_SDA);
            this.groupBoxCondition_SDA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition_SDA.Name = "groupBoxCondition_SDA";
            this.groupBoxCondition_SDA.Size = new System.Drawing.Size(775, 162);
            this.groupBoxCondition_SDA.TabIndex = 0;
            this.groupBoxCondition_SDA.TabStop = false;
            this.groupBoxCondition_SDA.Text = "Условие";
            // 
            // pictureBoxEquation_SDA
            // 
            this.pictureBoxEquation_SDA.Image = Image.FromFile(@"C:\DataSprint5\unnamed.png");
            this.pictureBoxEquation_SDA.Location = new System.Drawing.Point(483, 26);
            this.pictureBoxEquation_SDA.Name = "pictureBoxEquation_SDA";
            this.pictureBoxEquation_SDA.Size = new System.Drawing.Size(239, 116);
            this.pictureBoxEquation_SDA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEquation_SDA.TabIndex = 1;
            this.pictureBoxEquation_SDA.TabStop = false;
            // 
            // textBoxCondition_SDA
            // 
            this.textBoxCondition_SDA.Location = new System.Drawing.Point(7, 26);
            this.textBoxCondition_SDA.Multiline = true;
            this.textBoxCondition_SDA.Name = "textBoxCondition_SDA";
            this.textBoxCondition_SDA.ReadOnly = true;
            this.textBoxCondition_SDA.Size = new System.Drawing.Size(408, 130);
            this.textBoxCondition_SDA.TabIndex = 0;
            this.textBoxCondition_SDA.Text = "Дано выражение вычислить его значение при x = 3.\r\nОкруглить до трёх знаков после " +
    "запятой.";
            // 
            // groupBoxInPut_SDA
            // 
            this.groupBoxInPut_SDA.Controls.Add(this.textBoxInPut_SDA);
            this.groupBoxInPut_SDA.Controls.Add(this.labelX_SDA);
            this.groupBoxInPut_SDA.Location = new System.Drawing.Point(12, 198);
            this.groupBoxInPut_SDA.Name = "groupBoxInPut_SDA";
            this.groupBoxInPut_SDA.Size = new System.Drawing.Size(484, 159);
            this.groupBoxInPut_SDA.TabIndex = 1;
            this.groupBoxInPut_SDA.TabStop = false;
            this.groupBoxInPut_SDA.Text = "Ввод данных";
            // 
            // textBoxInPut_SDA
            // 
            this.textBoxInPut_SDA.Location = new System.Drawing.Point(12, 74);
            this.textBoxInPut_SDA.Name = "textBoxInPut_SDA";
            this.textBoxInPut_SDA.Size = new System.Drawing.Size(119, 26);
            this.textBoxInPut_SDA.TabIndex = 1;
            this.textBoxInPut_SDA.TextChanged += new System.EventHandler(this.textBoxInPut_SDA_TextChanged);
            this.textBoxInPut_SDA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInPut_SDA_KeyPress);
            // 
            // labelX_SDA
            // 
            this.labelX_SDA.AutoSize = true;
            this.labelX_SDA.Location = new System.Drawing.Point(8, 40);
            this.labelX_SDA.Name = "labelX_SDA";
            this.labelX_SDA.Size = new System.Drawing.Size(123, 20);
            this.labelX_SDA.TabIndex = 0;
            this.labelX_SDA.Text = "Переменная Х:";
            // 
            // groupBoxOutPut_SDA
            // 
            this.groupBoxOutPut_SDA.Controls.Add(this.textBoxResult);
            this.groupBoxOutPut_SDA.Controls.Add(this.labelResult_SDA);
            this.groupBoxOutPut_SDA.Location = new System.Drawing.Point(517, 207);
            this.groupBoxOutPut_SDA.Name = "groupBoxOutPut_SDA";
            this.groupBoxOutPut_SDA.Size = new System.Drawing.Size(271, 150);
            this.groupBoxOutPut_SDA.TabIndex = 2;
            this.groupBoxOutPut_SDA.TabStop = false;
            this.groupBoxOutPut_SDA.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(11, 64);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(89, 26);
            this.textBoxResult.TabIndex = 1;
            // 
            // labelResult_SDA
            // 
            this.labelResult_SDA.AutoSize = true;
            this.labelResult_SDA.Location = new System.Drawing.Point(7, 31);
            this.labelResult_SDA.Name = "labelResult_SDA";
            this.labelResult_SDA.Size = new System.Drawing.Size(93, 20);
            this.labelResult_SDA.TabIndex = 0;
            this.labelResult_SDA.Text = "Результат:";
            // 
            // buttonHelp_SDA
            // 
            this.buttonHelp_SDA.Location = new System.Drawing.Point(517, 377);
            this.buttonHelp_SDA.Name = "buttonHelp_SDA";
            this.buttonHelp_SDA.Size = new System.Drawing.Size(67, 61);
            this.buttonHelp_SDA.TabIndex = 3;
            this.buttonHelp_SDA.Text = "?";
            this.buttonHelp_SDA.UseVisualStyleBackColor = true;
            this.buttonHelp_SDA.Click += new System.EventHandler(this.buttonHelp_SDA_Click);
            // 
            // buttonDone_SDA
            // 
            this.buttonDone_SDA.Location = new System.Drawing.Point(604, 377);
            this.buttonDone_SDA.Name = "buttonDone_SDA";
            this.buttonDone_SDA.Size = new System.Drawing.Size(184, 61);
            this.buttonDone_SDA.TabIndex = 4;
            this.buttonDone_SDA.Text = "Выполнить";
            this.buttonDone_SDA.UseVisualStyleBackColor = true;
            this.buttonDone_SDA.Click += new System.EventHandler(this.buttonDone_SDA_Click);
            // 
            // FormMain_SDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDone_SDA);
            this.Controls.Add(this.buttonHelp_SDA);
            this.Controls.Add(this.groupBoxOutPut_SDA);
            this.Controls.Add(this.groupBoxInPut_SDA);
            this.Controls.Add(this.groupBoxCondition_SDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_SDA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 2 | Тодиков Д.Э";
            this.groupBoxCondition_SDA.ResumeLayout(false);
            this.groupBoxCondition_SDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEquation_SDA)).EndInit();
            this.groupBoxInPut_SDA.ResumeLayout(false);
            this.groupBoxInPut_SDA.PerformLayout();
            this.groupBoxOutPut_SDA.ResumeLayout(false);
            this.groupBoxOutPut_SDA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_SDA;
        private System.Windows.Forms.PictureBox pictureBoxEquation_SDA;
        private System.Windows.Forms.TextBox textBoxCondition_SDA;
        private System.Windows.Forms.GroupBox groupBoxInPut_SDA;
        private System.Windows.Forms.TextBox textBoxInPut_SDA;
        private System.Windows.Forms.Label labelX_SDA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SDA;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelResult_SDA;
        private System.Windows.Forms.Button buttonHelp_SDA;
        private System.Windows.Forms.Button buttonDone_SDA;
    }
}
