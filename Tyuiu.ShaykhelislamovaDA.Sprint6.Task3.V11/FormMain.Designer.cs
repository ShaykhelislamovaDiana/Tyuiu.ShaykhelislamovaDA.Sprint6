using Tyuiu.ShaykhelislamovaDA.Sprint6.Task3.V11.Lib;
namespace Tyuiu.ShaykhelislamovaDA.Sprint6.Task3.V11
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
            groupBox1_Uslovie_SDA = new GroupBox();
            label1 = new Label();
            Button_Aktivation_SDA = new Button();
            groupBox1_Vivod = new GroupBox();
            label3_res_SDA = new Label();
            label2 = new Label();
            dataGridView1_Matrix_START_SDA = new DataGridView();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridView1_Matrix_RES_SDA = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            button1_Info_SDA = new Button();
            groupBox1_Uslovie_SDA.SuspendLayout();
            groupBox1_Vivod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1_Matrix_START_SDA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1_Matrix_RES_SDA).BeginInit();
            SuspendLayout();
            // 
            // groupBox1_Uslovie_SDA
            // 
            groupBox1_Uslovie_SDA.Controls.Add(label1);
            groupBox1_Uslovie_SDA.Location = new Point(12, 12);
            groupBox1_Uslovie_SDA.Name = "groupBox1_Uslovie_SDA";
            groupBox1_Uslovie_SDA.Size = new Size(342, 247);
            groupBox1_Uslovie_SDA.TabIndex = 0;
            groupBox1_Uslovie_SDA.TabStop = false;
            groupBox1_Uslovie_SDA.Text = "Условие";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(316, 220);
            label1.TabIndex = 0;
            label1.Text = "Дана матрица 5 х 5. Выполнить сортировку \r\nпо возрастанию в первом столбце.\r\n 27 -15  14   2  27\r\n\r\n -8  14 -10  33   0\r\n\r\n  1   7 -11 -11  23\r\n\r\n -13 -20  15 -16  34\r\n\r\n  -3   1  -1   5   1";
            // 
            // Button_Aktivation_SDA
            // 
            Button_Aktivation_SDA.Location = new Point(132, 184);
            Button_Aktivation_SDA.Name = "Button_Aktivation_SDA";
            Button_Aktivation_SDA.Size = new Size(164, 53);
            Button_Aktivation_SDA.TabIndex = 1;
            Button_Aktivation_SDA.Text = "Вычислить";
            Button_Aktivation_SDA.UseVisualStyleBackColor = true;
            Button_Aktivation_SDA.Click += Button_Aktivation_SDA_Click;
            // 
            // groupBox1_Vivod
            // 
            groupBox1_Vivod.Controls.Add(button1_Info_SDA);
            groupBox1_Vivod.Controls.Add(Button_Aktivation_SDA);
            groupBox1_Vivod.Controls.Add(label3_res_SDA);
            groupBox1_Vivod.Controls.Add(label2);
            groupBox1_Vivod.Controls.Add(dataGridView1_Matrix_START_SDA);
            groupBox1_Vivod.Controls.Add(dataGridView1_Matrix_RES_SDA);
            groupBox1_Vivod.Location = new Point(360, 12);
            groupBox1_Vivod.Name = "groupBox1_Vivod";
            groupBox1_Vivod.Size = new Size(428, 247);
            groupBox1_Vivod.TabIndex = 1;
            groupBox1_Vivod.TabStop = false;
            groupBox1_Vivod.Text = "Вывод";
            // 
            // label3_res_SDA
            // 
            label3_res_SDA.AutoSize = true;
            label3_res_SDA.Location = new Point(281, 32);
            label3_res_SDA.Name = "label3_res_SDA";
            label3_res_SDA.Size = new Size(75, 20);
            label3_res_SDA.TabIndex = 4;
            label3_res_SDA.Text = "Результат";
            label3_res_SDA.Click += label3_res_SDA_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 32);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 3;
            label2.Text = "Исходная матрица";
            // 
            // dataGridView1_Matrix_START_SDA
            // 
            dataGridView1_Matrix_START_SDA.AllowUserToAddRows = false;
            dataGridView1_Matrix_START_SDA.AllowUserToResizeColumns = false;
            dataGridView1_Matrix_START_SDA.AllowUserToResizeRows = false;
            dataGridView1_Matrix_START_SDA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1_Matrix_START_SDA.ColumnHeadersHeight = 30;
            dataGridView1_Matrix_START_SDA.ColumnHeadersVisible = false;
            dataGridView1_Matrix_START_SDA.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10 });
            dataGridView1_Matrix_START_SDA.Location = new Point(22, 55);
            dataGridView1_Matrix_START_SDA.Name = "dataGridView1_Matrix_START_SDA";
            dataGridView1_Matrix_START_SDA.RowHeadersVisible = false;
            dataGridView1_Matrix_START_SDA.RowHeadersWidth = 51;
            dataGridView1_Matrix_START_SDA.RowTemplate.Height = 50;
            dataGridView1_Matrix_START_SDA.Size = new Size(178, 123);
            dataGridView1_Matrix_START_SDA.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Column1";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 35;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Column2";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 35;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Column3";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Width = 35;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Column4";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.Width = 35;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Column5";
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.Width = 35;
            // 
            // dataGridView1_Matrix_RES_SDA
            // 
            dataGridView1_Matrix_RES_SDA.AllowUserToAddRows = false;
            dataGridView1_Matrix_RES_SDA.AllowUserToResizeColumns = false;
            dataGridView1_Matrix_RES_SDA.AllowUserToResizeRows = false;
            dataGridView1_Matrix_RES_SDA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1_Matrix_RES_SDA.ColumnHeadersHeight = 30;
            dataGridView1_Matrix_RES_SDA.ColumnHeadersVisible = false;
            dataGridView1_Matrix_RES_SDA.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridView1_Matrix_RES_SDA.Location = new Point(230, 55);
            dataGridView1_Matrix_RES_SDA.Name = "dataGridView1_Matrix_RES_SDA";
            dataGridView1_Matrix_RES_SDA.RowHeadersVisible = false;
            dataGridView1_Matrix_RES_SDA.RowHeadersWidth = 51;
            dataGridView1_Matrix_RES_SDA.RowTemplate.Height = 50;
            dataGridView1_Matrix_RES_SDA.Size = new Size(178, 123);
            dataGridView1_Matrix_RES_SDA.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Column1";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 35;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Column2";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 35;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Column3";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 35;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Column4";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 35;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Column5";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 35;
            // 
            // button1_Info_SDA
            // 
            button1_Info_SDA.Location = new Point(73, 184);
            button1_Info_SDA.Name = "button1_Info_SDA";
            button1_Info_SDA.Size = new Size(53, 53);
            button1_Info_SDA.TabIndex = 5;
            button1_Info_SDA.Text = "?";
            button1_Info_SDA.UseVisualStyleBackColor = true;
            button1_Info_SDA.Click += button1_Info_SDA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 271);
            Controls.Add(groupBox1_Vivod);
            Controls.Add(groupBox1_Uslovie_SDA);
            Name = "FormMain";
            Text = "Form1";
            groupBox1_Uslovie_SDA.ResumeLayout(false);
            groupBox1_Uslovie_SDA.PerformLayout();
            groupBox1_Vivod.ResumeLayout(false);
            groupBox1_Vivod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1_Matrix_START_SDA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1_Matrix_RES_SDA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1_Uslovie_SDA;
        private Label label1;
        private GroupBox groupBox1_Vivod;
        private DataGridView dataGridView1_Matrix_RES_SDA;
        private Button Button_Aktivation_SDA;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridView dataGridView1_Matrix_START_SDA;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private Label label3_res_SDA;
        private Label label2;
        private Button button1_Info_SDA;
    }
}
