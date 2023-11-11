namespace WindowsFormAmigoSecreto
{
    internal class Util
    {
        /// <summary>
        /// Metodo estatico de gerar email do usuário
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static string GerarEmail(string nome)
        {
            string[] vetor = nome.Split(" ");

            return (vetor[0] + "." + vetor[^1] + "@ufn.com.br").ToLower();
        }
    }
}
