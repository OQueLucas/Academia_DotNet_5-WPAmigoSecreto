using System.Text.RegularExpressions;

namespace WindowsFormAmigoSecreto
{
    internal class Util
    {
        /// <summary>
        /// método estático que recebe um nome completo e cria um email da UFN
        /// </summary>
        /// <param name="nome"></param>
        /// <returns>email no domínio UFN</returns>
        public static string GerarEmail(string nome)
        {
            string[] vetor = nome.Split(" ");

            return (vetor[0] + "." + vetor[^1] + "@ufn.com.br").ToLower();
        }

        /// <summary>
        /// método estático que faz a validação do email passado por parametro
        /// </summary>
        /// <param name="email"></param>
        /// <returns>retorna verdadeiro caso o email seja valido</returns>
        public static bool EmailIsValid(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string pattern = @"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)+$";

            return Regex.IsMatch(email, pattern);
        }
    }
}
