using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _KR2_2023_1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Не розумію....\nЧому штани в яких краще вього лежати на дивані називаються спортивними???","Анекдот" , MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Давид крутий чувак! А Микита ще круче!", "Анекдот", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Микита взагалі крутий чувак, не має чорний каділак, в нього 'MUKUTA' номера", "Анекдот", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Щасливий той богомол що мав дві жінки", "Анекдот", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тут може бути ваш анекдот...", "Анекдот", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
