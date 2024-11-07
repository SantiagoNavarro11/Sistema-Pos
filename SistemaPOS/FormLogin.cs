using Microsoft.IdentityModel.Tokens;
using SistemaPos.Entidades;
using SistemasPos.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPOS
{
    public partial class FormLogin : Form
    {
        private NegocioUsuario objNegocioUsuario;
        public FormLogin()
        {
            InitializeComponent();
            objNegocioUsuario = new NegocioUsuario();
            this.Text = $"{Textos.TITULO_APP} - [Autenticación]";
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();
            string mensaje = "";

            Usuario usuario = objNegocioUsuario.Validar(nombreUsuario, contraseña, ref mensaje);

            if (mensaje.IsNullOrEmpty())
            {
                FormPrincipal mainForm = new FormPrincipal();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(mensaje);
            }
            
        }
    }
}
