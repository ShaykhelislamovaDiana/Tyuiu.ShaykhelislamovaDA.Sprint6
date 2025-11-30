using System.ComponentModel;
using System.Data;
using System.Text;
using Tyuiu.ShaykhelislamovaDA.Sprint6.Task0.V2.Lib;
namespace Tyuiu.ShaykhelislamovaDA.Sprint6.Task0.V2
{
    public partial class FormMain_SDA : Form
    {
        public FormMain_SDA()
        {
            InitializeComponent();
        }
        private void buttonHelp_SDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Òàñê 0 âûïîëíèë ñòóäåíò ãðóïïû ÈÑÒÍá-24-1 Òîäèêîâ Äàíèèë Ýäóàðäîâè÷", "Ñîîáùåíèå", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_SDA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInPut_SDA.Text)));
            }
            catch
            {
                MessageBox.Show("Ââåäåíû íåâåðíûå äàííûå", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxInPut_SDA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInPut_SDA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
