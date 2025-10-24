using Newtonsoft.Json;
using SistemaMetricas.Models;
using SistemaMetricas.Services.Handlers;
using System;
using System.Collections.Generic;
using System.Data;

namespace SistemaMetricas.Services.Services
{
    public class SecurityService
    {
        public List<Func> GetFuncRolList(string rol)
        {
            string json = SqliteHandler.GetJson("select * from FuncRol where rolId = " + rol);
            List<Func> lista = JsonConvert.DeserializeObject<List<Func>>(json);
            return lista;
        }

        public DataTable GetRoles()
        {
            return SqliteHandler.GetDt("SELECT * FROM Roles");
        }

        public string GetRolByLogin(string login)
        {
            return SqliteHandler.GetScalar($"select Rol from Login where Usuario = '{login}'");
        }


        public bool CrearRol(string nuevoRol)
        {
            string query = $"INSERT INTO Roles VALUES (null, '{nuevoRol}')";
            return SqliteHandler.Exec(query);
        }

    }
}
