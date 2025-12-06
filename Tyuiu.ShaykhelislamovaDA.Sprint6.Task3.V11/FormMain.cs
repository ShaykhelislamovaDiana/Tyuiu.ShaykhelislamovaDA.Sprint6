using System.Drawing;
using Tyuiu.ShaykhelislamovaDA.Sprint6.Task3.V11.Lib;
namespace Tyuiu.ShaykhelislamovaDA.Sprint6.Task3.V11
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void Button_Aktivation_SDA_Click(object sender, EventArgs e)
        {
            int[,] arr = new int[5, 5] { { 27, -15, 14, 2, 27 }, { -8, 14, -10, 33, 0 }, { 1, 7, -11, -11, 23 }, { -13, -20, 15, -16, 34 }, { -3, 1, -1, 5, 1 } };
            this.dataGridView1_Matrix_RES_SDA.Rows.Clear();
            string[] rows = new string[arr.GetLength(1)];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    rows[j] = arr[i, j].ToString();
                }
                this.dataGridView1_Matrix_START_SDA.Rows.Add(rows);
            }
            int[,] res = ds.Calculate(arr);
            string[] rowsRes = new string[arr.GetLength(1)];
            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    rowsRes[j] = res[i, j].ToString();
                }
                this.dataGridView1_Matrix_RES_SDA.Rows.Add(rowsRes);
            }

        }

        private void label3_res_SDA_Click(object sender, EventArgs e)
        {

        }

        private void button1_Info_SDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск выполнил студент группы ПКТб-25-1 Шайхелисламова Диана Артуровна.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
