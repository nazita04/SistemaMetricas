using SistemaMetricas.Services.Handlers;

namespace SistemaMetricas.Handlers
{
    public class DatosGlobales
    {
        public static string UsuarioLogeado = string.Empty;
        public static string AreaUsuario = string.Empty;


        RedisHandler redisHandler = new RedisHandler();

        public void SetRedis(string usuario, string area)
        {
            redisHandler.Set("usuario", usuario);
            redisHandler.Set("area", area);


            UsuarioLogeado = redisHandler.Get("usuario");
            AreaUsuario = redisHandler.Get("area");
        }


    }
}
