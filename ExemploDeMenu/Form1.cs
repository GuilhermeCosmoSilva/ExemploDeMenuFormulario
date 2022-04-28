using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploDeMenu
{
    public partial class Form1 : Form
    {
        Cadastrar cad;
        Atualizar atu;
        Consultar con;
        Excluir exc;
        public Form1()
        {
            InitializeComponent();
            cad = new Cadastrar();
            atu = new Atualizar();
            con = new Consultar();
            exc = new Excluir();
        }//Fim do construtor

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            Visible = false;
            cad.ShowDialog();//Mostrar a tela ao ser chamado
            Visible = true;
        }//fim do Botão Cadastrar

        private void Consultar_Click(object sender, EventArgs e)
        {
            Visible = false;
            con.ShowDialog();//Mostrar a tela ao ser chamado
            Visible = true;
        }//fim do Botão Consultar

        private void Atualizar_Click(object sender, EventArgs e)
        {
            Visible = false;
            atu.ShowDialog();//Mostrar a tela ao ser chamado
            Visible = true;
        }//fim do Botão Atualizar

        private void Excluir_Click(object sender, EventArgs e)
        {
            Visible = false;
            exc.ShowDialog();//Mostrar a tela ao ser chamado
            Visible = true;
        }//fim do Botão Excluir
    }//fim da Classe
}//Fim do Projeto
