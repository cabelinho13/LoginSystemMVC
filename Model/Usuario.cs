using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystemMVC.Model
{
    public class Usuario
    {
        public string Login { get; set; }
        public string Senha { get; set; }

        public Usuario(string login, string senha)
        {
            Login = login;
            Senha = senha;
        }
    }
}
