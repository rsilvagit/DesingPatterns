using ChainOfResponsability.MIddlewares;
using System;
using System.Collections.Generic;


namespace ChainOfResponsability.Servers
{
   class Server
    {
        private Dictionary<string, string> user = new Dictionary<string, string>();
        private Middleware middleware;
        public void SetMiddleware(Middleware middleware)
        {
            this.middleware = middleware;
        }

        public Boolean LogIn(string email, string password)
        {
            if (middleware.Check(email,password))
            {
                Console.WriteLine("Usuario autenticado");
                Console.WriteLine("Seja Bem-vindo...");
                return true;
            }
            return false;
        }
        public void RegisterUser(string email,string password)
        {
            user[email] = password;

        }
        public Boolean HasEmail(string email)
        {
            return user.ContainsKey(email);
        }
        public Boolean IsValidPassword(string email, string password)
        {
            string value = "";
            user.TryGetValue(email, out value);
            return password == value;
        }
    }
}
