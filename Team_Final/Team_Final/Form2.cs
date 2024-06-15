using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Final
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void picBox_RH_Click(object sender, EventArgs e)
        {
            MemoryGame.Form1 form1 = new MemoryGame.Form1();
            form1.Show();
        }

        private void picBox_TW_Click(object sender, EventArgs e)
        {
            CatchDigda.Digda digda = new CatchDigda.Digda();
            digda.Show();
        }
    }
}
