namespace Tyuiu.ShaykhelislamovaDA.Sprint6.Task4.V14
{
    partial class Form1
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
            groupBoxUslovie_SDA = new GroupBox();
            labelStop_SDA = new Label();
            labelStart_SDA = new Label();
            textBoxStop_SDA = new TextBox();
            textBoxStart_SDA = new TextBox();
            ButtonAktivation_SDA = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            splitContainer1 = new SplitContainer();
            richTextBoxRes_SDA = new RichTextBox();
            label2 = new Label();
            buttonSave_SDA = new Button();
            groupBoxUslovie_SDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUslovie_SDA
            // 
            groupBoxUslovie_SDA.Controls.Add(buttonSave_SDA);
            groupBoxUslovie_SDA.Controls.Add(labelStop_SDA);
            groupBoxUslovie_SDA.Controls.Add(labelStart_SDA);
            groupBoxUslovie_SDA.Controls.Add(textBoxStop_SDA);
            groupBoxUslovie_SDA.Controls.Add(textBoxStart_SDA);
            groupBoxUslovie_SDA.Controls.Add(ButtonAktivation_SDA);
            groupBoxUslovie_SDA.Controls.Add(pictureBox1);
            groupBoxUslovie_SDA.Controls.Add(label1);
            groupBoxUslovie_SDA.Location = new Point(3, 8);
            groupBoxUslovie_SDA.Name = "groupBoxUslovie_SDA";
            groupBoxUslovie_SDA.Size = new Size(1066, 79);
            groupBoxUslovie_SDA.TabIndex = 0;
            groupBoxUslovie_SDA.TabStop = false;
            groupBoxUslovie_SDA.Text = "Условие";
            // 
            // labelStop_SDA
            // 
            labelStop_SDA.AutoSize = true;
            labelStop_SDA.Location = new Point(741, 13);
            labelStop_SDA.Name = "labelStop_SDA";
            labelStop_SDA.Size = new Size(83, 20);
            labelStop_SDA.TabIndex = 6;
            labelStop_SDA.Text = "Стоп шага:";
            // 
            // labelStart_SDA
            // 
            labelStart_SDA.AutoSize = true;
            labelStart_SDA.Location = new Point(587, 13);
            labelStart_SDA.Name = "labelStart_SDA";
            labelStart_SDA.Size = new Size(88, 20);
            labelStart_SDA.TabIndex = 5;
            labelStart_SDA.Text = "Старт шага:";
            // 
            // textBoxStop_SDA
            // 
            textBoxStop_SDA.Location = new Point(718, 34);
            textBoxStop_SDA.Name = "textBoxStop_SDA";
            textBoxStop_SDA.Size = new Size(125, 27);
            textBoxStop_SDA.TabIndex = 4;
            // 
            // textBoxStart_SDA
            // 
            textBoxStart_SDA.Location = new Point(564, 34);
            textBoxStart_SDA.Name = "textBoxStart_SDA";
            textBoxStart_SDA.Size = new Size(125, 27);
            textBoxStart_SDA.TabIndex = 3;
            // 
            // ButtonAktivation_SDA
            // 
            ButtonAktivation_SDA.Location = new Point(859, 16);
            ButtonAktivation_SDA.Name = "ButtonAktivation_SDA";
            ButtonAktivation_SDA.Size = new Size(92, 57);
            ButtonAktivation_SDA.TabIndex = 2;
            ButtonAktivation_SDA.Text = "Вычислить";
            ButtonAktivation_SDA.UseVisualStyleBackColor = true;
            ButtonAktivation_SDA.Click += ButtonAktivation_SDA_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Снимок_экрана_2025_12_06_144135;
            pictureBox1.Location = new Point(268, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 35);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(265, 20);
            label1.TabIndex = 0;
            label1.Text = "Вывести таблицу значений функции:";
            label1.Click += label1_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(1, 93);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(richTextBoxRes_SDA);
            splitContainer1.Panel1.Controls.Add(label2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1014, 358);
            splitContainer1.SplitterDistance = 176;
            splitContainer1.TabIndex = 1;
            // 
            // richTextBoxRes_SDA
            // 
            richTextBoxRes_SDA.Location = new Point(3, 23);
            richTextBoxRes_SDA.Name = "richTextBoxRes_SDA";
            richTextBoxRes_SDA.Size = new Size(170, 332);
            richTextBoxRes_SDA.TabIndex = 2;
            richTextBoxRes_SDA.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 4);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "Вывод:";
            // 
            // buttonSave_SDA
            // 
            buttonSave_SDA.Location = new Point(968, 16);
            buttonSave_SDA.Name = "buttonSave_SDA";
            buttonSave_SDA.Size = new Size(92, 57);
            buttonSave_SDA.TabIndex = 7;
            buttonSave_SDA.Text = "Сохранить";
            buttonSave_SDA.UseVisualStyleBackColor = true;
            buttonSave_SDA.Click += buttonSave_SDA_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 462);
            Controls.Add(splitContainer1);
            Controls.Add(groupBoxUslovie_SDA);
            Name = "Form1";
            Text = "Form1";
            groupBoxUslovie_SDA.ResumeLayout(false);
            groupBoxUslovie_SDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUslovie_SDA;
        private Label label1;
        private PictureBox pictureBox1;
        private SplitContainer splitContainer1;
        private Label label2;
        private Button ButtonAktivation_SDA;
        private TextBox textBoxStart_SDA;
        private Label labelStart_SDA;
        private TextBox textBoxStop_SDA;
        private Label labelStop_SDA;
        private RichTextBox richTextBoxRes_SDA;
        private Button buttonSave_SDA;
    }
}
