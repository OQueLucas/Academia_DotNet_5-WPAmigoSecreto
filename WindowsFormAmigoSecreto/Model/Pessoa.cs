﻿namespace WindowsFormAmigoSecreto.Model
{
    public class Pessoa
    {
        public Pessoa(string nome)
        {
            Nome = nome;
            Email = Util.GerarEmail(nome);
        }

        public Pessoa(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public string Nome { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return Nome + ";" + Email;
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
