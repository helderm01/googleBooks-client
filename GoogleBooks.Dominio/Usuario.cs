using System;

namespace GoogleBooks.Dominio
{
    public class Usuario
    {
        public Usuario(string email)
        {
            Id = Guid.NewGuid().ToString();
            Email = email;
        }

        public string Id { get; private set; }
        public string Email { get; private set; }
    }
}
