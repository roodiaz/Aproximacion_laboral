namespace GP.BE
{
    public class Usuario
    {
        private int id;
        private string? userName;
        private string? password;
        private Roles rol;

        /// <summary>
        /// Contructor
        /// </summary>
        public Usuario()
        {
            this.id = 0;
            this.password = string.Empty;
            this.userName = string.Empty;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="password">password de usuario</param>
        /// <param name="email">email de usuario</param>
        public Usuario(int id, string password, string userName)
        {
            this.id = id;
            this.password = password;
            this.userName = userName;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        /// <summary>
        /// Propiedad get y set para atributo userName
        /// </summary>
        public string? UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }

        /// <summary>
        /// Propiedad get y set para atributo password
        /// </summary>
        public string? Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public Roles Rol
        {
            get { return this.rol; }
            set { this.rol = value; }
        }
    }
}
