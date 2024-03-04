using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace exocdan8todoapp.Models
{
    public class Utilisateur
    {

        private int _id;
        private string _username;
        private string _motDePasse;

        public Utilisateur()
        {
        }

        public Utilisateur(int id, string username, string motDePasse)
        {
            _id = id;
            _username = username;
            _motDePasse = motDePasse;
        }

        public int Id { get => _id; set => _id = value; }
        public string Username { get => _username; set => _username = value; }
        public string MotDePasse { get => _motDePasse; set => _motDePasse = value; }
    }
}