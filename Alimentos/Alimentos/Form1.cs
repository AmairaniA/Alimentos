using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alimentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cbAlimentos.SelectedIndex;
            label1.Text = indice.ToString();
            label2.Text = cbAlimentos.Items[indice].ToString();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbAlimentos.Items.Add("Pozole");
            cbAlimentos.Items.Add("Tostadas de pata");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            cbAlimentos.Items.Add(textBox1.Text);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
