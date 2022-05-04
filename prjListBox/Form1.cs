using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                double peso = Convert.ToDouble(txtPeso.Text);
                lista.Items.Add(peso);
                txtPeso.Focus();
                txtPeso.Text = "0";
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao inserir peso na lista");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lista.Items.Count > 0)
            {
                lista.Items.Remove(lista.SelectedItem);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lista.Items.Count > 0)
            {
                double peso = Convert.ToDouble(txtPeso.Text);
                lista.Items[lista.SelectedIndex] = peso;
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double soma = 0;
            for (int i = 0; i < lista.Items.Count; i++)
            {
                soma += Convert.ToDouble(lista.Items[i]);
            }
            lbResposta.Text = "A soma é =" + soma.ToString();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            double soma = 0;
            double media;
            for (int i = 0; i < lista.Items.Count; i++)
            {
                soma += Convert.ToDouble(lista.Items[i]);
            }
            media = soma / lista.Items.Count;

            lbResposta.Text = "A média é = " + media.ToString();
        }

        private void btnMaior_Click(object sender, EventArgs e)
        {
            double max = 0;
            foreach (object item in lista.Items)
            {
                max = Math.Max(max, Convert.ToDouble(item));
            }
            lbResposta.Text = "O maior valor é = " + max.ToString();
        }

        private void btnMenor_Click(object sender, EventArgs e)
        {
           double menor = double.Parse(lista.Items[0].ToString());
            for(int i = 0; i < lista.Items.Count; i++)
            {
                double aux = double.Parse(lista.Items[i].ToString());
                if (aux < menor)
                {
                    menor = aux;
                }
            }
            lbResposta.Text = "O menor valor é = " + menor.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lista.DataSource = null;
            lista.Items.Clear();
        }
    }
}
