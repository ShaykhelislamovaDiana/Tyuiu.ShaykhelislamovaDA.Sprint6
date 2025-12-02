using Tyuiu.ShaykhelislamovaDA.Sprint6.Task1.V30.Lib;
namespace Tyuiu.ShaykhelislamovaDA.Sprint6.Task1.V30
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
        }

        #endregion
        private void InitializeComponents()
        {
            textBoxStartValue_SDA = new TextBox();
            textBoxStopValue_SDA = new TextBox();
            buttonDone_SDA = new Button();
            textBoxResult_SDA = new TextBox();
            buttonInfo_SDA = new Button();
            SuspendLayout();
            //
            // textBoxStartValue_SDA
            //
            textBoxStartValue_SDA.Location = new Point(31, 13);
            textBoxStartValue_SDA.Name = "textBoxStartValue_SDA";
            textBoxStartValue_SDA.Size = new Size(278, 23);
            textBoxStartValue_SDA.TabIndex = 0;
            //
            // textBoxStopValue_SDA
            //
            textBoxStopValue_SDA.Location = new Point(36, 53);
            textBoxStopValue_SDA.Name = "textBoxStopValue_SDA";
            textBoxStopValue_SDA.Size = new Size(273, 23);
            textBoxStopValue_SDA.TabIndex = 1;
            //
            // buttonDone_SDA
            //
            buttonDone_SDA.Location = new Point(36, 168);
            buttonDone_SDA.Name = "buttonDone_SDA";
            buttonDone_SDA.Size = new Size(75, 23);
            buttonDone_SDA.TabIndex = 2;
            buttonDone_SDA.Text = "button1";
            buttonDone_SDA.UseVisualStyleBackColor = true;
            //
            // textBoxResult_SDA
            //
            textBoxResult_SDA.Location = new Point(419, 145);
            textBoxResult_SDA.Name = "textBoxResult_SDA";
            textBoxResult_SDA.Size = new Size(270, 23);
            textBoxResult_SDA.TabIndex = 3;
            //
            // buttonInfo_SDA
            //
            buttonInfo_SDA.Location = new Point(36, 208);
            buttonInfo_SDA.Name = "buttonInfo_SDA";
            buttonInfo_SDA.Size = new Size(75, 23);
            buttonInfo_SDA.TabIndex = 4;
            buttonInfo_SDA.Text = "button1";
            buttonInfo_SDA.UseVisualStyleBackColor = true;
            //
            // FormMain
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonInfo_SDA);
            Controls.Add(textBoxResult_SDA);
            Controls.Add(buttonDone_SDA);
            Controls.Add(textBoxStopValue_SDA);
            Controls.Add(textBoxStartValue_SDA);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        private TextBox textBoxStartValue_SDA;
        private TextBox textBoxStopValue_SDA;
        private Button buttonDone_SDA;
        private TextBox textBoxResult_SDA;
        private Button buttonInfo_SDA;
    }
}