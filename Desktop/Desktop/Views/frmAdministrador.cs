using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Views
{
    public partial class frmAdministrador : Form
    {
        public frmAdministrador()
        {
            InitializeComponent();
        }

        private void frmAdministrador_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = this.Size;
            this.Text = "Novo Usuário - AirSystem";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnListUser_Click(object sender, EventArgs e)
        {
            new frmListaUsuario().ShowDialog();
        }
    }
}
