using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto_Escola
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tsHora.Text = "Hora: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            tsData.Text = "Data: " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_Aluno tCA = new Cadastro_Aluno();//Criando uma instância do formulário Exercício 1
            tCA.MdiParent = this;
            tCA.Show();
        }

        private void disciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_Disciplina tCD= new Cadastro_Disciplina();//Criando uma instância do formulário Exercício 1
            tCD.MdiParent = this;
            tCD.Show();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Conexao.fecharConexao();
            else
            {
                e.Cancel = true;
            }
        }

        private void mençãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro_Menção tCM = new Cadastro_Menção();//Criando uma instância do formulário Exercício 1
            tCM.MdiParent = this;
            tCM.Show();
        }

       
    }
}
