namespace WindowsFormAmigoSecreto
{
    public class AmigoSecreto
    {
        private string _nome;
        private string _email;
        private string _nomeAmigo;
        private string _emailAmigo;

        public string Nome { get { return _nome; } set { _nome = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string NomeAmigo { get { return _nomeAmigo; } set { _nomeAmigo = value; } }
        public string EmailAmigo { get { return _emailAmigo; } set { _emailAmigo = value; } }

        public AmigoSecreto() { }

        public AmigoSecreto(Pessoa pessoa, Pessoa amigo)
        {
            Nome = pessoa.Nome;
            Email = pessoa.Email;
            NomeAmigo = amigo.Nome;
            EmailAmigo = amigo.Email;
        }

        public override string ToString()
        {
            return Nome + ";" + Email + ";" + NomeAmigo + ";" + EmailAmigo;
        }

        public override bool Equals(object? obj)
        {
            AmigoSecreto PessoaObj = obj as AmigoSecreto;

            if (obj == null) return false;

            return Email.ToUpper().Equals(PessoaObj.Email.ToUpper());
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
