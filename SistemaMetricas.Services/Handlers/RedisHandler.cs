using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMetricas.Services.Handlers
{
    public class RedisHandler
    {
        private RedisClient cliente;

        public RedisHandler()
        {
            this.cliente = new RedisClient();
            var redisManager = new RedisManagerPool();

        }

        public void Set(string clave, string valor) //recibe como variable la clave y el valor
        {
            this.cliente.Set<string>(clave, valor);
        }

        public string Get(string clave) //solo la clave
        {
            return this.cliente.Get<string>(clave);
        }

        public void Del(string clave) //solo la clave 
        {
            this.cliente.Del(clave);
        }
    }
}
