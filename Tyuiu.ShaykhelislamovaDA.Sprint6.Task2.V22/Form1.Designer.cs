namespace Tyuiu.ShaykhelislamovaDA.Sprint6.Task2.V22
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
            formsPlot1_Graf_SDA = new ScottPlot.WinForms.FormsPlot();
            Button_Aktivation_SDA = new Button();
            TextBox_Start_SDA = new TextBox();
            TextBox_Stop_SDA = new TextBox();
            Text_Start_SDA = new Label();
            Text_Stop_SDA = new Label();
            groupBox1_Vvod_SDA = new GroupBox();
            Button_Help_SDA = new Button();
            groupBox1_Uslovie_SDA = new GroupBox();
            PictureBox_Uslovie = new PictureBox();
            label1_uslovie_SDA = new Label();
            groupBox1_Vivod_Dan_SDA = new GroupBox();
            label1_resalt_SDA = new Label();
            dataGridView1_Table_SDA = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            groupBox1_Vvod_SDA.SuspendLayout();
            groupBox1_Uslovie_SDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox_Uslovie).BeginInit();
            groupBox1_Vivod_Dan_SDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1_Table_SDA).BeginInit();
            SuspendLayout();
            // 
            // formsPlot1_Graf_SDA
            // 
            formsPlot1_Graf_SDA.DisplayScale = 1.25F;
            formsPlot1_Graf_SDA.Location = new Point(108, 39);
            formsPlot1_Graf_SDA.Name = "formsPlot1_Graf_SDA";
            formsPlot1_Graf_SDA.Size = new Size(451, 377);
            formsPlot1_Graf_SDA.TabIndex = 0;
            // 
            // Button_Aktivation_SDA
            // 
            Button_Aktivation_SDA.Location = new Point(230, 23);
            Button_Aktivation_SDA.Name = "Button_Aktivation_SDA";
            Button_Aktivation_SDA.Size = new Size(94, 93);
            Button_Aktivation_SDA.TabIndex = 1;
            Button_Aktivation_SDA.Text = "Вычислить";
            Button_Aktivation_SDA.UseVisualStyleBackColor = true;
            Button_Aktivation_SDA.Click += ButtonAktivation_SDA_Click;
            Button_Aktivation_SDA.MouseDown += ButtonAktivation_SDA_MouseDown;
            Button_Aktivation_SDA.MouseEnter += ButtonAktivation_SDA_MouseEnter;
            Button_Aktivation_SDA.MouseLeave += ButtonAktivation_SDA_MouseLeave;
            // 
            // TextBox_Start_SDA
            // 
            TextBox_Start_SDA.Location = new Point(13, 374);
            TextBox_Start_SDA.Name = "TextBox_Start_SDA";
            TextBox_Start_SDA.Size = new Size(97, 27);
            TextBox_Start_SDA.TabIndex = 2;
            // 
            // TextBox_Stop_SDA
            // 
            TextBox_Stop_SDA.Location = new Point(117, 56);
            TextBox_Stop_SDA.Name = "TextBox_Stop_SDA";
            TextBox_Stop_SDA.Size = new Size(98, 27);
            TextBox_Stop_SDA.TabIndex = 4;
            // 
            // Text_Start_SDA
            // 
            Text_Start_SDA.AutoSize = true;
            Text_Start_SDA.Location = new Point(30, 33);
            Text_Start_SDA.Name = "Text_Start_SDA";
            Text_Start_SDA.Size = new Size(47, 20);
            Text_Start_SDA.TabIndex = 6;
            Text_Start_SDA.Text = "Старт";
            Text_Start_SDA.Click += label1_Click;
            // 
            // Text_Stop_SDA
            // 
            Text_Stop_SDA.AutoSize = true;
            Text_Stop_SDA.Location = new Point(147, 33);
            Text_Stop_SDA.Name = "Text_Stop_SDA";
            Text_Stop_SDA.Size = new Size(42, 20);
            Text_Stop_SDA.TabIndex = 7;
            Text_Stop_SDA.Text = "Стоп";
            // 
            // groupBox1_Vvod_SDA
            // 
            groupBox1_Vvod_SDA.Controls.Add(Button_Help_SDA);
            groupBox1_Vvod_SDA.Controls.Add(Text_Stop_SDA);
            groupBox1_Vvod_SDA.Controls.Add(Button_Aktivation_SDA);
            groupBox1_Vvod_SDA.Controls.Add(Text_Start_SDA);
            groupBox1_Vvod_SDA.Controls.Add(TextBox_Stop_SDA);
            groupBox1_Vvod_SDA.Location = new Point(8, 318);
            groupBox1_Vvod_SDA.Name = "groupBox1_Vvod_SDA";
            groupBox1_Vvod_SDA.Size = new Size(457, 128);
            groupBox1_Vvod_SDA.TabIndex = 8;
            groupBox1_Vvod_SDA.TabStop = false;
            groupBox1_Vvod_SDA.Text = "Ввод данных:";
            // 
            // Button_Help_SDA
            // 
            Button_Help_SDA.Location = new Point(341, 23);
            Button_Help_SDA.Name = "Button_Help_SDA";
            Button_Help_SDA.Size = new Size(94, 93);
            Button_Help_SDA.TabIndex = 8;
            Button_Help_SDA.Text = "Справка";
            Button_Help_SDA.UseVisualStyleBackColor = true;
            Button_Help_SDA.Click += Button_Help_SDA_Click;
            // 
            // groupBox1_Uslovie_SDA
            // 
            groupBox1_Uslovie_SDA.Controls.Add(PictureBox_Uslovie);
            groupBox1_Uslovie_SDA.Controls.Add(label1_uslovie_SDA);
            groupBox1_Uslovie_SDA.Location = new Point(8, 12);
            groupBox1_Uslovie_SDA.Name = "groupBox1_Uslovie_SDA";
            groupBox1_Uslovie_SDA.Size = new Size(457, 300);
            groupBox1_Uslovie_SDA.TabIndex = 9;
            groupBox1_Uslovie_SDA.TabStop = false;
            groupBox1_Uslovie_SDA.Text = "Условие:";
            // 
            // PictureBox_Uslovie
            // 
            PictureBox_Uslovie.Image = Properties.Resources.Снимок_экрана_2025_12_05_175130;
            PictureBox_Uslovie.Location = new Point(6, 66);
            PictureBox_Uslovie.Name = "PictureBox_Uslovie";
            PictureBox_Uslovie.Size = new Size(196, 41);
            PictureBox_Uslovie.TabIndex = 1;
            PictureBox_Uslovie.TabStop = false;
            // 
            // label1_uslovie_SDA
            // 
            label1_uslovie_SDA.AutoSize = true;
            label1_uslovie_SDA.Location = new Point(4, 23);
            label1_uslovie_SDA.Name = "label1_uslovie_SDA";
            label1_uslovie_SDA.Size = new Size(419, 40);
            label1_uslovie_SDA.TabIndex = 0;
            label1_uslovie_SDA.Text = "Написать программу, которая выводит таблицу значений \r\nфункции:";
            label1_uslovie_SDA.Click += label1_Click_1;
            // 
            // groupBox1_Vivod_Dan_SDA
            // 
            groupBox1_Vivod_Dan_SDA.Controls.Add(label1_resalt_SDA);
            groupBox1_Vivod_Dan_SDA.Controls.Add(dataGridView1_Table_SDA);
            groupBox1_Vivod_Dan_SDA.Controls.Add(formsPlot1_Graf_SDA);
            groupBox1_Vivod_Dan_SDA.Location = new Point(471, 12);
            groupBox1_Vivod_Dan_SDA.Name = "groupBox1_Vivod_Dan_SDA";
            groupBox1_Vivod_Dan_SDA.Size = new Size(574, 434);
            groupBox1_Vivod_Dan_SDA.TabIndex = 10;
            groupBox1_Vivod_Dan_SDA.TabStop = false;
            groupBox1_Vivod_Dan_SDA.Text = "Вывод данных:";
            // 
            // label1_resalt_SDA
            // 
            label1_resalt_SDA.AutoSize = true;
            label1_resalt_SDA.Location = new Point(6, 23);
            label1_resalt_SDA.Name = "label1_resalt_SDA";
            label1_resalt_SDA.Size = new Size(78, 20);
            label1_resalt_SDA.TabIndex = 2;
            label1_resalt_SDA.Text = "Результат:";
            // 
            // dataGridView1_Table_SDA
            // 
            dataGridView1_Table_SDA.AllowUserToAddRows = false;
            dataGridView1_Table_SDA.AllowUserToOrderColumns = true;
            dataGridView1_Table_SDA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1_Table_SDA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1_Table_SDA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1_Table_SDA.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridView1_Table_SDA.Location = new Point(6, 47);
            dataGridView1_Table_SDA.Name = "dataGridView1_Table_SDA";
            dataGridView1_Table_SDA.RowHeadersVisible = false;
            dataGridView1_Table_SDA.RowHeadersWidth = 51;
            dataGridView1_Table_SDA.Size = new Size(96, 342);
            dataGridView1_Table_SDA.TabIndex = 1;
            dataGridView1_Table_SDA.CellContentClick += dataGridView1_Table_SDA_CellContentClick;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 47;
            // 
            // Y
            // 
            Y.HeaderText = "Y";
            Y.MinimumWidth = 6;
            Y.Name = "Y";
            Y.Width = 46;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 450);
            Controls.Add(TextBox_Start_SDA);
            Controls.Add(groupBox1_Vvod_SDA);
            Controls.Add(groupBox1_Uslovie_SDA);
            Controls.Add(groupBox1_Vivod_Dan_SDA);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1_Vvod_SDA.ResumeLayout(false);
            groupBox1_Vvod_SDA.PerformLayout();
            groupBox1_Uslovie_SDA.ResumeLayout(false);
            groupBox1_Uslovie_SDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox_Uslovie).EndInit();
            groupBox1_Vivod_Dan_SDA.ResumeLayout(false);
            groupBox1_Vivod_Dan_SDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1_Table_SDA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot formsPlot1_Graf_SDA;
        private Button Button_Aktivation_SDA;
        private TextBox TextBox_Start_SDA;
        private TextBox TextBox_Stop_SDA;
        private Label Text_Start_SDA;
        private Label Text_Stop_SDA;
        private GroupBox groupBox1_Vvod_SDA;
        private GroupBox groupBox1_Uslovie_SDA;
        private Label label1_uslovie_SDA;
        private PictureBox PictureBox_Uslovie;
        private GroupBox groupBox1_Vivod_Dan_SDA;
        private Label label1_resalt_SDA;
        private DataGridView dataGridView1_Table_SDA;
        private Button Button_Help_SDA;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
    }
}
