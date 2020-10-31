using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LoginEsenha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean temErro = false;
            errorProvider1.Clear();


            if (txtLogin.Text.Length == 0)
            {
                errorProvider1.SetError(txtLogin, "Preencha todos os campos!");
                temErro = true;
            }

            if(txtSenha.Text.Length == 0)
            {
                errorProvider1.SetError(txtSenha, "Preencha todos os campos!");
                temErro = true;
            }
            
            if (txtLogin.Text == "Admin" && txtSenha.Text == "12345")
            {
                MessageBox.Show("Bem Vindo ao Trabalho!");

                Form2 tela = new Form2();
                this.Hide();
                tela.ShowDialog();
            }
            else
            {
                    MessageBox.Show("Login ou senha inválidos!");
                txtLogin.Text = txtSenha.Text = "";
            }

            
        }
    }
}
