using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_productos
{
    public partial class frmClientes : Form
    {
        private frmLogin loginForm;

        public frmClientes()
        {
            InitializeComponent();
        }

        public frmClientes(frmLogin loginForm)
            :this()
        {
            InitializeComponent();
            this.loginForm = loginForm;
        }
    }
}
