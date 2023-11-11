namespace WindowsFormAmigoSecreto
{
    internal class Pessoa
    {
        public Pessoa(string nome)
        {
            Nome = nome;
            Email = Util.GerarEmail(nome);
        }

        public string Nome { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return Nome + " " + Email;
        }

        public override bool Equals(object? obj)
        {
            Pessoa PessoaObj = obj as Pessoa;

            if (obj == null) return false;

            return Email.ToUpper().Equals(PessoaObj.Email.ToUpper());
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
