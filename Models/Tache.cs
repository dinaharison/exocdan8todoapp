using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace exocdan8todoapp.Models
{
    public class Tache
    {
        private int _tacheid;
        private string _username;
        private string _description;
        private bool _state;

        public int Tacheid { get => _tacheid; set => _tacheid = value; }
        public string Username { get => _username; set => _username = value; }
        public string Description { get => _description; set => _description = value; }
        public bool State { get => _state; set => _state = value; }

        public Tache()
        {
        }

        public Tache(int tacheid, string username, string description, bool state)
        {
            _tacheid = tacheid;
            _username = username;
            _description = description;
            _state = state;
        }

        public Tache(string username, string description, bool state)
        {
            _username = username;
            _description = description;
            _state = state;
        }
    }
}