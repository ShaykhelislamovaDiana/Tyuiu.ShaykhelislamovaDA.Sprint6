using Tyuiu.ShaykhelislamovaDA.Sprint6.Task5.V12.Lib;
namespace Tyuiu.ShaykhelislamovaDA.Sprint6.Task5.V12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask5V12.txt";
        private void ButtonAktivation_SDA_Click(object sender, EventArgs e)
        {
            DataGridViewTable_SDA.ColumnCount = 2;
            DataGridViewTable_SDA.Columns[0].Width = 25;
            DataGridViewTable_SDA.Columns[1].Width = 50;

            this.ChartDiagramm_SDA.ChartAreas[0].AxisX.Title = "Îñü X";
            this.ChartDiagramm_SDA.ChartAreas[0].AxisY.Title = "Îñü Y";

            ChartDiagramm_SDA.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                DataGridViewTable_SDA.Rows.Add(i.ToString(), numsMass[i].ToString());
                ChartDiagramm_SDA.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void ButtonOpenFile_SDA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void ChartDiagramm_SDA_Click(object sender, EventArgs e)
        {

        }
    }
}
