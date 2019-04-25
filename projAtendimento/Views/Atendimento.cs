using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoAtendimento.Controllers;
using ProjetoAtendimento.Models;

namespace ProjetoAtendimento.Views
{
    public partial class Atendimento : Form
    {
        private Senhas gerando_senhas = new Senhas();
        private Guiches guiches = new Guiches();

        public Atendimento()
        {
            InitializeComponent();
        }

        // CRIANDO O BOTAO GERAR 
        private void botao_gerar_Click(object sender, EventArgs e)
        {
            gerando_senhas.gerar();
        }

        // BOTAO ADICIONAR E APRESENTANDO OS GUCHES
        private void botao_Adicionar_Click(object sender, EventArgs e)
        {
            guiches.adicionar(new Guiche());
            lblNumGuiche.Text = guiches.ListaGuiches.Count.ToString();
        }

        private void buttonChamar_Click(object sender, EventArgs e)
        {
            if (!listChuiches.ListaGuiches[int.Parse(textBoxGuiche.Text) - 1].chamar(listSenhas.FilaSenhas))
                MessageBox.Show("Fila vazia");
        }

        private void btnListarSenhas_Click(object sender, EventArgs e)
        {
            lbx_Senhas.Items.Clear();
            gerando_senhas.FilaSenhas.ToList().ForEach(i => lbx_Senhas.Items.Add(i.dadosParciais()));
        }

        private void btnListarAtend_Click(object sender, EventArgs e)
        {
            var index = Int32.Parse(txtGuiche.Text) - 1;
            lbx_SenhasGuiche.Items.Clear();
            guiches.ListaGuiches[index].Atendimentos.ToList().ForEach(i => lbx_SenhasGuiche.Items.Add(i.dadosCompletos()));
        }

        private void lblQtdeGuiche_Click(object sender, EventArgs e)
        {

        }
    }

    
}
