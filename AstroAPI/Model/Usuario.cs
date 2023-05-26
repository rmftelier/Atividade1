using AstroAPI.Model.Enum;

namespace AstroAPI.Model
{
    public class Usuario
    {
        public string Username { get; set; }
        public Signo Signo { get; set; }

        public Usuario(string username)
        {
            Username = username;
        }
    }
}
