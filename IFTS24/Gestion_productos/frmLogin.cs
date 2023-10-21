using System;
using System.Windows.Forms;
using GP.BE;

namespace Gestion_productos
{
    public partial class frmLogin : Form
    {
        private Login users = new Login();

        public frmLogin()
        {
            InitializeComponent();

            this.AcceptButton = this.btnLogin;

            var usersToAdd = new List<User>
            {
                new User("Pass.001", "Alexander"),
                new User("Pass.001", "Rocio"),
                new User("Pass.001", "Hugo"),
                new User("Pass.001", "Leo"),
                new User("Pass.001", "Marcos"),
                new User("Pass.001", "Lisset"),
                new User("Pass.001", "Michelle")
            };

            this.users.UserList.AddRange(usersToAdd);

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

            var validUserName = this.users.ValidateUserName(userName);
            var validPassword = this.users.ValidatePassword(password);

            if (validUserName == 0 && validPassword == 0)
            {
                var frmCliente = new frmClientes(this);
                frmCliente.FormClosed += (s, args) => this.Close(); //TODO revisar porque no cierra formulario de login
                frmCliente.Show();
            }
            else if (validUserName == 1)
            {
                MessageBox.Show("UserName incorrecto", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (validPassword == 1)
            {
                MessageBox.Show("Password incorrecto", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Error en el logeo", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}