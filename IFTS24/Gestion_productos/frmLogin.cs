using System;
using System.Windows.Forms;
using GP.BE;
using GP.BLL;
using GP.DAO;

namespace Gestion_productos
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            this.AcceptButton = this.btnLogin;

            var usersToAdd = new List<Usuario>
            {
                new Usuario(1,"Pass.001", "Alexander"),
                new Usuario(2,"Pass.001", "Rocio"),
                new Usuario(3,"Pass.001", "Hugo"),
                new Usuario(4,"Pass.001", "Leo"),
                new Usuario(5,"Pass.001", "Marcos"),
                new Usuario(6,"Pass.001", "Lisset"),
                new Usuario(7,"Pass.001", "Michelle")
            };

            UsuariosDao.Usuarios.AddRange(usersToAdd);
        }

        /// <summary>
        /// Boton personalizado para cerrar ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Boton personalizado para minimizar ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = this.txtUserName.Text;
            string password = this.txtPassword.Text;

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Se deben ingresar todos los campos", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var logeoValido = Validaciones.ValidarLogin(password, userName);

            if (logeoValido == 0)
            {
                var frmCliente = new frmClientes(this);
                frmCliente.FormClosed += (s, args) => this.Close(); //TODO revisar porque no cierra formulario de login
                frmCliente.Show();
            }
            else if (logeoValido == 1)
                MessageBox.Show("Usuario inexistante", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (logeoValido == 2)
                MessageBox.Show("Password incorrecto", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Error en el logeo", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}