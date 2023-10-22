using GP.BE;
using GP.DAO;

namespace GP.BLL
{
    public static class Validaciones
    {
        // 0 -> logeo valido
        // 1 -> username incorrecto
        // 2 -> password incorrecto
        // 3 -> error en validacion
        public static int ValidarLogin(string password, string userName)
        {
            try
            {
                var usuariosAlmacenados = UsuariosDao.Usuarios;
                var usuarioEncontrado = usuariosAlmacenados.Where(x => x.UserName == userName).FirstOrDefault();

                if (usuarioEncontrado == null)
                    return 1;
                if (usuarioEncontrado.Password != password)
                    return 2;

                return 0;
            }
            catch (Exception ex)
            {
                return 3;
            }
        }
    }
}
