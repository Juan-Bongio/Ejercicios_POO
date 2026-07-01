namespace Perfil_Usuario
{
    public class Usuario
    {
        private string nombreDeUsuario;
        private string password;
        private string email;

        public string NombreDeUsuario
        {
            get { return nombreDeUsuario; }
            set { nombreDeUsuario = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Usuario(string nombreDeUsuario, string password, string email)
        {
            this.nombreDeUsuario = nombreDeUsuario;
            this.password = password;
            this.email = email;
        }

        public void CambiarPassword(string antigua, string nueva)
        {
            if (antigua == password)
            {
                password = nueva;
                Console.WriteLine("Password cambiada correctamente");
            }
            else
            {
                Console.WriteLine("La password antigua es incorrecta");
            }
        }
    }
}