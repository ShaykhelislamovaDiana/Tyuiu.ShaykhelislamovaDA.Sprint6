using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShaykhelislamovaDA.Sprint6.Task1.V30.Lib;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.ShaykhelislamovaDA.Sprint6.Task1.V30
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_SDA_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartValue_SDA.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue_SDA.Text);

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxResult_SDA.Text = "";
                textBoxResult_SDA.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_SDA.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxResult_SDA.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i < len; i++)
                {
                    strLine = String.Format("|{0,5:d}      |  {1,7:f2}   |", startValue, valueArray[i]);
                    textBoxResult_SDA.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxResult_SDA.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Ââåäåíû íåâåðíûå äàííûå", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_SDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Òàñê 1 âûïîëíèë ñòóäåíò ãðóïïû ÈÁÊÑá-24-1 Ñàâöîâ Íèêèòà Åâãåíüåâè÷", "Ñîîáùåíèå", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}