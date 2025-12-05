using Tyuiu.ShaykhelislamovaDA.Sprint6.Task2.V22.Lib;
namespace Tyuiu.ShaykhelislamovaDA.Sprint6.Task2.V22
{
    public partial class Form1 : Form
    {
        DataService ds = new DataService();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ButtonAktivation_SDA_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(TextBox_Start_SDA.Text);
                int stop = Convert.ToInt32(TextBox_Stop_SDA.Text);

                double[] arr = ds.GetMassFunction(start, stop);
                int len = arr.Length;

                this.dataGridView1_Table_SDA.Rows.Clear();
                formsPlot1_Graf_SDA.Plot.Clear();
                List<double> xValues = new List<double>();
                List<double> yValues = new List<double>();

                for (int i = 0; i < len; i++)
                {
                    this.dataGridView1_Table_SDA.Rows.Add(start.ToString(), arr[i].ToString());
                    xValues.Add(start);
                    yValues.Add(arr[i]);
                    start++;
                }
                formsPlot1_Graf_SDA.Plot.Add.Scatter(xValues.ToArray(), yValues.ToArray());
                formsPlot1_Graf_SDA.Plot.Title("График функции");
                formsPlot1_Graf_SDA.Plot.XLabel("Ось X");
                formsPlot1_Graf_SDA.Plot.YLabel("Ось Y");
                formsPlot1_Graf_SDA.Refresh();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены неверные данные (не число)", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Button_Help_SDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск выполнил студент группы ПКТб-25-1 Шайхелисламова Диана Артуровна.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_Table_SDA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
