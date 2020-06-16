using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
                this.MinimumSize = this.Size;
                this.Text = "Login - AirSystem";
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.MaximizeBox = false;
                this.MinimizeBox = false;

            // To get rid of shortcuts
            //tbxUsuario.ShortcutsEnabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que quer fechar?", "Confirmação",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //para fechar o form principal
                this.Close();
                //para sair da aplicação
                Application.Exit();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss.fff");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxMs.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            Object selectedItem = comboBox1.SelectedItem;
            if(selectedItem.ToString() == "Inglês")
            {
                CultureInfo ci = new CultureInfo("en-Us");
                Assembly a = Assembly.Load("Desktop");
                ResourceManager rm = new ResourceManager(
                    "Desktop.Lang.Langres-En", a);
                lblUsuario.Text = rm.GetString("Usuario", ci);
                lblSenha.Text = rm.GetString("Senha", ci);
                checkBoxMs.Text = rm.GetString("Mostrar Senha");
                labelIdioma.Text = rm.GetString("Idioma");
                btnEntrar.Text = rm.GetString("Entrar");
                btnSair.Text = rm.GetString("Sair");
                btnNovoUsu.Text = rm.GetString("Novo Usuario");
                
            }
            else if(selectedItem.ToString() == "Português")
            {
                CultureInfo ci = new CultureInfo("pt-Br");
                Assembly a = Assembly.Load("Desktop");
                ResourceManager rm = new ResourceManager(
                    "Desktop.Lang.Langres", a);
                lblUsuario.Text = rm.GetString("Usuario", ci);
                lblSenha.Text = rm.GetString("Senha", ci);
                checkBoxMs.Text = rm.GetString("Mostrar Senha");
                labelIdioma.Text = rm.GetString("Idioma");
                btnEntrar.Text = rm.GetString("Entrar");
                btnSair.Text = rm.GetString("Sair");
                btnNovoUsu.Text = rm.GetString("Novo Usuario");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNovoUsu_Click(object sender, EventArgs e)
        {
            new checkAdm().ShowDialog();
        }
    }
}
