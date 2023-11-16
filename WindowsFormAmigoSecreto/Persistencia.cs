using System.Text;
using WindowsFormAmigoSecreto.Model;

namespace WindowsFormAmigoSecreto
{
    internal class Persistencia
    {
        static readonly string file = @"\pessoas.csv";
        static readonly string pathAmigoSecreto = @"..\..\..\Data\amigoSecreto.csv";

        /// <summary>
        /// método estático que pega as pessoas salvas no arquivo do caminho selecionado e armazena na lista.
        /// </summary>
        /// <param name="listPessoas"></param>
        /// <param name="Path"></param>
        public static void CSVReaderPessoas(List<Pessoa> pessoas, string newPath)
        {
            StreamReader? streamReader = null;

                newPath = Path.Combine(newPath + file);

            try
            {
                streamReader = new(newPath, Encoding.UTF8);

                while (!streamReader.EndOfStream)
                {
                    string[] line = streamReader.ReadLine().Split(";");
                    Pessoa pessoa = new(line[0], line[1]);
                    if (!pessoas.Contains(pessoa))
                    {
                        pessoas.Add(pessoa);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível abrir o arquivo.\n" + e.Message, e.GetType().Name);
            }
            finally
            {
                streamReader?.Close();
            }
        }
        
        /// <summary>
        /// método estático que pega as pessoas salvas no arquivo do caminho selecionado e armazena na lista.
        /// </summary>
        /// <param name="listPessoas"></param>
        /// <param name="Path"></param>
        public static void CSVWriterPessoa(List<Pessoa> listPessoas, string newPath)
        {
            StreamWriter? streamWriter = null;

            List<Pessoa> pessoas = new();
            DialogResult result = DialogResult.Yes;

            CSVReaderPessoas(pessoas, newPath);

            newPath = Path.Combine(newPath + file);

            if (pessoas.Count > 0)
            {
                result = MessageBox.Show($"Lista já populada, deseja refazer?", "", MessageBoxButtons.YesNo);
            }

            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                streamWriter = File.CreateText(newPath);
                foreach (Pessoa p in listPessoas)
                {
                    streamWriter.WriteLine(p);
                }
                MessageBox.Show("Novo arquivo gerado com sucesso!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.GetType().Name);
            }
            finally
            {
                streamWriter?.Close();
            }
        }

        /// <summary>
        /// método estático que pega os pares de amigos salvas no arquivo do caminho selecionado e armazena na lista.
        /// </summary>
        /// <param name="listAmigosSecretos"></param>
        /// <param name="Path"></param>
        public static void CSVReaderAmigo(List<AmigoSecreto> listAmigosSecretos)
        {
            StreamReader? streamReader = null;
            try
            {
                streamReader = new(pathAmigoSecreto, Encoding.UTF8);

                while (!streamReader.EndOfStream)
                {
                    string[] line = streamReader.ReadLine().Split(";");
                    Pessoa pessoa = new(line[0], line[1]);
                    Pessoa amigo = new(line[2], line[3]);
                    AmigoSecreto amigoSecreto = new(pessoa, amigo);
                    if (!listAmigosSecretos.Contains(amigoSecreto))
                    {
                        listAmigosSecretos.Add(amigoSecreto);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Não foi possível abrir o arquivo.");
            }
            finally
            {
                streamReader?.Close();
            }
        }

        /// <summary>
        /// método estático que pega os pares de amigos salvas no arquivo do caminho selecionado e armazena na lista.
        /// </summary>
        /// <param name="listAmigosSecretos"></param>
        /// <param name="Path"></param>
        public static void CSVWriterAmigo(List<AmigoSecreto> listAmigosSecretos)
        {
            StreamWriter? streamWriter = null;
            try
            {
                streamWriter = File.CreateText(pathAmigoSecreto);
                foreach (AmigoSecreto amigoSecreto in listAmigosSecretos)
                {
                    streamWriter.WriteLine(amigoSecreto);
                }
            }
            catch (Exception)
            {
                throw new Exception();
            }
            finally
            {
                streamWriter?.Close();
            }
        }

        /// <summary>
        /// método estático procura pessoa na lista a partir do parametro passado.
        /// </summary>
        /// <param name="listPessoas"></param>
        /// <param name="input"></param>
        /// <returns>pessoa encontrada ou null se não for encontrada</returns>
        public static Pessoa FindPessoa(List<Pessoa> listPessoas, string input)
        {
            Pessoa? pessoa;

            if (listPessoas.Count == 0)
            {
                throw new Exception("Lista vazia!");
            }

            if (Util.EmailIsValid(input))
            {
                pessoa = listPessoas.FirstOrDefault(p => p.Email.ToUpper() == input.ToUpper());
            }
            else
            {
                pessoa = listPessoas.FirstOrDefault(p => p.Nome.ToUpper() == input.ToUpper());
            }

            if (pessoa == null)
            {
                return null;
            }

            return pessoa;
        }

        /// <summary>
        /// método estático procura pessoa na lista a partir do parametro passado.
        /// </summary>
        /// <param name="listPessoas"></param>
        /// <param name="input"></param>
        /// <returns>verdadeiro se remover a pessoa</returns>
        public static bool RemovePessoa(List<Pessoa> listPessoas, Pessoa pessoa)
        {
            if (pessoa == null)
            {
                throw new Exception("Não há ninguém com essa compatibilidade!");
            }

            DialogResult result = MessageBox.Show($"Tem certeza que deseja remover {pessoa.Nome}", "Excluir pessoa", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return false;
            }

            listPessoas.Remove(pessoa);
            MessageBox.Show($"{pessoa.Nome} foi excluído(a) com sucesso!");
            return true;
        }
    }
}


