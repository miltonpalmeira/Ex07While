using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex07While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int razao, pa = 0;
            int i = 0;
            razao = int.Parse(txtRazao.Text);

            while (i < 10)
            {
                pa = pa + razao;
                lsbPA.Items.Add(pa);
                i++;
            }
        }
    }
}
