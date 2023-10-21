namespace GP.BE
{
    public class User
    {
        private string? userName;
        private string? password;

        /// <summary>
        /// Contructor
        /// </summary>
        public User()
        {
            this.password = string.Empty;
            this.userName = string.Empty;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="password">password de usuario</param>
        /// <param name="email">email de usuario</param>
        public User(string password, string userName)
        {
            this.password = password;
            this.userName = userName;
        }

        /// <summary>
        /// Propiedad get y set para atributo userName
        /// </summary>
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        /// <summary>
        /// Propiedad get y set para atributo password
        /// </summary>
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
