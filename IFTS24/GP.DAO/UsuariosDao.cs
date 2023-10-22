using GP.BE;

namespace GP.DAO
{
    public class UsuariosDao
    {
        private static List<Usuario> usuarios = new List<Usuario>();

        // Propiedad para acceder a la lista de usuarios
        public static List<Usuario> Usuarios
        {
            get { return usuarios; }
            set { usuarios = value; }
        }
    }
}