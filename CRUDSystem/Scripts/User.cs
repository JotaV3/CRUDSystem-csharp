namespace CRUDSystem.Scripts
{
    public class User
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Telephone { get; private set; }
        public string CPF { get; private set; }

        public User(string name, string email, string telephone, string cpf)
        {
            Name = name;
            Email = email;
            Telephone = telephone;  
            CPF = cpf;
        }
    }
}