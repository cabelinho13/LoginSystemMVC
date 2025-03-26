using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginSystemMVC.Model;

namespace LoginSystemMVC.Controller
{
    public class LoginController
    {
        private List<Usuario> usuarios = new List<Usuario>
        {
            new Usuario("admin", "1234"),
            new Usuario("user", "senha")
        };

        public bool ValidarLogin(string login, string senha)
        {
            return usuarios.Any(u => u.Login == login && u.Senha == senha);
        }
    }
}
