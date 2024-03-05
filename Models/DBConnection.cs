using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace exocdan8todoapp.Models
{
    public static class DBConnection
    {
        public static NpgsqlConnection connectionString =
            new NpgsqlConnection(
                ConfigurationManager.ConnectionStrings["TodoDatabaseConnection"].ConnectionString
                );

        public static List<Tache> retrouverTaches(string username)
        {
            var req = $"SELECT * FROM public.\"Tache\" WHERE username = '{username}'";
            var taches = new List<Tache>();
            try
            {
                connectionString.Open();
                var cmd = new NpgsqlCommand(req, connectionString);
                var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    var tache = new Tache(rd.GetInt32(0), rd.GetString(1), rd.GetString(2), rd.GetBoolean(3));
                    taches.Add(tache);
                }
                connectionString.Close();
            }
            catch (Exception e)
            {
                throw e;
            }

            return taches;
        }
    }
}