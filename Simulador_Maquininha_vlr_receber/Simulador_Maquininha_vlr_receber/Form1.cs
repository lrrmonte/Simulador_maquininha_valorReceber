using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulador_Maquininha_vlr_receber
{   
    public partial class Form1 : Form
    {
        double vlr_receber, taxa, vlr_venda, pmt_cliente, vlr_taxa;
        int prazo;
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Calcular_Click(object sender, EventArgs e)
        {
            Converter();

            vlr_venda = vlr_receber / (1 - (taxa / 100));
            pmt_cliente = vlr_venda / prazo;
            vlr_taxa = vlr_venda - vlr_receber;

            lb_vlr_venda.Text = Math.Round(vlr_venda, 2).ToString();
            lb_pmt_cliente.Text = Math.Round(pmt_cliente, 2).ToString();
            lb_vlr_taxa.Text = Math.Round(vlr_venda-vlr_receber,2).ToString();
        }

        private void bt_Limpar_Click(object sender, EventArgs e)
        {
            tb_vlr_receber.Clear();
            tb_taxa.Clear();
            tb_prazo.Clear();
            lb_vlr_venda.ResetText();
            lb_pmt_cliente.ResetText();
            lb_vlr_taxa.ResetText();
            tb_vlr_receber.Focus();
        }

        private void bt_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Converter()
        {
            try
            {

                vlr_receber = double.Parse(tb_vlr_receber.Text);
                taxa = double.Parse(tb_taxa.Text);
                prazo = Convert.ToInt16(tb_prazo.Text);
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
