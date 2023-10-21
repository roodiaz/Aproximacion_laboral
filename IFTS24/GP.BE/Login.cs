namespace GP.BE
{
    public class Login
    {
        private List<User> usersList;

        // Constructor por defecto
        public Login()
        {
            this.usersList = new List<User>();
        }

        // Constructor que permite inicializar la lista de usuarios con una lista existente
        public Login(List<User> userList)
            : this()
        {
            this.usersList = userList;
        }

        // Propiedad para acceder a la lista de usuarios
        public List<User> UserList
        {
            get { return this.usersList; }
            set { this.usersList = value; }
        }

        // 0 -> logeo valido
        // 1 -> password incorrecto
        // 2 -> error en validacion
        public int ValidatePassword(string password)
        {
            try
            {
                foreach (var user in this.UserList)
                {
                    if (user.Password == password)
                        return 0;
                }

                return 1;
            }
            catch (Exception ex)
            {
                return 2;
            }
        }

        // 0 -> logeo valido
        // 1 -> username incorrecto
        // 2 -> error en validacion
        public int ValidateUserName(string userName)
        {
            try
            {
                foreach (var user in this.UserList)
                {
                    if (user.UserName == userName)
                        return 0;
                }

                return 1;
            }
            catch (Exception ex)
            {
                return 2;
            }
        }
    }
}
