namespace Tyuiu.ShaykhelislamovaDA.Sprint6.Task5.V12
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            ButtonOpenFile_SDA = new Button();
            ButtonAktivation_SDA = new Button();
            ChartDiagramm_SDA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            DataGridViewTable_SDA = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ChartDiagramm_SDA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewTable_SDA).BeginInit();
            SuspendLayout();
            // 
            // ButtonOpenFile_SDA
            // 
            ButtonOpenFile_SDA.Location = new Point(12, 46);
            ButtonOpenFile_SDA.Name = "ButtonOpenFile_SDA";
            ButtonOpenFile_SDA.Size = new Size(117, 29);
            ButtonOpenFile_SDA.TabIndex = 0;
            ButtonOpenFile_SDA.Text = "Открыть файл";
            ButtonOpenFile_SDA.UseVisualStyleBackColor = true;
            ButtonOpenFile_SDA.Click += ButtonOpenFile_SDA_Click;
            // 
            // ButtonAktivation_SDA
            // 
            ButtonAktivation_SDA.Location = new Point(12, 93);
            ButtonAktivation_SDA.Name = "ButtonAktivation_SDA";
            ButtonAktivation_SDA.Size = new Size(117, 29);
            ButtonAktivation_SDA.TabIndex = 1;
            ButtonAktivation_SDA.Text = "Выполнить";
            ButtonAktivation_SDA.UseVisualStyleBackColor = true;
            ButtonAktivation_SDA.Click += ButtonAktivation_SDA_Click;
            // 
            // ChartDiagramm_SDA
            // 
            chartArea1.Name = "ChartArea1";
            ChartDiagramm_SDA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            ChartDiagramm_SDA.Legends.Add(legend1);
            ChartDiagramm_SDA.Location = new Point(390, 12);
            ChartDiagramm_SDA.Name = "ChartDiagramm_SDA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            ChartDiagramm_SDA.Series.Add(series1);
            ChartDiagramm_SDA.Size = new Size(375, 375);
            ChartDiagramm_SDA.TabIndex = 2;
            ChartDiagramm_SDA.Text = "Диаграмма";
            ChartDiagramm_SDA.Click += ChartDiagramm_SDA_Click;
            // 
            // DataGridViewTable_SDA
            // 
            DataGridViewTable_SDA.AllowUserToAddRows = false;
            DataGridViewTable_SDA.AllowUserToResizeRows = false;
            DataGridViewTable_SDA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DataGridViewTable_SDA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewTable_SDA.Location = new Point(165, 12);
            DataGridViewTable_SDA.Name = "DataGridViewTable_SDA";
            DataGridViewTable_SDA.RowHeadersWidth = 51;
            DataGridViewTable_SDA.Size = new Size(193, 375);
            DataGridViewTable_SDA.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 450);
            Controls.Add(DataGridViewTable_SDA);
            Controls.Add(ChartDiagramm_SDA);
            Controls.Add(ButtonAktivation_SDA);
            Controls.Add(ButtonOpenFile_SDA);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)ChartDiagramm_SDA).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewTable_SDA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonOpenFile_SDA;
        private Button ButtonAktivation_SDA;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartDiagramm_SDA;
        private DataGridView DataGridViewTable_SDA;
    }
}
