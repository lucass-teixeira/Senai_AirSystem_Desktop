using Desktop.Models;
using Desktop.Repositories;
using Desktop.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class checkAdm : Form
    {
        private Usuario usuario = null;
        public checkAdm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //O filtro - somente apresentar os arquivos de imagem
            ofd.Filter = "Arquivos de imagens(*.jpg;*.png)|*.jpg;*.png";
            //Chamar a janela - entrar somente se confirma a seleção do arquivo
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //Carregar a imagem selecionada no picturebox
                picBoxFoto.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
            if (!Utils.temCamposVazio(this))
            //8. Armazena os dados do novo usuário nas propriedades da classe e carrega na lista (para alimentar o datagrid)
            //instanciar a classe UsuarioRepository onde estão criados os métodos de acesso aos dados

            {
                UsuarioRepository repository = new UsuarioRepository();
                if (this.usuario == null)
                {
                    //Atribui nas propriedades da classe usuários os valores dos campos do formulário
                    Usuario usuario = new Usuario
                    {
                        nome = nomeTextBox.Text,
                        sobrenome = sobrenomeTextBox.Text,
                        dataNasc = Convert.ToDateTime("12/02/2000"),
                        usuario =  usuTextBox.Text,
                        senha = "1234",
                        confSenha= confSenTextBox.Text,

                    };
                    //chama o método adicionar - passando a classe usuario
                    repository.adicionar(usuario);

                    //Todos os campos foram preenchidos - Salva os campos no BD
                    MessageBox.Show("Dados Salvos.",
                                    "Aviso", MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);

                    new frmAdministrador().ShowDialog();

                }
                else
                {
                    //alimenta as propriedades da classe com o conteúdo dos campos do formulário

                    this.usuario.nome = nomeTextBox.Text;
                    this.usuario.sobrenome = sobrenomeTextBox.Text;
                    this.usuario.usuario = usuTextBox.Text;
                    //this.usuario.dataNasc = dateTimepicker1.ToString;
                    this.usuario.senha = "1234";
                    this.usuario.confSenha = confSenTextBox.Text;
                    //Chama o método para editar 
                    //Atalho para criar o método -> Alt Enter para criar o método editar

                    repository.editar(usuario);
                }
                

                    
                
                
                this.Close();

            }
            else
            {   //Texto , Título, Botões, Ícone
                MessageBox.Show("Todos os campos são obrigatórios.",
                                "Aviso", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }

            

        }

        private void formCadastro_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = this.Size;
            this.Text = "Novo Usuário - AirSystem";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
